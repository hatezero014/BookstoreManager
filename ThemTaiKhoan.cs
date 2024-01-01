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
    public partial class ThemTaiKhoan : MaterialForm
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            LoadInfo();
        }

        #region methods

        void Clear()
        {
            txbMaNV.Text = "";
            txbMatKhau.Text = "";
            txbTaiKhoan.Text = "";
            dtgvListTK.ClearSelection();
        }

        void LoadInfo()
        {
            dtgvListTK.Rows.Clear();
            List<TAIKHOAN> listTK = TAIKHOANDAO.Instance.GetListTK();

            foreach (TAIKHOAN taiKhoan in listTK)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dtgvListTK, taiKhoan.MaNV, taiKhoan.TaiKhoan, taiKhoan.MatKhau);

                dtgvListTK.Rows.Add(row);
            }

            if (dtgvListTK.Rows.Count > 1)
            {
                DataGridViewRow selectedRow = dtgvListTK.Rows[0];

                txbMaNV.Text = selectedRow.Cells["Column1"].Value.ToString().Trim();
                txbTaiKhoan.Text = selectedRow.Cells["Column2"].Value.ToString().Trim();
                txbMatKhau.Text = selectedRow.Cells["Column3"].Value.ToString().Trim();
                // btnAction.Text = "CẬP NHẬT";
            }
            else
            {
                Clear();
            }
        }

        #endregion

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string taiKhoan = txbTaiKhoan.Text;
            string maNV = txbMaNV.Text;

            TAIKHOAN TK = TAIKHOANDAO.Instance.GetTKByTK(taiKhoan);

            if (TK != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (TAIKHOANDAO.Instance.DeleteTKByMaNV(maNV))
                    {
                        MessageBox.Show("Xoá tài khoản thành công!", "Thông báo");
                        LoadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Xoá tài khoản thất bại!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã nhân viên!", "Thông báo");
            }
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtgvListTK_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dtgvListTK.Rows.Count - 1)
            {
                Clear();
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvListTK.Rows[e.RowIndex];

                txbMaNV.Text = selectedRow.Cells["Column1"].Value.ToString().Trim();
                txbTaiKhoan.Text = selectedRow.Cells["Column2"].Value.ToString().Trim();
                txbMatKhau.Text = selectedRow.Cells["Column3"].Value.ToString().Trim();
                // btnAction.Text = "CẬP NHẬT";
            }
            else
            {
                dtgvListTK.ClearSelection();
            }
            btnXoa.Enabled = true;
            btnDatLaiMK.Enabled = true;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (txbMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Thông báo");
                return;
            }
            if (txbTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo");
                return;
            }
            if (txbMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                return;
            }
            string maNV = txbMaNV.Text;
            string taiKhoan = txbTaiKhoan.Text;
            string matKhau = txbMatKhau.Text;
            int selectedIndex = 0;
            if (dtgvListTK.CurrentRow != null)
                selectedIndex = dtgvListTK.CurrentRow.Index;

            TAIKHOAN TK = TAIKHOANDAO.Instance.GetTKByTK(taiKhoan);
            /*
            if (btnAction.Text == "THÊM")
            {
                if (TK == null)
                {
                    if (TAIKHOANDAO.Instance.InsertTK(maNV, taiKhoan, matKhau))
                    {
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
                        LoadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo");
                }
            }
            else
            {
            */
            if (TK != null)
            {
                if (TAIKHOANDAO.Instance.UpdateTKByID(taiKhoan, matKhau))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo");
                    dtgvListTK.Rows[selectedIndex].Cells["Column3"].Value = txbMatKhau.Text;
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo");
            }
        }
    }

    /* private void btnAction_TextChanged(object sender, EventArgs e)
    {
        if (btnAction.Text == "CẬP NHẬT")
        {
            btnXoa.Enabled = true;
            btnDatLaiMK.Enabled = true;
        }
        else
            btnXoa.Enabled = false;
    } */

    /* private void btnDatLaiMK_Click(object sender, EventArgs e)
    {
        if (TAIKHOANDAO.Instance.UpdateTKByID(txbTaiKhoan.Text, "1"))
        {
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
        }
        else
        {
            MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo");
        }
    } */
}
