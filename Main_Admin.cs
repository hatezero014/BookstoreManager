using BookstoreManager.DAO;
using BookstoreManager.DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace BookstoreManager
{
    public partial class Main_Admin : MaterialForm
    {

        string maNV;

        public Main_Admin(string maNV, int type)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            this.maNV = maNV;
            if (type == 0)
            {
                this.AdminTabControl.TabPages.Remove(EmployeeTab);
            }
            Load();
        }

        #region methods

        new void Load()
        {
            LoadSach();

            LoadNhapSach();

            LoadBanHang();

            LoadNhanVien();

            LoadKhachHang();
        }

        public void LoadSach()
        {
            dtgvSach.Rows.Clear();
            List<SACH> listSach = SACHDAO.Instance.GetListSach();

            foreach (SACH sach in listSach)
            {
                DataGridViewRow row = new DataGridViewRow();

                string namXB = sach.NamXB.ToString();

                if (namXB == "0")
                    namXB = "NULL";

                row.CreateCells(dtgvSach, sach.MaSach, sach.TenSach, sach.TacGia, sach.MaLS, sach.GiaSach, sach.SoLuong, sach.MaNXB, namXB, sach.MoTa);

                dtgvSach.Rows.Add(row);
            }
            dtgvSach.Refresh();
        }

        public void LoadBanHang()
        {
            List<HOADONBANHANG> listBanHang = HOADONBANHANGDAO.Instance.GetListBanHang();

            dtgvBanHang.Rows.Clear();

            foreach (HOADONBANHANG banhang in listBanHang)
            {
                DataGridViewRow row = new DataGridViewRow();

                KHACHHANG khachHang = KHACHHANGDAO.Instance.GetCustomerByID(banhang.MaKH);

                string tenNV = NHANVIENDAO.Instance.GetStaffByID(banhang.MaNV).HoTen;

                row.CreateCells(dtgvBanHang, banhang.MaBH, banhang.MaKH, khachHang.HoTen, khachHang.SoDT, banhang.MaNV, tenNV, banhang.NgayBan.ToShortDateString(), FormatMoney(banhang.TongTien));

                dtgvBanHang.Rows.Add(row);
            }
            dtgvSach.Refresh();
        }

        public void LoadNhapSach()
        {
            dtgvNhapSach.Rows.Clear();

            List<HOADONNHAPSACH> listNhapSach = HOADONNHAPSACHDAO.Instance.GetListNhapSach();

            foreach (HOADONNHAPSACH nhapSach in listNhapSach)
            {
                DataGridViewRow row = new DataGridViewRow();

                string tenNCC = NHACUNGCAPDAO.Instance.GetNCCByID(nhapSach.MaNCC).TenNCC;

                string tenNV = NHANVIENDAO.Instance.GetStaffByID(nhapSach.MaNV).HoTen;

                row.CreateCells(dtgvNhapSach, nhapSach.MaNS, nhapSach.MaNCC, tenNCC, nhapSach.MaNV, tenNV, nhapSach.NgayNhap.ToShortDateString(), FormatMoney(nhapSach.TongTien));

                dtgvNhapSach.Rows.Add(row);
            }
            dtgvSach.Refresh();
        }

        public void LoadNhanVien()
        {
            dtgvNhanVien.Rows.Clear();

            List<NHANVIEN> listNhanVien = NHANVIENDAO.Instance.GetListStaff();

            foreach (NHANVIEN nhanvien in listNhanVien)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dtgvNhanVien, nhanvien.MaNV, nhanvien.HoTen, nhanvien.SoDT, nhanvien.Email, nhanvien.DiaChi, nhanvien.NgaySinh.ToShortDateString(), nhanvien.CCCD);

                dtgvNhanVien.Rows.Add(row);
            }
            dtgvSach.Refresh();
        }

        public void LoadKhachHang()
        {
            dtgvKhachHang.Rows.Clear();

            List<KHACHHANG> listKhachHang = KHACHHANGDAO.Instance.GetListCustomer();

            foreach (KHACHHANG khachhang in listKhachHang)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dtgvKhachHang, khachhang.MaKH, khachhang.HoTen, khachhang.SoDT, khachhang.DiaChi);

                dtgvKhachHang.Rows.Add(row);
            }
            dtgvSach.Refresh();
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

        string FormatString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            string normalizedString = input.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().ToLowerInvariant();
        }

        #endregion

        private void AdminTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = this.AdminTabControl.SelectedTab.Text;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemSach themSach = new ThemSach();
            themSach.ShowDialog();
            LoadSach();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemGiamGia themGiamGia = new ThemGiamGia();
            themGiamGia.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemTheLoaiSach themTheLoaiSach = new ThemTheLoaiSach();
            themTheLoaiSach.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemNhaXuatBan themNhaXuatBan = new ThemNhaXuatBan();
            themNhaXuatBan.ShowDialog();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BanHang banHang = new BanHang(maNV);
            banHang.ShowDialog();
            LoadBanHang();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NhapSach nhapSach = new NhapSach(maNV);
            nhapSach.ShowDialog();
            LoadNhapSach();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemKhachHang themKhachHang = new ThemKhachHang();
            themKhachHang.ShowDialog();
            LoadKhachHang();
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
            LoadNhanVien();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemTaiKhoan themTaiKhoan = new ThemTaiKhoan();
            themTaiKhoan.ShowDialog();
        }

        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvNhanVien.Rows[e.RowIndex];
                string maNV = selectedRow.Cells["clNV1"].Value.ToString().Trim();
                XemNhanVien xemNV = new XemNhanVien(maNV);
                xemNV.ShowDialog();
                LoadNhanVien();
            }
        }

        private void dtgvNhapSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvNhapSach.Rows[e.RowIndex];
                string maHD = selectedRow.Cells["clNS1"].Value.ToString().Trim();
                XemCTNS xemCTNS = new XemCTNS(maHD);
                xemCTNS.ShowDialog();
                LoadNhapSach();
            }
        }

        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvKhachHang.Rows[e.RowIndex];
                string maKH = selectedRow.Cells["clKH1"].Value.ToString().Trim();
                XemKhachHang xemKH = new XemKhachHang(maKH);
                xemKH.ShowDialog();
                LoadKhachHang();
            }
        }

        private void dtgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            string pattern = FormatString(txbTimKiemSach.Text).Trim();
            if (pattern.Length == 0)
            {
                LoadSach();
                return;
            }
            string typeSearch = "clSach1";
            if (rBtnSachTS.Checked == true)
            {
                typeSearch = "clSach2";
            }
            foreach (DataGridViewRow row in dtgvSach.Rows)
            {
                string cellValue = FormatString(row.Cells[typeSearch].Value.ToString()).Trim();
                if (KMP.Instance.SolveKMP(cellValue, pattern))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            string pattern = FormatString(txbTimKiemKH.Text).Trim();
            if (pattern.Length == 0)
            {
                LoadKhachHang();
                return;
            }
            string typeSearch = "clKH1";
            if (rBtnTenKH.Checked == true)
            {
                typeSearch = "clKH2";
            }
            if (rBtnSDTKH.Checked == true)
            {
                typeSearch = "clKH3";
            }
            foreach (DataGridViewRow row in dtgvKhachHang.Rows)
            {
                string cellValue = FormatString(row.Cells[typeSearch].Value.ToString()).Trim();
                if (KMP.Instance.SolveKMP(cellValue, pattern))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            string pattern = FormatString(txbTimKiemNV.Text).Trim();
            if (pattern.Length == 0)
            {
                LoadNhanVien();
                return;
            }
            string typeSearch = "clNV1";
            if (rBtnTenNV.Checked == true)
            {
                typeSearch = "clNV2";
            }
            if (rBtnSDTNV.Checked == true)
            {
                typeSearch = "clNV3";
            }
            foreach (DataGridViewRow row in dtgvNhanVien.Rows)
            {
                string cellValue = FormatString(row.Cells[typeSearch].Value.ToString()).Trim();
                if (KMP.Instance.SolveKMP(cellValue, pattern))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnTimKiemNS_Click(object sender, EventArgs e)
        {
            string pattern = FormatString(txbTimKiemNS.Text).Trim();
            if (pattern.Length == 0)
            {
                LoadNhapSach();
                return;
            }
            string typeSearch = "clNS1";
            if (rBtnMaNCC.Checked == true)
            {
                typeSearch = "clNS2";
            }
            if (rBtnMaNV.Checked == true)
            {
                typeSearch = "clNS3";
            }
            if (rBtnNgayTaoNS.Checked == true)
            {
                typeSearch = "clNS4";
            }
            foreach (DataGridViewRow row in dtgvNhapSach.Rows)
            {
                string cellValue = FormatString(row.Cells[typeSearch].Value.ToString()).Trim();
                if (KMP.Instance.SolveKMP(cellValue, pattern))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnTimKiemBH_Click(object sender, EventArgs e)
        {
            string pattern = FormatString(txbTimKiemBH.Text).Trim();
            if (pattern.Length == 0)
            {
                LoadBanHang();
                return;
            }
            string typeSearch = "clBH1";
            if (rBtnNgayTaoBH.Checked == true)
            {
                typeSearch = "clBH4";
            }
            if (rBtnSDTKHBH.Checked == true)
            {
                typeSearch = "clBH2";
            }
            if (rBtnMaNVBH.Checked == true)
            {
                typeSearch = "clBH3";
            }
            foreach (DataGridViewRow row in dtgvBanHang.Rows)
            {
                string cellValue = FormatString(row.Cells[typeSearch].Value.ToString()).Trim();
                if (KMP.Instance.SolveKMP(cellValue, pattern))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void rBtnMaKHBH_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
