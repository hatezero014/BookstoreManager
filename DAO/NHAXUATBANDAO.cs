using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class NHAXUATBANDAO
    {
        private static NHAXUATBANDAO instance;

        public static NHAXUATBANDAO Instance
        {
            get { if (instance == null) instance = new NHAXUATBANDAO(); return instance; }
            private set { instance = value; }
        }

        private NHAXUATBANDAO() { }

        public List<NHAXUATBAN> GetListNXB()
        {
            List<NHAXUATBAN> result = new List<NHAXUATBAN>();

            DataTable data = DataProvider.Intstance.ExcuteQuery("SELECT * FROM NHAXUATBAN");

            foreach (DataRow row in data.Rows)
            {
                result.Add(new NHAXUATBAN(row));
            }

            return result;
        }

        public NHAXUATBAN GetNXBByID(string id)
        {
            string query = $"SELECT * FROM NHAXUATBAN WHERE MANXB = '{id}'";

            DataTable data = DataProvider.Intstance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new NHAXUATBAN(data.Rows[0]);
            }

            return null;
        }

        public bool DeleteNXBByID(string maNXB)
        {
            string query = $"DELETE NHAXUATBAN WHERE MANXB = '{maNXB}'";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }

        public bool UpdateNXBByID(string maNXB, string tenNXB)
        {
            string query = $"UPDATE NHAXUATBAN SET TENNXB = N'{tenNXB}' WHERE MANXB = '{maNXB}'";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }

        public bool InsertNXB(string maNXB, string tenNXB)
        {
            string query = $"INSERT INTO NHAXUATBAN VALUES ('{maNXB}', N'{tenNXB}')";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }
    }
}
