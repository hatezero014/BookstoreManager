using BookstoreManager.DAO;
using BookstoreManager.DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManager
{
    public partial class ThemGiamGia : MaterialForm
    {
        public ThemGiamGia()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            LoadSach();
            LoadInfo();
        }

        #region methods

        void LoadInfo()
        {
            dtgvList.Rows.Clear();
            List<SACHGIAMGIA> listSACHGG = SACHGIAMGIADAO.Instance.GetListSGG();

            foreach (SACHGIAMGIA sachGG in listSACHGG)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dtgvList, sachGG.MaSach, sachGG.TenSach, FormatMoney(decimal.Parse(sachGG.GiaTruocGiam.ToString())), FormatMoney(decimal.Parse(sachGG.GiaGiam.ToString())), ((DateTime)sachGG.GiamDen).ToString("dd-MM-yyyy"));

                dtgvList.Rows.Add(row);
            }

            if (dtgvList.Rows.Count > 1)
            {
                DataGridViewRow selectedRow = dtgvList.Rows[0];

                txbMaSach.Text = selectedRow.Cells["Column1"].Value.ToString().Trim();
                cbListSach.Text = selectedRow.Cells["Column2"].Value.ToString().Trim();
                cbListSach.Refresh();
                txbGiaTruocGiam.Text = selectedRow.Cells["Column3"].Value.ToString().Trim();
                txbGiaTruocGiam.Text = FormatMoney(decimal.Parse(txbGiaTruocGiam.Text));
                txbGiaGiam.Text = selectedRow.Cells["Column4"].Value.ToString().Trim();
                txbGiaGiam.Text = FormatMoney(decimal.Parse(txbGiaGiam.Text));
                txbGiamDen.Text = selectedRow.Cells["Column5"].Value.ToString();

                btnAction.Text = "CẬP NHẬT";
            }
            else
            {
                Clear();
            }
        }

        void LoadSach()
        {
            List<SACH> list = SACHDAO.Instance.GetListSach();

            cbListSach.DataSource = list;
            cbListSach.DisplayMember = "TenSach";
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

        void Clear()
        {
            txbMaSach.Text = "";
            cbListSach.SelectedIndex = -1;
            cbListSach.Refresh();
            dtgvList.ClearSelection();
            btnAction.Text = "THÊM";
            txbGiamDen.Text = "";
            txbGiaGiam.Text = "";
            txbGiaTruocGiam.Text = "";
            cbListSach.Enabled = true;
            txbGiaTruocGiam.Enabled = true;
            btnXoa.Enabled = false;
        }

        #endregion

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dtgvList.Rows.Count - 1)
            {
                Clear();
                return;
            }
            if (e.RowIndex >= 0)
            {

                cbListSach.Enabled = false;
                txbGiaTruocGiam.Enabled = false;
                DataGridViewRow selectedRow = dtgvList.Rows[e.RowIndex];

                string maSach = selectedRow.Cells["Column1"].Value.ToString().Trim();
                string tenSach = selectedRow.Cells["Column2"].Value.ToString().Trim();
                string giaTruocGiam = selectedRow.Cells["Column3"].Value.ToString().Trim();
                string giaGiam = selectedRow.Cells["Column4"].Value.ToString().Trim();
                string giamDen = selectedRow.Cells["Column5"].Value.ToString();

                txbMaSach.Text = maSach;
                cbListSach.Text = tenSach;
                cbListSach.Refresh();
                txbGiamDen.Text = giamDen;
                txbGiaGiam.Text = FormatMoney(decimal.Parse(giaGiam)).ToString();
                txbGiaTruocGiam.Text = FormatMoney(decimal.Parse(giaTruocGiam)).ToString();
            }
            else
            {
                dtgvList.ClearSelection();
            }
            btnAction.Text = "CẬP NHẬT";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSach = txbMaSach.Text;

            SACHGIAMGIA sachGG = SACHGIAMGIADAO.Instance.GetSGGByID(maSach);

            if (sachGG != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa sách giảm giá này không?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (SACHGIAMGIADAO.Instance.DeleteSGGByID(maSach))
                    {
                        MessageBox.Show("Xoá sách giảm giá thành công!", "Thông báo");
                        LoadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Xoá sách giảm giá thất bại!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã sách giảm giá này!", "Thông báo");
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {

            string maSach = txbMaSach.Text;
            string tenSach = cbListSach.Text;
            if (txbGiaTruocGiam.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sách giảm giá!", "Thông báo!");
                return;
            }
            decimal giaTruocGiam = decimal.Parse(txbGiaTruocGiam.Text);
            if (txbGiaGiam.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá giảm của sách!", "Thông báo!");
                return;
            }
            decimal giaGiam = decimal.Parse(txbGiaGiam.Text);
            if (!DateTime.TryParseExact(txbGiamDen.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Ngày tháng không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                return;
            }
            DateTime parsedDateTime = DateTime.ParseExact(txbGiamDen.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string giamDen = parsedDateTime.ToString("yyyy-MM-dd");

            int selectedIndex = 0;
            if (dtgvList.CurrentRow != null)
                selectedIndex = dtgvList.CurrentRow.Index;

            SACHGIAMGIA sachGG = SACHGIAMGIADAO.Instance.GetSGGByID(maSach);

            if (btnAction.Text == "THÊM")
            {
                if (sachGG == null)
                {
                    if (SACHGIAMGIADAO.Instance.InsertSGG(maSach, tenSach, giaTruocGiam, giaGiam, giamDen))
                    {
                        MessageBox.Show("Thêm sách giảm giá thành công!", "Thông báo");
                        LoadInfo();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách giảm giá thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mã sách giảm giá đã tồn tại!", "Thông báo");
                }
            }
            else
            {
                if (sachGG != null)
                {
                    if (SACHGIAMGIADAO.Instance.UpdateSGGByID(maSach, tenSach, giaTruocGiam, giaGiam, giamDen))
                    {
                        MessageBox.Show("Cập nhật sách giảm giá thành công!", "Thông báo");
                        dtgvList.Rows[selectedIndex].Cells["Column2"].Value = cbListSach.Text;
                        dtgvList.Rows[selectedIndex].Cells["Column3"].Value = decimal.Parse(txbGiaTruocGiam.Text);
                        dtgvList.Rows[selectedIndex].Cells["Column4"].Value = decimal.Parse(txbGiaGiam.Text);
                        dtgvList.Rows[selectedIndex].Cells["Column5"].Value = txbGiamDen.Text;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sách giảm giá thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mã sách giảm giá đã tồn tại!", "Thông báo");
                }
            }
        }

        private void cbListSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenSach = cbListSach.Text;

            SACH sach = SACHDAO.Instance.GetBookByName(tenSach);

            if (sach != null)
            {
                txbMaSach.Text = sach.MaSach;
                txbGiaTruocGiam.Text = FormatMoney(decimal.Parse(sach.GiaSach.ToString()));
            }
        }

        private void txbGiaGiam_TextChanged(object sender, EventArgs e)
        {
            if (txbGiaGiam.Text != "")
            {
                txbGiaGiam.Text = txbGiaGiam.Text.Replace(",", "");
                txbGiaGiam.Text = FormatMoney(decimal.Parse(txbGiaGiam.Text));
            }
            txbGiaGiam.SelectionStart = txbGiaGiam.Text.Length;
        }

        private void txbGiaTruocGiam_TextChanged(object sender, EventArgs e)
        {
            if (txbGiaTruocGiam.Text != "")
            {
                txbGiaTruocGiam.Text = txbGiaTruocGiam.Text.Replace(",", "");
                txbGiaTruocGiam.Text = FormatMoney(decimal.Parse(txbGiaTruocGiam.Text));
            }
            txbGiaTruocGiam.SelectionStart = txbGiaTruocGiam.Text.Length;
        }

        private void btnAction_TextChanged(object sender, EventArgs e)
        {
            if (btnAction.Text == "CẬP NHẬT")
                btnXoa.Enabled = true;
            else
                btnXoa.Enabled = false;
        }

        private void txbGiamDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '-' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbGiaGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbGiaTruocGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
