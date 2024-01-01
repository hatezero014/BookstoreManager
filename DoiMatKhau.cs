using BookstoreManager.DAO;
using BookstoreManager.DTO;
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
    public partial class DoiMatKhau : MaterialForm
    {
        private string maNV;
        public DoiMatKhau(string maNV)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);
            this.maNV = maNV;


            TAIKHOAN taiKhoan = TAIKHOANDAO.Instance.GetTKByMaNV(maNV);

            txbTaiKhoan.Text = taiKhoan.TaiKhoan;
        }

        private void materialTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                return;
            }
            if (txbMatKhauMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo");
                return;
            }
            if (txbNLMatKhauMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới!", "Thông báo");
                return;
            }

            string matKhau = txbMatKhau.Text;
            string matKhauMoi = txbMatKhauMoi.Text;
            string nhapLaiMK = txbNLMatKhauMoi.Text;

            TAIKHOAN taiKhoan = TAIKHOANDAO.Instance.GetTKByMaNV(maNV);

            if (taiKhoan.MatKhau.Trim() == matKhau.Trim())
            {
                if (matKhauMoi == nhapLaiMK)
                {
                    if (TAIKHOANDAO.Instance.UpdateTKByID(taiKhoan.TaiKhoan, matKhau))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp", "Thông báo");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo");
                return;
            }
        }
    }
}
