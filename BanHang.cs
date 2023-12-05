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
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(199, 0, 0), TextShade.WHITE);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // xoá sách trong cthd
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // đặt lại textbox
            BookNoComboBox.SelectedItem = "Chọn sách";
            QuantityTextBox.Text = "0";
            BookNameTextBox.Text = "";
            UnitPriceTextBox.Text = "";
            TotalPriceTextBox.Text = "";
        }
    }
}
