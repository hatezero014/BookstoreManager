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
    public partial class XemCaNhan : MaterialForm
    {
        private string maNV;
        public XemCaNhan(string maNV)
        {
            InitializeComponent(); MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);
            this.maNV = maNV;

            Load();
        }

        void Load()
        {
            txbMaNV.Text = maNV;
            NHANVIEN nhanVien = NHANVIENDAO.Instance.GetStaffByID(maNV);
            txbTenNV.Text = nhanVien.HoTen;
            txbEmailNV.Text = nhanVien.Email;
            txbDiaChiNV.Text = nhanVien.DiaChi;
            txbNgaySinhNV.Text = nhanVien.NgaySinh.ToString("dd-MM-yyyy");
            txbCCCDNV.Text = nhanVien.CCCD;
            txbSDTNV.Text = nhanVien.SoDT;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
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

            string soDT = txbSDTNV.Text;
            string email = txbEmailNV.Text;
            string diaChi = txbDiaChiNV.Text;
            string hoTen = txbTenNV.Text;
            string cCCD = txbCCCDNV.Text;
            string input = txbNgaySinhNV.Text.Trim();
            if (!DateTime.TryParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Ngày tháng không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                return;
            }
            DateTime ngaySinh = DateTime.ParseExact(txbNgaySinhNV.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            if (NHANVIENDAO.Instance.UpdateStaffByID(maNV, hoTen, diaChi, ngaySinh, email, soDT, cCCD) == true)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo");
            }
        }
    }
}
