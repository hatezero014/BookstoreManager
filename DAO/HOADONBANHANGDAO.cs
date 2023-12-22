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

            DataTable data = DataProvider.Intstance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                result = new HOADONBANHANG(data.Rows[0]);
            }

            return result;
        }
    }
}
