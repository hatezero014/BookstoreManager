using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class NHACUNGCAPDAO
    {
        private static NHACUNGCAPDAO instance;

        public static NHACUNGCAPDAO Instance
        {
            get { if (instance == null) instance = new NHACUNGCAPDAO(); return instance; }
            private set { instance = value; }
        }

        private NHACUNGCAPDAO() { }
        public List<NHACUNGCAP> GetListNCC()
        {
            List<NHACUNGCAP> result = new List<NHACUNGCAP>();

            DataTable data = DataProvider.Intstance.ExcuteQuery("SELECT * FROM NHACUNGCAP");

            foreach (DataRow row in data.Rows)
            {
                result.Add(new NHACUNGCAP(row));
            }

            return result;
        }

        public NHACUNGCAP GetNCCByID(string id)
        {
            string query = $"SELECT * FROM NHACUNGCAP WHERE MANCC = '{id}'";

            DataTable data = DataProvider.Intstance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new NHACUNGCAP(data.Rows[0]);
            }

            return null;
        }

        public bool DeleteNCCByID(string maNCC)
        {
            string query = $"DELETE NHACUNGCAP WHERE MANCC = '{maNCC}'";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }

        public bool UpdateNCCByID(string maNCC, string tenNCC, string soDT, string diaChi)
        {
            string query = $"UPDATE NHACUNGCAP SET TENNCC = N'{tenNCC}', SODT = N'{soDT}', DIACHI = N'{diaChi}' WHERE MANCC = '{maNCC}'";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }

        public bool InsertNCC(string maNCC, string tenNCC, string soDT, string diaChi)
        {
            string query = $"INSERT INTO NHACUNGCAP VALUES ('{maNCC}', N'{tenNCC}', N'{diaChi}', '{soDT}')";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }

    }
}
