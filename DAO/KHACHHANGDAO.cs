using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class KHACHHANGDAO
    {
        private static KHACHHANGDAO instance;

        public static KHACHHANGDAO Instance
        {
            get { if (instance == null) instance = new KHACHHANGDAO(); return instance; }
            private set { instance = value; }
        }

        private KHACHHANGDAO() { }

        public bool DeleteCustomerByID(string iD)
        {
            string query = $"DELETE KHACHHANG WHERE MAKH = '{iD}'";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }

        public bool UpdateCustomerByID(string maKH, string hoTen, string diaChi, string soDT)
        {
            string query = $"USP_UpdateCustomer @MAKH , @HOTEN , @DIACHI , @SODT";

            return DataProvider.Intstance.ExcuteNonQuery(query, new object[] { maKH, hoTen, diaChi, soDT }) > 0;
        }

        public KHACHHANG LoadCustomerByID(string maKH)
        {
            string query = $"SELECT * FROM KHACHHANG WHERE MAKH = '{maKH}'";

            KHACHHANG result = null;

            DataTable data = DataProvider.Intstance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                result = new KHACHHANG(data.Rows[0]);
            }

            return result;
        }

        public bool InsertCustomer(string maKH, string hoTen, string soDT, string diaChi)
        {
            string query = $"INSERT INTO KHACHHANG VALUES ('{maKH}', N'{hoTen}', N'{diaChi}', '{soDT}')";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }

        public string GetIDOfCustomer()
        {
            string query = "SELECT TOP 1 * FROM KHACHHANG ORDER BY MAKH DESC";

            DataTable data = DataProvider.Intstance.ExcuteQuery(query);

            string result = "KH0001";

            if (data != null)
            {
                KHACHHANG khachhang = new KHACHHANG(data.Rows[0]);

                result = khachhang.MaKH;
            }

            return result;
        }
    }
}
