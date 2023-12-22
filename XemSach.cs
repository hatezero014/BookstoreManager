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
    public partial class XemSach : MaterialForm
    {
        public XemSach(string maSach)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);
            LoadForm(maSach);
        }

        #region methods
        void LoadForm(string maSach)
        {
            LoadNXB();
            LoadLS();
            LoadInfo(maSach);
        }
        void LoadLS()
        {
            List<LOAISACH> list = LOAISACHDAO.Instance.GetListLoaiSach();

            cbLoaiSach.DataSource = list;
            cbLoaiSach.DisplayMember = "TenLS";
        }

        void LoadInfo(string maSach)
        {
            SACH sach = SACHDAO.Instance.LoadBookByID(maSach);

            txbMaSach.Text = sach.MaSach;
            txbGiaSach.Text = FormatMoney(sach.GiaSach);
            cbLoaiSach.Text = sach.MaLS;
            txbMoTaSach.Text = sach.MoTa;
            txbNamXBSach.Text = sach.NamXB.ToString();
            txbSLSach.Text = sach.SoLuong.ToString();
            txbTenSach.Text = sach.TenSach;
            txbTacGiaSach.Text = sach.TacGia;
            cbNXBSach.Text = NHAXUATBANDAO.Instance.GetNXBByID(sach.MaNXB).TenNXB;
        }
        void LoadNXB()
        {
            List<NHAXUATBAN> list = NHAXUATBANDAO.Instance.GetListNXB();

            cbNXBSach.DataSource = list;
            cbNXBSach.DisplayMember = "TenNXB";
        }
        string FormatMoney(decimal? originalValue)
        {
            string formattedString = string.Format("{0:C}", originalValue);
            formattedString = formattedString.Replace("$", "").Trim();
            int indexOfDecimal = formattedString.IndexOf(".");
            if (indexOfDecimal != -1)
            {
                formattedString = formattedString.Substring(0, indexOfDecimal);
            }
            return formattedString;
        }
        #endregion

        #region events
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            string idSach = txbMaSach.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa sách này không?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (SACHDAO.Instance.DeleteBookByID(idSach) == true)
                {
                    MessageBox.Show("Xoá sách thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xoá sách thất bại!", "Thông báo");
                }
                this.Close();
            }
        }

        private void btnUpdateSach_Click(object sender, EventArgs e)
        {
            if (txbTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Thông báo");
                return;
            }
            if (txbTacGiaSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tác giả sách!", "Thông báo");
                return;
            }
            if (txbSLSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng sách!", "Thông báo");
                return;
            }
            if (cbNXBSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản!", "Thông báo");
                return;
            }
            if (cbLoaiSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại sách!", "Thông báo");
                return;
            }
            if (txbGiaSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá sách!", "Thông báo");
                return;
            }
            string iDSach = txbMaSach.Text;
            string tenSach = txbTenSach.Text;
            string tacGia = txbTacGiaSach.Text;
            decimal giaSach = decimal.Parse(txbGiaSach.Text);
            short? namXB = null;
            if (txbNamXBSach.Text != "")
            {
                namXB = short.Parse(txbNamXBSach.Text);
            }
            string moTa = txbMoTaSach.Text;
            int soLuong = int.Parse(txbSLSach.Text);
            string tenNXB = cbNXBSach.Text;
            string loaiSach = cbLoaiSach.Text;
            if (SACHDAO.Instance.UpdateBookByID(iDSach, tenSach, tacGia, giaSach, namXB, moTa, soLuong, tenNXB, loaiSach) == true)
            {
                MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sách thất bại!", "Thông báo");
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
