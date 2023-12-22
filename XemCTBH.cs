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
    public partial class XemCTBH : MaterialForm
    {
        public XemCTBH(string maBH)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            LoadInfo(maBH);
        }

        #region methods

        string FormatMoney(decimal originalValue)
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

        void LoadInfo(string maBH)
        {
            HOADONBANHANG HDBH = HOADONBANHANGDAO.Instance.GetHoaDonBHByID(maBH);
            txbMaBH.Text = maBH;
            txbMaKH.Text = HDBH.MaKH;
            txbMaNV.Text = HDBH.MaNV;
            txbNgayTao.Text = HDBH.NgayBan.ToString("dd-MM-yyyy");
            lbThanhToan.Text = FormatMoney(HDBH.TongTien);

            List<CTBH> listCTBH = CTBHDAO.Instance.GetListCTBHByID(maBH);

            foreach (CTBH ctbh in listCTBH)
            {
                DataGridViewRow row = new DataGridViewRow();

                SACH sach = SACHDAO.Instance.GetBookByID(ctbh.MaSach);

                row.CreateCells(dtgvListCTBH, ctbh.MaSach, sach.TenSach, ctbh.SoLuong,
                                FormatMoney(ctbh.DonGia), FormatMoney(ctbh.ThanhTien));

                dtgvListCTBH.Rows.Add(row);
            }
        }

        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
