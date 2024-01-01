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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManager
{
    public partial class XemCTBH : MaterialForm
    {
        private PrintDocument printDocument;
        public XemCTBH(string maBH)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            LoadInfo(maBH);
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

            KHACHHANG khachHang = KHACHHANGDAO.Instance.GetCustomerByID(txbMaKH.Text);

            e.Graphics.DrawString($"Mã Hóa Đơn: {txbMaBH.Text}", headerFont, Brushes.Black, x, y);
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

            for (int i = 0; i < dtgvListCTBH.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dtgvListCTBH.Rows[i];
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

        string FormatMoney(decimal originalValue)
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

        void LoadInfo(string maBH)
        {
            HOADONBANHANG HDBH = HOADONBANHANGDAO.Instance.GetHoaDonBHByID(maBH);
            txbMaBH.Text = maBH;
            txbMaKH.Text = HDBH.MaKH;
            txbMaNV.Text = HDBH.MaNV;
            txbNgayTao.Text = HDBH.NgayBan.ToString("dd-MM-yyyy");
            lbThanhToan.Text = FormatMoney(HDBH.TongTien);

            List<CTBH> listCTBH = CTBHDAO.Instance.GetListCTBHByID(maBH);

            foreach (CTBH ctbh in listCTBH)
            {
                DataGridViewRow row = new DataGridViewRow();

                SACH sach = SACHDAO.Instance.GetBookByID(ctbh.MaSach);

                row.CreateCells(dtgvListCTBH, ctbh.MaSach, sach.TenSach, ctbh.SoLuong,
                                FormatMoney(ctbh.DonGia), FormatMoney(ctbh.ThanhTien));

                dtgvListCTBH.Rows.Add(row);
            }
        }

        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void readOnlyTxb_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
