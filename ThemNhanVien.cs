using BookstoreManager.DAO;
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
    public partial class ThemNhanVien : MaterialForm
    {
        public ThemNhanVien()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            LoadInit();
        }

        #region methods
        void LoadInit()
        {
            string maNV = NHANVIENDAO.Instance.GetIDOfStaff();
            int lastNumber = int.Parse(maNV.Substring(2).Trim());
            int nextNumber = lastNumber + 1;
            string nextID = string.Format("NV{0:D3}", nextNumber);

            txbMaNV.Text = nextID.ToString();
            txbHoTen.Text = "";
            txbNgaySinh.Text = "";
            txbSDT.Text = "";
            txbCCCD.Text = "";
            txbDiaChi.Text = "";
            txbEmail.Text = "";
        }

        #endregion


        private void btnXoa_Click(object sender, EventArgs e)
        {

            txbHoTen.Text = "";
            txbNgaySinh.Text = "";
            txbSDT.Text = "";
            txbCCCD.Text = "";
            txbDiaChi.Text = "";
            txbEmail.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo");
                return;
            }
            if (txbCCCD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số CCCD!", "Thông báo");
                return;
            }
            if (!DateTime.TryParseExact(txbNgaySinh.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Ngày tháng không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                return;
            }
            int year = int.Parse(txbNgaySinh.Text.Substring(6, 4));
            if (year < 1900 || year > 2079)
            {
                MessageBox.Show("Năm không hợp lệ (từ 1900 đến 2079).");
                return;
            }
            if (txbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                return;
            }
            if (txbEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo");
                return;
            }
            if (txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo");
                return;
            }

            string maNV = txbMaNV.Text;
            string hoTen = txbHoTen.Text;
            DateTime parsedDateTime = DateTime.ParseExact(txbNgaySinh.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string ngaySinh = parsedDateTime.ToString("yyyy-MM-dd");
            string soDT = txbSDT.Text;
            string cCCD = txbCCCD.Text;
            string email = txbEmail.Text;
            string diaChi = txbDiaChi.Text;

            if (NHANVIENDAO.Instance.InsertStaff(maNV, hoTen, soDT, email, diaChi, ngaySinh, cCCD) == true)
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
            }
            LoadInit();
        }

        private void txbNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '-' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbCCCD_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
