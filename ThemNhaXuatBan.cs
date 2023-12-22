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
    public partial class ThemNhaXuatBan : MaterialForm
    {
        public ThemNhaXuatBan()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            LoadInfo();
        }

        #region methods

        void LoadInfo()
        {
            dtgvListNXB.Rows.Clear();
            List<NHAXUATBAN> listNXB = NHAXUATBANDAO.Instance.GetListNXB();

            foreach (NHAXUATBAN nxb in listNXB)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dtgvListNXB, nxb.MaNXB, nxb.TenNXB);

                dtgvListNXB.Rows.Add(row);
            }

            DataGridViewRow selectedRow = dtgvListNXB.Rows[0];

            txbMaNXB.Text = selectedRow.Cells["Column1"].Value.ToString().Trim();
            txbTenNXB.Text = selectedRow.Cells["Column2"].Value.ToString().Trim();
        }

        #endregion

        #region events

        private void dtgvListNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dtgvListNXB.Rows.Count - 1)
            {
                txbMaNXB.Text = "";
                txbTenNXB.Text = "";
                dtgvListNXB.ClearSelection();
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvListNXB.Rows[e.RowIndex];

                txbMaNXB.Text = selectedRow.Cells["Column1"].Value.ToString().Trim();
                txbTenNXB.Text = selectedRow.Cells["Column2"].Value.ToString().Trim();
            }
            else
            {
                dtgvListNXB.ClearSelection();
            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            string maNXB = txbMaNXB.Text;

            NHAXUATBAN loaisach = NHAXUATBANDAO.Instance.GetNXBByID(maNXB);

            if (loaisach != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa nhà xuất bản này không?", "Warning") == DialogResult.OK)
                {
                    if (NHAXUATBANDAO.Instance.DeleteNXBByID(maNXB))
                    {
                        MessageBox.Show("Xoá nhà xuất bản thành công!", "Thông báo");
                        txbMaNXB.Text = "";
                        txbTenNXB.Text = "";
                        LoadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Xoá nhà xuất bản thất bại!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã nhà xuất bản!", "Thông báo");
            }
        }

        private void btnHuyChonNXB_Click(object sender, EventArgs e)
        {
            txbMaNXB.Text = "";
            txbTenNXB.Text = "";
            dtgvListNXB.ClearSelection();
        }

        private void btnCapNhatNXB_Click(object sender, EventArgs e)
        {
            string maNXB = txbMaNXB.Text;
            string tenNXB = txbTenNXB.Text;
            int selectedIndex = dtgvListNXB.CurrentRow.Index;

            NHAXUATBAN nxb = NHAXUATBANDAO.Instance.GetNXBByID(maNXB);

            if (nxb != null)
            {
                if (NHAXUATBANDAO.Instance.UpdateNXBByID(maNXB, tenNXB))
                {
                    MessageBox.Show("Cập nhật nhà xuất bản thành công!", "Thông báo");
                    dtgvListNXB.Rows[selectedIndex].Cells["Column2"].Value = txbTenNXB.Text;
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà xuất bản thất bại!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã nhà xuất bản!", "Thông báo");
            }
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            string maNXB = txbMaNXB.Text;
            string tenNXB = txbTenNXB.Text;

            NHAXUATBAN nxb = NHAXUATBANDAO.Instance.GetNXBByID(maNXB);

            if (nxb == null)
            {
                if (NHAXUATBANDAO.Instance.InsertNXB(maNXB, tenNXB))
                {
                    MessageBox.Show("Thêm nhà xuất bản thành công!", "Thông báo");
                    LoadInfo();
                }
                else
                {
                    MessageBox.Show("Thêm nhà xuất bản thất bại!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mã nhà xuất bản đã tồn tại!", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
