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
    public partial class BanHang : MaterialForm
    {
        public BanHang()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);
        }

        private void BanHang_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
