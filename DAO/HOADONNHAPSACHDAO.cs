using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class HOADONNHAPSACHDAO
    {
        private static HOADONNHAPSACHDAO instance;

        public static HOADONNHAPSACHDAO Instance
        {
            get { if (instance == null) instance = new HOADONNHAPSACHDAO(); return instance; }
            private set { instance = value; }
        }

        private HOADONNHAPSACHDAO() { }

        public HOADONNHAPSACH GetHoaDonNSByID(string maNS)
        {
            string query = $"SELECT * FROM HOADONNHAPSACH WHERE MANS = '{maNS}'";

            HOADONNHAPSACH result = null;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                result = new HOADONNHAPSACH(data.Rows[0]);
            }

            return result;
        }

        public string GetIDOfNS()
        {
            string query = "SELECT TOP 1 * FROM HOADONNHAPSACH ORDER BY MANS DESC";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            string result = "NS001";

            if (data != null)
            {
                HOADONNHAPSACH nhapsach = new HOADONNHAPSACH(data.Rows[0]);

                result = nhapsach.MaNS;
            }

            return result;
        }

        public bool InsertNS(string maNS, string maNCC, string maNV, string ngayNhap, decimal tongTien)
        {
            string query = $"INSERT INTO HOADONNHAPSACH " +
                            $"VALUES ('{maNS}', '{maNCC}', '{maNV}', '{ngayNhap}', {tongTien})";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public List<HOADONNHAPSACH> GetListNhapSach()
        {
            string query = $"SELECT * FROM HOADONNHAPSACH";

            List<HOADONNHAPSACH> result = new List<HOADONNHAPSACH>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                result.Add(new HOADONNHAPSACH(row));
            }

            return result;
        }
    }
}
