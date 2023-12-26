using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class SACHGIAMGIADAO
    {
        private static SACHGIAMGIADAO instance;

        public static SACHGIAMGIADAO Instance
        {
            get { if (instance == null) instance = new SACHGIAMGIADAO(); return instance; }
            private set { instance = value; }
        }

        private SACHGIAMGIADAO() { }

        public List<SACHGIAMGIA> GetListSGG()
        {
            List<SACHGIAMGIA> result = new List<SACHGIAMGIA>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM SACHGIAMGIA");

            foreach (DataRow row in data.Rows)
            {
                result.Add(new SACHGIAMGIA(row));
            }

            return result;
        }

        public SACHGIAMGIA GetSGGByID(string maSach)
        {
            string query = $"SELECT * FROM SACHGIAMGIA WHERE MASACH = '{maSach}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            SACHGIAMGIA result = null;

            if (data.Rows.Count > 0)
            {
                result = new SACHGIAMGIA(data.Rows[0]);
            }

            return result;
        }

        public bool DeleteSGGByID(string maSach)
        {
            string query = $"DELETE SACHGIAMGIA WHERE MASACH = '{maSach}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool InsertSGG(string maSach, string tenSach, decimal giaTruocGiam, decimal giaGiam, string giamDen)
        {
            string query = $"INSERT INTO SACHGIAMGIA VALUES ('{maSach}', N'{tenSach}', {giaTruocGiam}, {giaGiam}, '{giamDen}')";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool UpdateSGGByID(string maSach, string tenSach, decimal giaTruocGiam, decimal giaGiam, string giamDen)
        {
            string query = $"UPDATE SACHGIAMGIA SET TENSACH = N'{tenSach}', GIATRUOCGIAM = {giaTruocGiam}, GIAGIAM = {giaGiam}, GIAMDEN = '{giamDen}'  " +
                            $"WHERE MASACH = '{maSach}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }
    }
}
