using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManager
{
    public partial class Main_Admin : MaterialForm
    {
        public Main_Admin()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);
        }

        private void AdminTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = this.AdminTabControl.SelectedTab.Text;
        }
    }
}
