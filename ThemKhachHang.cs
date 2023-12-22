using BookstoreManager.DAO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManager
{
    public partial class ThemKhachHang : MaterialForm
    {
        public ThemKhachHang()
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
            string maKH = KHACHHANGDAO.Instance.GetIDOfCustomer();
            int lastNumber = int.Parse(maKH.Substring(2).Trim());
            int nextNumber = lastNumber + 1;
            string nextID = string.Format("KH{0:D3}", nextNumber);

            txbMaKH.Text = nextID.ToString();
            txbHoTen.Text = "";
            txbSDT.Text = "";
            txbDiaChi.Text = "";
        }

        #endregion

        #region events
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
            if (txbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                return;
            }
            if (txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo");
                return;
            }

            string maKH = txbMaKH.Text;
            string soDT = txbSDT.Text;
            string hoTen = txbHoTen.Text;
            string diaChi = txbDiaChi.Text;
            if (KHACHHANGDAO.Instance.InsertCustomer(maKH, hoTen, diaChi, soDT) == true)
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo");
            }
            LoadInit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbDiaChi.Text = "";
            txbHoTen.Text = "";
            txbSDT.Text = "";
        }

        #endregion
    }
}
