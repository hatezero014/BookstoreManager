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
    public partial class XemCTNS : MaterialForm
    {
        public XemCTNS(string maNS)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(0, 84, 195), Color.FromArgb(13, 0, 195), Color.FromArgb(0, 182, 195), Color.FromArgb(0, 155, 179), TextShade.WHITE);

            LoadInfo(maNS);
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

        void LoadInfo(string maNS)
        {
            HOADONNHAPSACH HDNS = HOADONNHAPSACHDAO.Instance.GetHoaDonNSByID(maNS);
            txbMaNS.Text = maNS;
            txbMaNCC.Text = HDNS.MaNCC;
            txbMaNV.Text = HDNS.MaNV;
            txbNgayTao.Text = HDNS.NgayNhap.ToString("dd-MM-yyyy");
            lbThanhToan.Text = FormatMoney(HDNS.TongTien);

            List<CTNS> listCTNS = CTNSDAO.Instance.GetListCTNSByID(maNS);

            foreach (CTNS ctns in listCTNS)
            {
                DataGridViewRow row = new DataGridViewRow();

                SACH sach = SACHDAO.Instance.GetBookByID(ctns.MaSach);

                row.CreateCells(dtgvListCTNS, ctns.MaSach, sach.TenSach, ctns.SoLuong,
                                FormatMoney(ctns.GiaNhap), FormatMoney(ctns.ThanhTien));

                dtgvListCTNS.Rows.Add(row);
            }
        }

        #endregion

        #region events
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
