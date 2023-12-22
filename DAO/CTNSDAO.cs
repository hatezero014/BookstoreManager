using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class CTNSDAO
    {
        private static CTNSDAO instance;

        public static CTNSDAO Instance
        {
            get { if (instance == null) instance = new CTNSDAO(); return instance; }
            private set { instance = value; }
        }

        private CTNSDAO() { }

        public List<CTNS> GetListCTNSByID(string maNS)
        {
            string query = $"SELECT * FROM CTNS WHERE MANS = '{maNS}'";

            List<CTNS> result = new List<CTNS>();

            DataTable data = DataProvider.Intstance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                result.Add(new CTNS(row));
            }

            return result;
        }

        public CTNS GetListCTNSByIDNSIDSach(string maNS, string maSach)
        {
            string query = $"SELECT * FROM CTNS WHERE MANS = '{maNS}' AND MASACH = '{maSach}'";

            CTNS result = null;

            DataTable data = DataProvider.Intstance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                result = new CTNS(data.Rows[0]);
            }

            return result;
        }

        public bool DeleteCTNSByID(string maNS, string maSach)
        {
            string query = $"DELETE CTNS WHERE MANS = '{maNS}' AND MASACH = '{maSach}'";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }

        public bool InsertCTNS(string maNS, string maSach, decimal giaNhap, int soLuong, decimal tongTien)
        {
            string query = $"INSERT INTO CTNS " +
                            $"VALUES ('{maNS}', '{maSach}', {giaNhap}, {soLuong}, {tongTien})";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }
    }
}
