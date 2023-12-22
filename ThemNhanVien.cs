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
            txbEmail.Text = "";
            txbSDT.Text = "";
            txbCCCD.Text = "";
            txbDiaChi.Text = "";
            txbEmail.Text = "";
        }

        #endregion



        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbHoTen.Text = "";
            txbEmail.Text = "";
            txbSDT.Text = "";
            txbCCCD.Text = "";
            txbDiaChi.Text = "";
            txbEmail.Text = "";
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
            if (txbEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh!", "Thông báo");
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
            DateTime parsedDateTime = DateTime.ParseExact(txbEmail.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
