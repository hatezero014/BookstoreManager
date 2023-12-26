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
    public partial class ThemTheLoaiSach : MaterialForm
    {
        public ThemTheLoaiSach()
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
            dtgvListLS.Rows.Clear();
            List<LOAISACH> listLOAISACH = LOAISACHDAO.Instance.GetListLoaiSach();

            foreach (LOAISACH loaisach in listLOAISACH)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dtgvListLS, loaisach.MaLS, loaisach.TenLS);

                dtgvListLS.Rows.Add(row);
            }

            DataGridViewRow selectedRow = dtgvListLS.Rows[0];

            if (dtgvListLS.Rows.Count > 1)
            {
                txbMaLS.Text = selectedRow.Cells["Column1"].Value.ToString().Trim();
                txbTenLS.Text = selectedRow.Cells["Column2"].Value.ToString().Trim();
                btnActionLS.Text = "CẬP NHẬT";
            }
            else
            {
                Clear();
            }
        }

        void Clear()
        {
            string maLS = LOAISACHDAO.Instance.GetIDOfLS();
            int lastNumber = int.Parse(maLS.Substring(2).Trim());
            int nextNumber = lastNumber + 1;
            string nextID = string.Format("LS{0:D3}", nextNumber);

            txbMaLS.Text = nextID.ToString();
            txbTenLS.Text = "";
            dtgvListLS.ClearSelection();
            btnActionLS.Text = "THÊM";
            btnXoaLS.Enabled = false;
        }

        #endregion

        #region events
        private void dtgvListLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dtgvListLS.Rows.Count - 1)
            {
                Clear();
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvListLS.Rows[e.RowIndex];

                string maLS = selectedRow.Cells["Column1"].Value.ToString().Trim();
                string tenLS = selectedRow.Cells["Column2"].Value.ToString().Trim();

                txbMaLS.Text = maLS;
                txbTenLS.Text = tenLS;
            }
            else
            {
                dtgvListLS.ClearSelection();
            }
            btnXoaLS.Enabled = true;
        }

        private void btnXoaLS_Click(object sender, EventArgs e)
        {
            string maLS = txbMaLS.Text;

            LOAISACH loaisach = LOAISACHDAO.Instance.GetLoaiSachByID(maLS);

            if (loaisach != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa loại sách này không?", "Warning") == DialogResult.OK)
                {
                    if (LOAISACHDAO.Instance.DeleteLSByID(maLS))
                    {
                        MessageBox.Show("Xoá loại sách thành công!", "Thông báo");
                        LoadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Xoá loại sách thất bại!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã loại sách!", "Thông báo");
            }
        }

        private void btnHuyChonLS_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void btnActionLS_Click(object sender, EventArgs e)
        {
            if (txbTenLS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại sách!", "Thông báo!");
                return;
            }
            string maLS = txbMaLS.Text;
            string tenLS = txbTenLS.Text;
            int selectedIndex = 0;
            if (dtgvListLS.CurrentRow != null)
                selectedIndex = dtgvListLS.CurrentRow.Index;

            LOAISACH loaisach = LOAISACHDAO.Instance.GetLoaiSachByID(maLS);

            if (btnActionLS.Text == "THÊM")
            {
                if (loaisach == null)
                {
                    if (LOAISACHDAO.Instance.InsertLS(maLS, tenLS))
                    {
                        MessageBox.Show("Thêm loại sách thành công!", "Thông báo");
                        LoadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại sách thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mã loại sách đã tồn tại!", "Thông báo");
                }
            }
            else
            {
                if (loaisach != null)
                {
                    if (LOAISACHDAO.Instance.UpdateLSByID(maLS, tenLS))
                    {
                        MessageBox.Show("Cập nhật loại sách thành công!", "Thông báo");
                        dtgvListLS.Rows[selectedIndex].Cells["Column2"].Value = txbTenLS.Text;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại sách thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã loại sách!", "Thông báo");
                }
            }
        }
        #endregion

        private void btnActionLS_TextChanged(object sender, EventArgs e)
        {
            if (btnActionLS.Text == "CẬP NHẬT")
                btnXoaLS.Enabled = true;
            else
                btnXoaLS.Enabled = false;
        }
    }
}
