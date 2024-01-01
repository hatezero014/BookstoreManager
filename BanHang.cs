using BookstoreManager.DAO;
using BookstoreManager.DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManager
{
    public partial class BanHang : MaterialForm
    {
        private PrintDocument printDocument;
        public BanHang(string maNV)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            Load(maNV);
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 13, FontStyle.Bold);
            Font normalFont = new Font("Arial", 13);
            Font totalFont = new Font("Arial", 13, FontStyle.Bold);

            float x = 20, y = 10;

            float titleWidth = e.Graphics.MeasureString("Hóa Đơn Bán Sách", titleFont).Width;

            float titleX = (e.PageBounds.Width - titleWidth) / 2;

            e.Graphics.DrawString("Hóa Đơn Bán Sách", titleFont, Brushes.Black, titleX, y);
            y += 60;

            KHACHHANG khachHang = KHACHHANGDAO.Instance.GetCustomerBySDT(txbSDTKH.Text);

            e.Graphics.DrawString($"Mã Hóa Đơn: {txbMaHD.Text}", headerFont, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString($"Tên Khách Hàng: {khachHang.HoTen}", headerFont, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString($"Số Điện Thoại: {khachHang.SoDT}", headerFont, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString($"Mã Nhân Viên: {txbMaNV.Text}", headerFont, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString($"Ngày tạo: {txbNgayTao.Text}", headerFont, Brushes.Black, x, y);
            y += 70;

            e.Graphics.DrawString("Mã Sách", headerFont, Brushes.Black, x, y);
            e.Graphics.DrawString("Tên Sách", headerFont, Brushes.Black, x + 100, y);
            e.Graphics.DrawString("Số Lượng", headerFont, Brushes.Black, x + 450, y);
            e.Graphics.DrawString("Đơn Giá", headerFont, Brushes.Black, x + 600, y);
            e.Graphics.DrawString("Thành Tiền", headerFont, Brushes.Black, x + 700, y);
            y += 20;
            decimal totalAmount = 0;

            for (int i = 0; i < dtgvCTBH.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dtgvCTBH.Rows[i];
                string maSach = row.Cells["Column1"].Value.ToString().Trim();
                string tenSach = row.Cells["Column2"].Value.ToString().Trim();
                int soLuong = Convert.ToInt32(row.Cells["Column3"].Value.ToString().Trim());
                decimal donGia = Convert.ToDecimal(row.Cells["Column4"].Value.ToString().Trim());
                decimal thanhTien = Convert.ToDecimal(row.Cells["Column5"].Value.ToString().Trim());
                totalAmount += thanhTien;

                e.Graphics.DrawString(maSach, normalFont, Brushes.Black, x, y);
                e.Graphics.DrawString(tenSach, normalFont, Brushes.Black, x + 100, y);
                e.Graphics.DrawString(soLuong.ToString(), normalFont, Brushes.Black, x + 450, y);
                e.Graphics.DrawString(FormatMoney(donGia), normalFont, Brushes.Black, x + 600, y);
                e.Graphics.DrawString(FormatMoney(thanhTien), normalFont, Brushes.Black, x + 700, y);
                y += 20;
            }

            y += 20;

            e.Graphics.DrawString("Tổng Tiền", totalFont, Brushes.Black, x, y);
            e.Graphics.DrawString(FormatMoney(totalAmount), totalFont, Brushes.Black, x + 700, y);
        }


        #region methods

        new void Load(string maNV)
        {
            LoadSach();
            LoadInit(maNV);
        }

        void LoadInit(string maNV)
        {
            string maNS = HOADONBANHANGDAO.Instance.GetIDOfBH();
            int lastNumber = int.Parse(maNS.Substring(2).Trim());
            int nextNumber = lastNumber + 1;
            string nextID = string.Format("BH{0:D3}", nextNumber);

            txbMaHD.Text = nextID.ToString();
            txbNgayTao.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txbMaNV.Text = maNV;
            cbListSach.Text = "";
            cbListSach.SelectedIndex = -1;
        }

        void LoadSach()
        {
            List<SACH> list = SACHDAO.Instance.GetListSachNotNull();

            cbListSach.DataSource = list;
            cbListSach.DisplayMember = "TenSach";
        }

        string FormatMoney(decimal? originalValue)
        {
            string formattedString = string.Format("{0:C}", originalValue);
            formattedString = formattedString.Replace("$", "").Trim();
            int indexOfDecimal = formattedString.IndexOf(".");
            if (indexOfDecimal != -1)
            {
                formattedString = formattedString.Substring(0, indexOfDecimal);
            }
            return formattedString;
        }

        void Clear()
        {
            txbSLBan.Text = "";
            txbSLKho.Text = "";
            txbThanhTien.Text = "";
            txbDonGia.Text = "";
            txbMaSach.Text = "";
            dtgvCTBH.ClearSelection();
            cbListSach.SelectedIndex = -1;
            cbListSach.Refresh();
            btnXoa.Enabled = false;
        }

        DataGridViewRow RowExists(DataGridView dataGridView, string searchValue)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Column1"].Value != null && row.Cells["Column1"].Value.ToString().Trim() == searchValue.Trim())
                {
                    return row;
                }
            }

            return null;
        }


        #endregion

        #region events
        private void readOnlyTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b') e.Handled = true;
            e.Handled = true;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy hóa đơn không?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txbDonGia_TextChanged_1(object sender, EventArgs e)
        {
            if (txbDonGia.Text != "")
                txbDonGia.Text = FormatMoney(decimal.Parse(txbDonGia.Text));
            txbDonGia.SelectionStart = txbDonGia.Text.Length;
            if (!string.IsNullOrEmpty(txbSLBan.Text) && !string.IsNullOrEmpty(txbDonGia.Text))
            {
                int SL = int.Parse(txbSLBan.Text);
                decimal gia = decimal.Parse(txbDonGia.Text);
                decimal thanhtien = gia * SL;
                txbThanhTien.Text = FormatMoney(thanhtien);
            }
            else
            {
                txbThanhTien.Text = "";
            }
        }

        private void btnHuyChon_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSach = txbMaSach.Text.ToString();

            DataGridViewRow row = RowExists(dtgvCTBH, maSach);

            if (row != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn loại bỏ sách này không?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    decimal thanhTien = decimal.Parse(txbThanhTien.Text.Trim());
                    decimal thanhToan = decimal.Parse(lbThanhTien.Text);
                    thanhToan -= thanhTien;
                    lbThanhTien.Text = FormatMoney(thanhToan);


                    dtgvCTBH.Rows.Remove(row);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã sách trong hóa đơn!", "Thông báo");
            }
        }

        private void dtgvCTBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dtgvCTBH.Rows.Count - 1)
            {
                Clear();
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvCTBH.Rows[e.RowIndex];

                string maSach = selectedRow.Cells["Column1"].Value.ToString().Trim();
                string tenSach = selectedRow.Cells["Column2"].Value.ToString().Trim();
                string soLuong = selectedRow.Cells["Column3"].Value.ToString().Trim();
                string donGia = selectedRow.Cells["Column4"].Value.ToString().Trim();
                string thanhTien = selectedRow.Cells["Column5"].Value.ToString().Trim();

                txbSLBan.Text = soLuong;
                txbThanhTien.Text = thanhTien;
                txbDonGia.Text = donGia;
                cbListSach.Text = tenSach;
                txbMaSach.Text = maSach;
                btnXoa.Enabled = true;
                cbListSach.Refresh();
            }
            else
            {
                dtgvCTBH.ClearSelection();
            }
        }

        private void btnThemSach_Click_1(object sender, EventArgs e)
        {
            if (cbListSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sách!", "Thông báo");
                return;
            }
            if (txbDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá!", "Thông báo");
                return;
            }
            if (txbSLBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng sách!", "Thông báo");
                return;
            }

            if (int.Parse(txbSLBan.Text) > int.Parse(txbSLKho.Text))
            {
                MessageBox.Show("Không đủ sách bán!", "Thông báo");
                return;
            }

            string maSach = txbMaSach.Text.ToString();

            if (RowExists(dtgvCTBH, maSach) == null)
            {
                string tenSach = cbListSach.Text.Trim();
                string soLuong = txbSLBan.Text.Trim();
                string donGia = txbDonGia.Text.Trim();

                decimal thanhTien = decimal.Parse(txbThanhTien.Text.Trim());
                decimal thanhToan = decimal.Parse(lbThanhTien.Text.Trim());
                thanhToan += thanhTien;
                lbThanhTien.Text = FormatMoney(thanhToan);

                string[] newRowValues = { maSach, tenSach, soLuong, donGia, FormatMoney(decimal.Parse(thanhTien.ToString().Trim())) };

                dtgvCTBH.Rows.Add(newRowValues);

                Clear();
            }
            else
            {
                MessageBox.Show("Mã sách đã tồn tại trong hóa đơn!", "Thông báo");
            }
        }

        private void txbDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbListSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenSach = cbListSach.Text;

            SACH sach = SACHDAO.Instance.GetBookByName(tenSach);

            if (sach != null)
            {
                txbMaSach.Text = sach.MaSach;
                txbSLKho.Text = sach.SoLuong.ToString();
                txbDonGia.Text = sach.GiaSach.ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string soDT = txbSDTKH.Text;

            KHACHHANG khachHang = KHACHHANGDAO.Instance.GetCustomerBySDT(soDT);

            if (soDT == "" || khachHang == null)
            {
                MessageBox.Show("Số điện thoại khách hàng không hợp lệ!", "Warning");
                return;
            }

            string maKH = khachHang.MaKH;

            if (dtgvCTBH.Rows.Count > 1)
            {
                string maBH = txbMaHD.Text;
                string maNV = txbMaNV.Text;
                DateTime parsedDateTime = DateTime.ParseExact(txbNgayTao.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                string ngayTao = parsedDateTime.ToString("yyyy-MM-dd");
                decimal thanhToan = decimal.Parse(lbThanhTien.Text);

                if (MessageBox.Show("Đồng ý tạo hóa đơn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    HOADONBANHANGDAO.Instance.InsertBH(maBH, maKH, maNV, ngayTao, thanhToan);

                    for (int i = 0; i < dtgvCTBH.Rows.Count - 1; i++)
                    {
                        var row = dtgvCTBH.Rows[i];
                        string maSach = row.Cells["Column1"].Value.ToString().Trim();
                        string tenSach = row.Cells["Column2"].Value.ToString().Trim();
                        int soLuong = int.Parse(row.Cells["Column3"].Value.ToString().Trim());
                        decimal donGia = decimal.Parse(row.Cells["Column4"].Value.ToString().Trim());
                        decimal thanhTien = decimal.Parse(row.Cells["Column5"].Value.ToString().Trim());

                        CTBHDAO.Instance.InsertCTBH(maBH, maSach, donGia, soLuong, thanhTien);

                        SACH sach = SACHDAO.Instance.GetBookByID(maSach);
                        LOAISACH loaiSach = LOAISACHDAO.Instance.GetLoaiSachByID(sach.MaLS.Trim());
                        NHAXUATBAN nxb = NHAXUATBANDAO.Instance.GetNXBByID(sach.MaNXB);
                        SACHDAO.Instance.UpdateBookByID(maSach, tenSach, sach.TacGia.Trim(), sach.GiaSach, sach.NamXB, sach.MoTa.Trim(),
                                                            sach.SoLuong - soLuong, nxb.TenNXB.Trim(), loaiSach.TenLS, sach.GiaGoc);
                    }
                    MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo");
                    PrintDialog printDialog = new PrintDialog();

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDialog.Document = printDocument;

                        printDocument.Print();
                    }
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Hóa đơn chưa có sách!", "Thông báo");
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document = printDocument;

                printDocument.Print();
            }
        }

        private void txbSLBan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbSLBan.Text) && !string.IsNullOrEmpty(txbDonGia.Text))
            {
                int SL = int.Parse(txbSLBan.Text);
                decimal gia = decimal.Parse(txbDonGia.Text);
                decimal thanhtien = gia * SL;
                txbThanhTien.Text = FormatMoney(thanhtien);
            }
            else
            {
                txbThanhTien.Text = "";
            }
        }

        private void txbSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void readOnlyTxb_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        #endregion
    }
}
