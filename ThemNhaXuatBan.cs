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

            if (dtgvListNXB.Rows.Count > 1)
            {
                DataGridViewRow selectedRow = dtgvListNXB.Rows[0];

                txbMaNXB.Text = selectedRow.Cells["Column1"].Value.ToString().Trim();
                txbTenNXB.Text = selectedRow.Cells["Column2"].Value.ToString().Trim();
                btnAction.Text = "CẬP NHẬT";
            }
            else
            {
                Clear();
            }
        }

        void Clear()
        {
            string maNXB = NHAXUATBANDAO.Instance.GetIDOfNXB();
            int lastNumber = int.Parse(maNXB.Substring(3).Trim());
            int nextNumber = lastNumber + 1;
            string nextID = string.Format("NXB{0:D3}", nextNumber);

            txbMaNXB.Text = nextID.ToString();
            txbTenNXB.Text = "";
            btnAction.Text = "THÊM";
            btnXoaNXB.Enabled = false;
            dtgvListNXB.ClearSelection();
        }

        #endregion

        #region events
        private void readOnlyTxb_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void dtgvListNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dtgvListNXB.Rows.Count - 1)
            {
                Clear();
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvListNXB.Rows[e.RowIndex];

                txbMaNXB.Text = selectedRow.Cells["Column1"].Value.ToString().Trim();
                txbTenNXB.Text = selectedRow.Cells["Column2"].Value.ToString().Trim();
                btnAction.Text = "CẬP NHẬT";
            }
            else
            {
                dtgvListNXB.ClearSelection();
            }
            btnXoaNXB.Enabled = true;
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            string maNXB = txbMaNXB.Text;

            NHAXUATBAN loaisach = NHAXUATBANDAO.Instance.GetNXBByID(maNXB);

            if (loaisach != null)
            {
                SACHDAO.Instance.SoftDeleteByMaNXB(maNXB);
                if (MessageBox.Show("Bạn có chắc muốn xóa nhà xuất bản này không?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (NHAXUATBANDAO.Instance.DeleteNXBByID(maNXB))
                    {
                        MessageBox.Show("Xoá nhà xuất bản thành công!", "Thông báo");
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
            Clear();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (txbTenNXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản!", "Thông báo");
                return;
            }
            string maNXB = txbMaNXB.Text;
            string tenNXB = txbTenNXB.Text;
            int selectedIndex = 0;
            if (dtgvListNXB.CurrentRow != null)
                selectedIndex = dtgvListNXB.CurrentRow.Index;

            NHAXUATBAN nxb = NHAXUATBANDAO.Instance.GetNXBByID(maNXB);
            if (btnAction.Text == "THÊM")
            {
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
            else
            {
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
        }

        #endregion

        private void btnAction_TextChanged(object sender, EventArgs e)
        {
            if (btnAction.Text == "CẬP NHẬT")
                btnXoaNXB.Enabled = true;
            else
                btnXoaNXB.Enabled = false;
        }
    }
}
