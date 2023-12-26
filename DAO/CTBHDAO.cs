using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class CTBHDAO
    {
        private static CTBHDAO instance;

        public static CTBHDAO Instance
        {
            get { if (instance == null) instance = new CTBHDAO(); return instance; }
            private set { instance = value; }
        }

        private CTBHDAO() { }

        public List<CTBH> GetListCTBHByID(string maBH)
        {
            string query = $"SELECT * FROM CTBH WHERE MABH = '{maBH}'";

            List<CTBH> result = new List<CTBH>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                result.Add(new CTBH(row));
            }

            return result;
        }

        public bool InsertCTBH(string maBH, string maSach, decimal giaNhap, int soLuong, decimal tongTien)
        {
            string query = $"INSERT INTO CTBH " +
                            $"VALUES ('{maBH}', '{maSach}', {giaNhap}, {soLuong}, {tongTien})";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }
    }
}
