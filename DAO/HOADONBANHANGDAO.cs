using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class HOADONBANHANGDAO
    {
        private static HOADONBANHANGDAO instance;

        public static HOADONBANHANGDAO Instance
        {
            get { if (instance == null) instance = new HOADONBANHANGDAO(); return instance; }
            private set { instance = value; }
        }

        private HOADONBANHANGDAO() { }

        public HOADONBANHANG GetHoaDonBHByID(string maBH)
        {
            string query = $"SELECT * FROM HOADONBANHANG WHERE MABH = '{maBH}'";

            HOADONBANHANG result = null;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                result = new HOADONBANHANG(data.Rows[0]);
            }

            return result;
        }

        public string GetIDOfBH()
        {
            string query = "SELECT TOP 1 * FROM HOADONBANHANG ORDER BY MABH DESC";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            string result = "BH001";

            if (data != null)
            {
                HOADONBANHANG banhang = new HOADONBANHANG(data.Rows[0]);

                result = banhang.MaBH;
            }

            return result;
        }

        public bool InsertBH(string maBH, string maKH, string maNV, string ngayBan, decimal tongTien)
        {
            string query = $"INSERT INTO HOADONBANHANG " +
                            $"VALUES ('{maBH}', '{maKH}', '{maNV}', '{ngayBan}', {tongTien})";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public List<HOADONBANHANG> GetListBanHang()
        {
            string query = $"SELECT * FROM HOADONBANHANG";

            List<HOADONBANHANG> result = new List<HOADONBANHANG>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                result.Add(new HOADONBANHANG(row));
            }

            return result;
        }
    }
}
