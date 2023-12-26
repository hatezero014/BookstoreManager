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
    public partial class ThemNhaCungCap : MaterialForm
    {
        public ThemNhaCungCap()
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
            dtgvListNCC.Rows.Clear();
            List<NHACUNGCAP> listNCC = NHACUNGCAPDAO.Instance.GetListNCC();

            foreach (NHACUNGCAP ncc in listNCC)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dtgvListNCC, ncc.MaNCC, ncc.TenNCC, ncc.SoDT, ncc.DiaChi);

                dtgvListNCC.Rows.Add(row);
            }

            if (dtgvListNCC.Rows.Count > 1)
            {
                DataGridViewRow selectedRow = dtgvListNCC.Rows[0];

                txbMaNCC.Text = selectedRow.Cells["Column1"].Value.ToString().Trim();
                txbTenNCC.Text = selectedRow.Cells["Column2"].Value.ToString().Trim();
                txbSDT.Text = selectedRow.Cells["Column3"].Value.ToString().Trim();
                txbDiaChi.Text = selectedRow.Cells["Column4"].Value.ToString().Trim();
                btnActionNCC.Text = "CẬP NHẬT";
            }
            else
            {
                Clear();
            }
        }

        void Clear()
        {
            string maNCC = NHACUNGCAPDAO.Instance.GetIDOfNCC();
            int lastNumber = int.Parse(maNCC.Substring(3).Trim());
            int nextNumber = lastNumber + 1;
            string nextID = string.Format("NCC{0:D3}", nextNumber);

            txbMaNCC.Text = nextID.ToString();
            txbTenNCC.Text = "";
            txbSDT.Text = "";
            txbDiaChi.Text = "";
            dtgvListNCC.ClearSelection();
            btnActionNCC.Text = "THÊM";
            btnXoaNCC.Enabled = false;
        }

        #endregion

        private void btnHuyChonNCC_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtgvListNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActionNCC.Text = "CẬP NHẬT";
            if (e.RowIndex == dtgvListNCC.Rows.Count - 1)
            {
                Clear();
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvListNCC.Rows[e.RowIndex];

                string maNCC = selectedRow.Cells["Column1"].Value.ToString().Trim();
                string tenNCC = selectedRow.Cells["Column2"].Value.ToString().Trim();
                string soDT = selectedRow.Cells["Column3"].Value.ToString().Trim();
                string diaChi = selectedRow.Cells["Column4"].Value.ToString().Trim();

                txbMaNCC.Text = maNCC;
                txbDiaChi.Text = diaChi;
                txbTenNCC.Text = tenNCC;
                txbSDT.Text = soDT;
            }
            else
            {
                dtgvListNCC.ClearSelection();
            }
            btnXoaNCC.Enabled = true;
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            string maNCC = txbMaNCC.Text;

            NHACUNGCAP ncc = NHACUNGCAPDAO.Instance.GetNCCByID(maNCC);

            if (ncc != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này không?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (NHACUNGCAPDAO.Instance.DeleteNCCByID(maNCC))
                    {
                        MessageBox.Show("Xoá nhà cung cấp thành công!", "Thông báo");
                        LoadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Xoá nhà cung cấp thất bại!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã nhà cung cấp!", "Thông báo");
            }
        }

        private void btnActionNCC_Click(object sender, EventArgs e)
        {
            if (txbTenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Thông báo");
                return;
            }
            if (txbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhà cung cấp!", "Thông báo");
                return;
            }
            if (txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp!", "Thông báo");
                return;
            }
            string maNCC = txbMaNCC.Text;
            string tenNCC = txbTenNCC.Text;
            string soDT = txbSDT.Text;
            string diaChi = txbDiaChi.Text;
            int selectedIndex = 0;
            if (dtgvListNCC.CurrentRow != null)
                selectedIndex = dtgvListNCC.CurrentRow.Index;

            NHACUNGCAP ncc = NHACUNGCAPDAO.Instance.GetNCCByID(maNCC);

            if (btnActionNCC.Text == "THÊM")
            {
                if (ncc == null)
                {
                    if (NHACUNGCAPDAO.Instance.InsertNCC(maNCC, tenNCC, soDT, diaChi))
                    {
                        MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo");
                        LoadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà cung cấp thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại!", "Thông báo");
                }
            }
            else
            {
                if (ncc != null)
                {
                    if (NHACUNGCAPDAO.Instance.UpdateNCCByID(maNCC, tenNCC, soDT, diaChi))
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo");
                        dtgvListNCC.Rows[selectedIndex].Cells["Column2"].Value = txbTenNCC.Text;
                        dtgvListNCC.Rows[selectedIndex].Cells["Column3"].Value = txbSDT.Text;
                        dtgvListNCC.Rows[selectedIndex].Cells["Column4"].Value = txbDiaChi.Text;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã nhà cung cấp!", "Thông báo");
                }
            }
        }

        private void btnActionNCC_TextChanged(object sender, EventArgs e)
        {
            if (btnActionNCC.Text == "CẬP NHẬT")
                btnXoaNCC.Enabled = true;
            else
                btnXoaNCC.Enabled = false;
        }
    }
}
