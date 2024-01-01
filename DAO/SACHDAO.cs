using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class SACHDAO
    {
        private static SACHDAO instance;

        public static SACHDAO Instance
        {
            get { if (instance == null) instance = new SACHDAO(); return instance; }
            private set { instance = value; }
        }

        private SACHDAO() { }

        public bool UpdatePriceBookById(string maSach, decimal giaSach)
        {
            string query = $"UPDATE SACH SET GIASACH = {giaSach} WHERE MASACH = '{maSach}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool SoftDeleteByMaLS(string maLS)
        {
            string query = $"UPDATE SACH SET SOLUONG = -1, MALS = NULL WHERE MALS = '{maLS}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }
        public bool SoftDeleteByMaNXB(string maNXB)
        {
            string query = $"UPDATE SACH SET SOLUONG = -1, MANXB = NULL WHERE MANXB = '{maNXB}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }
        public bool InsertBook(string maSach, string tenSach, string tacGia, short? namXB, string moTa, string nhaXB, string loaiSach)
        {
            string query = "USP_InsertBook @MASACH , @TENSACH , @TACGIA , @NAMXB , @MOTA , @TENNXB , @LOAISACH";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { maSach, tenSach, tacGia, namXB, moTa, nhaXB, loaiSach }) > 0;
        }

        public SACH GetBookByID(string maSach)
        {
            string query = $"SELECT * FROM SACH WHERE MASACH = '{maSach}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            SACH result = null;

            if (data.Rows.Count > 0)
            {
                result = new SACH(data.Rows[0]);
            }

            return result;
        }

        public string GetIdOfBook()
        {
            string query = "SELECT TOP 1 * FROM SACH ORDER BY MASACH DESC";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            string result = "MS00001";

            if (data != null)
            {
                SACH sach = new SACH(data.Rows[0]);

                result = sach.MaSach;
            }

            return result;
        }

        public bool DeleteBookByID(string iD)
        {
            string query = $"DELETE SACH WHERE MASACH = '{iD}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool UpdateBookByID(string iD, string tenSach, string tacGia, decimal? giaSach, short? namXB, string moTa, int soLuong, string tenNXB, string loaiSach, decimal? giaGoc)
        {
            string query = $"USP_UpdateBook @MASACH , @TENSACH , @TACGIA , @GIASACH , @NAMXB , @MOTA , @SOLUONG , @TENNXB , @MALS , @GIAGOC";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { iD, tenSach, tacGia, giaSach, namXB, moTa, soLuong, tenNXB, loaiSach, giaGoc }) > 0;
        }

        public SACH LoadBookByID(string maSach)
        {
            string query = $"SELECT * FROM SACH WHERE MASACH = '{maSach}'";

            SACH result = null;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                result = new SACH(data.Rows[0]);
            }

            return result;
        }

        public List<SACH> GetListSach()
        {
            string query = $"SELECT * FROM SACH";

            List<SACH> result = new List<SACH>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                result.Add(new SACH(row));
            }

            return result;
        }

        public List<SACH> GetListSachNotNull()
        {
            string query = $"SELECT * FROM SACH WHERE GIAGOC IS NOT NULL";

            List<SACH> result = new List<SACH>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                result.Add(new SACH(row));
            }

            return result;
        }

        public SACH GetBookByName(string tenSach)
        {
            SACH result = null;

            string query = $"SELECT * FROM SACH WHERE TENSACH = N'{tenSach}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                result = new SACH(data.Rows[0]);
            }

            return result;
        }
    }
}
