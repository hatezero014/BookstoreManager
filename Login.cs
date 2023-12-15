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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);
        }

        #region methods
        int isLogin(string username, string password)
        {
            return TAIKHOANDAO.Instance.Login(username, password);
        }
        #endregion

        #region events
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPass.Text;
            int isCheckAccount = isLogin(username, password);

            if (isCheckAccount >= 0)
            {
                if (isCheckAccount == 0)
                {
                    Main_NhanVien main_Employee = new Main_NhanVien();
                    main_Employee.Show();
                }
                else
                {
                    Main_Admin main_Admin = new Main_Admin();
                    main_Admin.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK);
            }
            return;
        }
        #endregion
    }
}
