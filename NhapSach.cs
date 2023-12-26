using BookstoreManager.DAO;
using BookstoreManager.DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BookstoreManager
{
    public partial class NhapSach : MaterialForm
    {
        public NhapSach(string maNV)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            Load(maNV);
        }

        #region methods

        new void Load(string maNV)
        {
            LoadSach();
            LoadInit(maNV);
        }

        void LoadInit(string maNV)
        {
            string maNS = HOADONNHAPSACHDAO.Instance.GetIDOfNS();
            int lastNumber = int.Parse(maNS.Substring(2).Trim());
            int nextNumber = lastNumber + 1;
            string nextID = string.Format("NS{0:D3}", nextNumber);

            txbMaHD.Text = nextID.ToString();
            txbNgayTao.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txbMaNV.Text = maNV;
            cbListSach.Text = "";
            cbListSach.SelectedIndex = -1;
            cbListSach.Invalidate();
        }

        void LoadSach()
        {
            List<SACH> list = SACHDAO.Instance.GetListSach();

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

        void Clear()
        {
            txbSLNhap.Text = "";
            txbSLKho.Text = "";
            txbThanhTien.Text = "";
            txbDonGia.Text = "";
            txbMaSach.Text = "";
            dtgvCTNS.ClearSelection();
            cbListSach.SelectedIndex = -1;
            cbListSach.Refresh();
        }

        #endregion

        #region events

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy hóa đơn không?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
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
            }
        }

        private void txbDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txbDonGia.Text != "")
                txbDonGia.Text = FormatMoney(decimal.Parse(txbDonGia.Text));
            txbDonGia.SelectionStart = txbDonGia.Text.Length;
            if (!string.IsNullOrEmpty(txbSLNhap.Text) && !string.IsNullOrEmpty(txbDonGia.Text))
            {
                int SL = int.Parse(txbSLNhap.Text);
                decimal gia = decimal.Parse(txbDonGia.Text);
                decimal thanhtien = gia * SL;
                txbThanhTien.Text = FormatMoney(thanhtien);
            }
            else
            {
                txbThanhTien.Text = "";
            }
        }

        private void txbSLNhap_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbSLNhap.Text) && !string.IsNullOrEmpty(txbDonGia.Text))
            {
                int SL = int.Parse(txbSLNhap.Text);
                decimal gia = decimal.Parse(txbDonGia.Text);
                decimal thanhtien = gia * SL;
                txbThanhTien.Text = FormatMoney(thanhtien);
            }
            else
            {
                txbThanhTien.Text = "";
            }
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            string maSach = txbMaSach.Text.ToString();

            DataGridViewRow row = RowExists(dtgvCTNS, maSach);

            if (row != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn loại bỏ sách này không?", "Warning") == DialogResult.OK)
                {
                    decimal thanhTien = decimal.Parse(txbThanhTien.Text.Trim());
                    decimal thanhToan = decimal.Parse(lbTongThanhToan.Text);
                    thanhToan -= thanhTien;
                    lbTongThanhToan.Text = FormatMoney(thanhToan);

                    dtgvCTNS.Rows.Remove(row);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã sách trong hóa đơn!", "Thông báo");
            }
        }

        private void dtgvCTNS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvCTNS.Rows[e.RowIndex];

                string maSach = selectedRow.Cells["Column1"].Value.ToString().Trim();
                string tenSach = selectedRow.Cells["Column2"].Value.ToString().Trim();
                string soLuong = selectedRow.Cells["Column3"].Value.ToString().Trim();
                string donGia = selectedRow.Cells["Column4"].Value.ToString().Trim();
                string thanhTien = selectedRow.Cells["Column5"].Value.ToString().Trim();

                txbSLNhap.Text = soLuong;
                txbThanhTien.Text = thanhTien;
                txbDonGia.Text = donGia;
                cbListSach.Text = tenSach;
                txbMaSach.Text = maSach;
            }
            else
            {
                dtgvCTNS.ClearSelection();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string maNCC = txbMaNCC.Text;

            if (maNCC == "" || NHACUNGCAPDAO.Instance.GetNCCByID(maNCC) == null)
            {
                MessageBox.Show("Mã nhà cung cấp không hợp lệ!", "Warning");
                return;
            }

            if (dtgvCTNS.Rows.Count > 1)
            {
                string maNS = txbMaHD.Text;
                string maNV = txbMaNV.Text;
                DateTime parsedDateTime = DateTime.ParseExact(txbNgayTao.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                string ngayTao = parsedDateTime.ToString("yyyy-MM-dd");
                decimal thanhToan = decimal.Parse(lbTongThanhToan.Text);

                if (MessageBox.Show("Đồng ý tạo hóa đơn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    HOADONNHAPSACHDAO.Instance.InsertNS(maNS, maNCC, maNV, ngayTao, thanhToan);

                    for (int i = 0; i < dtgvCTNS.Rows.Count - 1; i++)
                    {
                        var row = dtgvCTNS.Rows[i];
                        string maSach = row.Cells["Column1"].Value.ToString().Trim();
                        string tenSach = row.Cells["Column2"].Value.ToString().Trim();
                        int soLuong = int.Parse(row.Cells["Column3"].Value.ToString().Trim());
                        decimal donGia = decimal.Parse(row.Cells["Column4"].Value.ToString().Trim());
                        decimal thanhTien = decimal.Parse(row.Cells["Column5"].Value.ToString().Trim());

                        CTNSDAO.Instance.InsertCTNS(maNS, maSach, donGia, soLuong, thanhTien);

                        SACH sach = SACHDAO.Instance.GetBookByID(maSach);
                        LOAISACH loaiSach = LOAISACHDAO.Instance.GetLoaiSachByID(sach.MaLS.Trim());
                        NHAXUATBAN nxb = NHAXUATBANDAO.Instance.GetNXBByID(sach.MaNXB);
                        SACHDAO.Instance.UpdateBookByID(maSach, tenSach, sach.TacGia.Trim(), sach.GiaSach, sach.NamXB, sach.MoTa.Trim(),
                                                            sach.SoLuong - soLuong, nxb.TenNXB.Trim(), loaiSach.TenLS);
                    }
                    MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Hóa đơn chưa có sách!", "Thông báo");
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
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
            if (txbSLNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng sách!", "Thông báo");
                return;
            }

            string maSach = txbMaSach.Text.ToString();

            if (RowExists(dtgvCTNS, maSach) == null)
            {
                string tenSach = cbListSach.Text.Trim();
                string soLuong = txbSLNhap.Text.Trim();
                string donGia = txbDonGia.Text.Trim();

                decimal thanhTien = decimal.Parse(txbThanhTien.Text.Trim());
                decimal thanhToan = decimal.Parse(lbTongThanhToan.Text);
                thanhToan += thanhTien;
                lbTongThanhToan.Text = FormatMoney(thanhToan);

                string[] newRowValues = { maSach, tenSach, soLuong, donGia, thanhTien.ToString().Trim() };

                dtgvCTNS.Rows.Add(newRowValues);
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

        #endregion
    }
}
