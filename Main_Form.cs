using BookstoreManager.DAO;
using BookstoreManager.DTO;
using LiveCharts.Wpf.Charts.Base;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace BookstoreManager
{
    public partial class Main_Form : MaterialForm
    {

        string maNV;

        public Main_Form(string maNV, int type)
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
            txbNam.Text = DateTime.Now.Year.ToString();
            txbThang.Text = DateTime.Now.Month.ToString();
            Load();
        }

        #region methods

        /* void LoadTaiKhoan()
        {
            TAIKHOAN taiKhoan = TAIKHOANDAO.Instance.GetTKByMaNV(maNV);
            txbMaNV.Text = maNV;
            txbTaiKhoan.Text = taiKhoan.TaiKhoan;
            NHANVIEN nhanVien = NHANVIENDAO.Instance.GetStaffByID(maNV);
            txbHoTen.Text = nhanVien.HoTen;
            txbEmail.Text = nhanVien.Email;
            txbDiaChi.Text = nhanVien.DiaChi;
            txbNgaySinh.Text = nhanVien.NgaySinh.ToString("dd-MM-yyyy");
            txbCCCD.Text = nhanVien.CCCD;
            txbSoDT.Text = nhanVien.SoDT;
        } */

        void LoadChart()
        {
            TAIKHOAN taiKhoan = TAIKHOANDAO.Instance.GetTKByMaNV(maNV);

            chart1.Series.Clear();

            chart1.ResetAutoValues();

            chart1.Series.Add("Doanh thu");
            chart1.Series.Add("Chi phí");

            int year = int.Parse(txbNam.Text);
            int month = int.Parse(txbThang.Text);

            int daysInMonth = DateTime.DaysInMonth(year, month);

            decimal doanhThuThang = 0;
            decimal chiPhiThang = 0;

            for (int i = 1; i <= daysInMonth; i++)
            {
                decimal doanhThu = 0;
                decimal chiPhi = 0;

                List<HOADONBANHANG> listBH = new List<HOADONBANHANG>();
                List<HOADONNHAPSACH> listNS = new List<HOADONNHAPSACH>();

                if (taiKhoan.Loai == 0)
                {
                    listBH = HOADONBANHANGDAO.Instance.GetListBHByNgayTaoAndMaNV(maNV, $"{year}-{month}-{i}");
                    listNS = HOADONNHAPSACHDAO.Instance.GetListNSByNgayTaoAndMaNV(maNV, $"{year}-{month}-{i}");
                }
                else
                {
                    listBH = HOADONBANHANGDAO.Instance.GetListBHByNgayTao($"{year}-{month}-{i}");
                    listNS = HOADONNHAPSACHDAO.Instance.GetListNSByNgayTao($"{year}-{month}-{i}");
                }

                foreach (HOADONBANHANG item in listBH)
                {
                    doanhThu += item.TongTien;
                }

                foreach (HOADONNHAPSACH item in listNS)
                {
                    chiPhi += item.TongTien;
                }

                doanhThuThang += doanhThu;
                chiPhiThang += chiPhi;

                chart1.Series["Doanh thu"].Points.AddXY(i, doanhThu);
                chart1.Series["Chi phí"].Points.AddXY(i, chiPhi);
            }

            lbDoanhThu.Text = FormatMoney(doanhThuThang);
            lbChiPhi.Text = FormatMoney(chiPhiThang);

            chart1.Series["Doanh thu"].ChartType = SeriesChartType.Column;
            chart1.Series["Chi phí"].ChartType = SeriesChartType.Column;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Title = "Số tiền VNĐ";
            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.Invalidate();
        }

        void LoadTrangChu()
        {
            TAIKHOAN taiKhoan = TAIKHOANDAO.Instance.GetTKByMaNV(maNV);

            if (taiKhoan.Loai == 0)
            {
                lbTrangChu.Text = $"Bảng thống kê theo tháng của nhân viên: {maNV}";
            }
            else
            {
                lbTrangChu.Text = $"Bảng thống kê theo tháng của nhà sách";
            }

            int year = int.Parse(txbNam.Text);
            int month = int.Parse(txbThang.Text);

            List<CTBH> listBH = new List<CTBH>();
            List<CTNS> listNS = new List<CTNS>();


            if (taiKhoan.Loai == 0)
            {
                listBH = CTBHDAO.Instance.GetListBHByNgayTaoAndMaNV(maNV, month, year);
                listNS = CTNSDAO.Instance.GetListNSByNgayTaoAndMaNV(maNV, month, year);
            }
            else
            {
                listBH = CTBHDAO.Instance.GetListBHByNgayTao(month, year);
                listNS = CTNSDAO.Instance.GetListNSByNgayTao(month, year);
            }

            int SLSachBan = 0, SLSachNhap = 0;

            foreach (CTBH item in listBH)
            {
                SLSachBan += item.SoLuong;

            }
            foreach (CTNS item in listNS)
            {
                SLSachNhap += item.SoLuong;
            }

            lbSLSachBan.Text = SLSachBan.ToString();
            lbSLSachNhap.Text = SLSachNhap.ToString();
        }

        new void Load()
        {
            LoadTrangChu();

            LoadChart();

            LoadSach();

            LoadNhapSach();

            LoadBanHang();

            LoadNhanVien();

            LoadKhachHang();

            // LoadTaiKhoan();
        }

        public void LoadSach()
        {
            dtgvSach.Rows.Clear();
            List<SACH> listSach = SACHDAO.Instance.GetListSach();

            foreach (SACH sach in listSach)
            {
                if (sach.SoLuong < 0)
                    continue;

                DataGridViewRow row = new DataGridViewRow();

                string namXB = sach.NamXB.ToString();

                if (namXB == "0")
                    namXB = "NULL";

                string giaSach = FormatMoney(sach.GiaSach);

                if (giaSach == "")
                    giaSach = "-1";

                row.CreateCells(dtgvSach, sach.MaSach, sach.TenSach, giaSach, sach.SoLuong, sach.TacGia, sach.MaLS, sach.MaNXB, namXB, sach.MoTa);

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
            LoadChart();
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
            LoadChart();
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
                if (khachhang.HoTen == "Đã xóa")
                    continue;
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

        private void themSach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemSach themSach = new ThemSach();
            themSach.ShowDialog();
            LoadSach();
        }

        private void themNCC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemNhaCungCap themNCC = new ThemNhaCungCap();
            themNCC.ShowDialog();
            LoadNhapSach();
        }

        private void themGiamGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemGiamGia themGiamGia = new ThemGiamGia();
            themGiamGia.ShowDialog();
            LoadSach();
        }

        private void themTheLoaiSach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemTheLoaiSach themTheLoaiSach = new ThemTheLoaiSach();
            themTheLoaiSach.ShowDialog();
            LoadSach();
        }

        private void themNXB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemNhaXuatBan themNhaXuatBan = new ThemNhaXuatBan();
            themNhaXuatBan.ShowDialog();
            LoadSach();
        }

        private void themBH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BanHang banHang = new BanHang(maNV);
            banHang.ShowDialog();
            LoadBanHang();
            LoadSach();
        }

        private void themNS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NhapSach nhapSach = new NhapSach(maNV);
            nhapSach.ShowDialog();
            LoadNhapSach();
            LoadSach();
        }

        private void themKhachHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemKhachHang themKhachHang = new ThemKhachHang();
            themKhachHang.ShowDialog();
            LoadKhachHang();
            LoadBanHang();
        }

        private void themNhanVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
            LoadNhanVien();
            LoadBanHang();
            LoadNhapSach();
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
            if (rBtnMaNVNS.Checked == true)
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

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (int.Parse(txbThang.Text) > 12 || int.Parse(txbThang.Text) < 1)
            {
                MessageBox.Show("Tháng không hợp lệ!", "Warning");
                return;
            }

            if (int.Parse(txbNam.Text) > DateTime.Now.Year || int.Parse(txbThang.Text) < 1)
            {
                MessageBox.Show("Năm không hợp lệ!", "Warning");
                return;
            }
            LoadChart();
            LoadTrangChu();
        }

        private void Main_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txbThang_TextChanged(object sender, EventArgs e)
        {
            txbThang.SelectionStart = txbThang.Text.Length;
            txbThang.SelectionLength = 0;
        }

        private void txbNam_TextChanged(object sender, EventArgs e)
        {
            txbNam.SelectionStart = txbNam.Text.Length;
            txbNam.SelectionLength = 0;
        }

        private void txbNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //private void btnCapNhatTT_Click(object sender, EventArgs e)
        //{
        //    if (txbSoDT.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
        //        return;
        //    }
        //    if (txbEmail.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập email!", "Thông báo");
        //        return;
        //    }
        //    if (txbDiaChi.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo");
        //        return;
        //    }

        //    string soDT = txbSoDT.Text;
        //    string email = txbEmail.Text;
        //    string diaChi = txbDiaChi.Text;
        //    string hoTen = txbHoTen.Text;
        //    string cCCD = txbCCCD.Text;
        //    DateTime ngaySinh = DateTime.ParseExact(txbNgaySinh.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        //    if (NHANVIENDAO.Instance.UpdateStaffByID(maNV, hoTen, diaChi, ngaySinh, email, soDT, cCCD) == true)
        //    {
        //        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
        //        LoadNhanVien();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo");
        //    }
        //}

        //private void btnDoiMatKhau_Click(object sender, EventArgs e)
        //{
        //    if (txbMatKhau.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
        //        return;
        //    }
        //    if (txbMatKhauMoi.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo");
        //        return;
        //    }
        //    if (txbNLMatKhauMoi.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập lại mật khẩu mới!", "Thông báo");
        //        return;
        //    }
        //    string matKhau = txbMatKhau.Text;
        //    string matKhauMoi = txbMatKhauMoi.Text;
        //    string nhapLaiMK = txbNLMatKhauMoi.Text;

        //    TAIKHOAN taiKhoan = TAIKHOANDAO.Instance.GetTKByMaNV(maNV);

        //    if (taiKhoan.MatKhau.Trim() == matKhau.Trim())
        //    {
        //        if (matKhauMoi == nhapLaiMK)
        //        {
        //            if (TAIKHOANDAO.Instance.UpdateTKByID(taiKhoan.TaiKhoan, matKhau))
        //            {
        //                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Mật khẩu mới không trùng khớp", "Thông báo");
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Sai mật khẩu", "Thông báo");
        //        return;
        //    }
        //}

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemTaiKhoan themTaiKhoan = new ThemTaiKhoan();
            themTaiKhoan.ShowDialog();
        }

        private void dtgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvNhanVien.Rows[e.RowIndex];
                string maNV = selectedRow.Cells["clNV1"].Value.ToString().Trim();
                XemNhanVien xemNV = new XemNhanVien(maNV);
                xemNV.ShowDialog();
                LoadNhanVien();
                LoadBanHang();
                LoadNhapSach();
            }
        }

        private void dtgvNhapSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvNhapSach.Rows[e.RowIndex];
                string maHD = selectedRow.Cells["clNS1"].Value.ToString().Trim();
                XemCTNS xemCTNS = new XemCTNS(maHD);
                xemCTNS.ShowDialog();
            }
        }

        private void dtgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvKhachHang.Rows[e.RowIndex];
                string maKH = selectedRow.Cells["clKH1"].Value.ToString().Trim();
                XemKhachHang xemKH = new XemKhachHang(maKH);
                xemKH.ShowDialog();
                LoadKhachHang();
                LoadBanHang();
            }
        }

        private void dtgvSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvSach.Rows[e.RowIndex];
                string maSach = selectedRow.Cells["clSach1"].Value.ToString().Trim();
                XemSach xemSach = new XemSach(maSach);
                xemSach.ShowDialog();
                LoadSach();
            }
        }

        private void dtgvBanHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvBanHang.Rows[e.RowIndex];
                string maHD = selectedRow.Cells["clBH1"].Value.ToString().Trim();
                XemCTBH xemCTBH = new XemCTBH(maHD);
                xemCTBH.ShowDialog();
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

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            XemCaNhan xemCaNhan = new XemCaNhan(maNV);
            xemCaNhan.ShowDialog();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(maNV);
            doiMatKhau.ShowDialog();
        }
    }
}
