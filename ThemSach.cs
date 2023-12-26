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
    public partial class ThemSach : MaterialForm
    {
        public ThemSach()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            LoadData();
        }

        #region methods
        void LoadData()
        {
            LoadNXB();
            cbNXB.SelectedIndex = -1;
            LoadInit();
            LoadLS();
            cbLoaiSach.SelectedIndex = -1;
        }
        void LoadNXB()
        {
            List<NHAXUATBAN> list = NHAXUATBANDAO.Instance.GetListNXB();

            cbNXB.DataSource = list;
            cbNXB.DisplayMember = "TenNXB";
        }

        void LoadLS()
        {
            List<LOAISACH> list = LOAISACHDAO.Instance.GetListLoaiSach();

            cbLoaiSach.DataSource = list;
            cbLoaiSach.DisplayMember = "TenLS";

        }

        void LoadInit()
        {
            string maSach = SACHDAO.Instance.GetIdOfBook();
            int lastBookNumber = int.Parse(maSach.Substring(2));
            int nextBookNumber = lastBookNumber + 1;
            string nextBookID = string.Format("S{0:D4}", nextBookNumber);

            txbMaSach.Text = nextBookID.ToString();
            txbTenSach.Text = "";
            txbTacGia.Text = "";
            cbLoaiSach.Text = "";
            txbMoTa.Text = "";
            cbNXB.Text = "";
            txbNamXB.Text = "";
        }

        #endregion

        #region events
        private void materialButton2_Click(object sender, EventArgs e)
        {
            txbTenSach.Text = "";
            txbTacGia.Text = "";
            cbLoaiSach.Text = "";
            txbMoTa.Text = "";
            cbNXB.Text = "";
            txbNamXB.Text = "";
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txbTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Thông báo");
                return;
            }
            if (txbTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tác giả sách!", "Thông báo");
                return;
            }
            if (cbNXB.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản!", "Thông báo");
                return;
            }
            if (cbLoaiSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại sách!", "Thông báo");
                return;
            }
            string maSach = txbMaSach.Text;
            string tenSach = txbTenSach.Text;
            string loaiSach = cbLoaiSach.Text;
            string nhaXB = cbNXB.Text;
            string moTa = txbMoTa.Text;
            short? namXB = null;
            if (txbNamXB.Text != "")
            {
                namXB = short.Parse(txbNamXB.Text);
            }
            string tacGia = txbTacGia.Text;

            if (SACHDAO.Instance.InsertBook(maSach, tenSach, tacGia, namXB, moTa, nhaXB, loaiSach) == true)
            {
                MessageBox.Show("Thêm sách thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại!", "Thông báo");
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
