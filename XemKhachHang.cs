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
    public partial class XemKhachHang : MaterialForm
    {
        public XemKhachHang(string maKH)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            LoadInfo(maKH);
        }

        #region methods

        void LoadInfo(string maKH)
        {
            KHACHHANG khachhang = KHACHHANGDAO.Instance.LoadCustomerByID(maKH);

            txbMaKH.Text = khachhang.MaKH;
            txbSDT.Text = khachhang.SoDT;
            txbHoTen.Text = khachhang.HoTen;
            txbDiaChi.Text = khachhang.DiaChi;
        }

        #endregion

        #region events
        private void readOnlyTxb_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string maKH = txbMaKH.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (KHACHHANGDAO.Instance.SortDelete(maKH) == true)
                {
                    MessageBox.Show("Xoá khách hàng thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xoá khách hàng thất bại!", "Thông báo");
                }
                this.Close();
            }
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
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
            if (KHACHHANGDAO.Instance.UpdateCustomerByID(maKH, hoTen, diaChi, soDT) == true)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thất bại!", "Thông báo");
            }
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
