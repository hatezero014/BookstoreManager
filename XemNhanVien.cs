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
using System.Windows.Forms;

namespace BookstoreManager
{
    public partial class XemNhanVien : MaterialForm
    {
        public XemNhanVien(string maNV)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            LoadInfo(maNV);
        }

        #region methods

        void LoadInfo(string maNV)
        {
            NHANVIEN nhanvien = NHANVIENDAO.Instance.LoadStaffByID(maNV);

            txbMaNV.Text = nhanvien.MaNV;
            txbCCCDNV.Text = nhanvien.CCCD;
            txbEmailNV.Text = nhanvien.Email;
            txbNgaySinhNV.Text = nhanvien.NgaySinh.ToString("dd-MM-yyyy");
            txbSDTNV.Text = nhanvien.SoDT;
            txbTenNV.Text = nhanvien.HoTen;
            txbDiaChiNV.Text = nhanvien.DiaChi;
        }

        #endregion

        #region events

        private void readOnlyTxb_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo");
                return;
            }
            if (txbCCCDNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số CCCD!", "Thông báo");
                return;
            }
            if (txbNgaySinhNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh!", "Thông báo");
                return;
            }
            string input = txbNgaySinhNV.Text.Trim();
            if (!DateTime.TryParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Ngày tháng không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                return;
            }
            int year = int.Parse(txbNgaySinhNV.Text.Substring(6, 4));
            if (year < 1900 || year > 2079)
            {
                MessageBox.Show("Năm không hợp lệ (từ 1900 đến 2079).");
                return;
            }
            if (txbSDTNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                return;
            }
            if (txbEmailNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo");
                return;
            }
            if (txbDiaChiNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo");
                return;
            }

            string maNV = txbMaNV.Text;
            string cCCD = txbCCCDNV.Text;
            string email = txbEmailNV.Text;
            DateTime ngaySinh = DateTime.ParseExact(txbNgaySinhNV.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string soDT = txbSDTNV.Text;
            string tenNV = txbTenNV.Text;
            string diaChi = txbDiaChiNV.Text;
            if (NHANVIENDAO.Instance.UpdateStaffByID(maNV, tenNV, diaChi, ngaySinh, email, soDT, cCCD) == true)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại!", "Thông báo");
            }
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idNV = txbMaNV.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (NHANVIENDAO.Instance.DeleteStaffByID(idNV) == true)
                {
                    MessageBox.Show("Xoá nhân viên thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xoá nhân viên thất bại!", "Thông báo");
                }
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNgaySinhNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}