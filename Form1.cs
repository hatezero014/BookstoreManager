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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(46, 109, 255), Color.FromArgb(88, 46, 255), Color.FromArgb(46, 213, 255), Color.FromArgb(187, 221, 255), TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(55, 71, 79), Color.FromArgb(55, 59, 79), Color.FromArgb(55, 79, 75), Color.FromArgb(130, 108, 96), TextShade.WHITE);
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = this.materialTabControl1.SelectedTab.Text;
        }
    }
}
