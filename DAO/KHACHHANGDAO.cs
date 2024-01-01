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
        public bool SortDelete(string maKH)
        {
            string query = $"UPDATE KHACHHANG SET HOTEN = N'Đã xóa', SODT = N'Đã xóa' WHERE MAKH = '{maKH}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }
        public bool DeleteCustomerByID(string iD)
        {
            string query = $"DELETE KHACHHANG WHERE MAKH = '{iD}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool UpdateCustomerByID(string maKH, string hoTen, string diaChi, string soDT)
        {
            string query = $"USP_UpdateCustomer @MAKH , @HOTEN , @DIACHI , @SODT";

            return DataProvider.Instance.ExcuteNonQuery(query, new object[] { maKH, hoTen, diaChi, soDT }) > 0;
        }

        public KHACHHANG LoadCustomerByID(string maKH)
        {
            string query = $"SELECT * FROM KHACHHANG WHERE MAKH = '{maKH}'";

            KHACHHANG result = null;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                result = new KHACHHANG(data.Rows[0]);
            }

            return result;
        }

        public bool InsertCustomer(string maKH, string hoTen, string diaChi, string soDT)
        {
            string query = $"INSERT INTO KHACHHANG VALUES ('{maKH}', N'{hoTen}', N'{diaChi}', '{soDT}')";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public string GetIDOfCustomer()
        {
            string query = "SELECT TOP 1 * FROM KHACHHANG ORDER BY MAKH DESC";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            string result = "KH0001";

            if (data != null)
            {
                KHACHHANG khachhang = new KHACHHANG(data.Rows[0]);

                result = khachhang.MaKH;
            }

            return result;
        }

        public KHACHHANG GetCustomerByID(string id)
        {
            string query = $"SELECT * FROM KHACHHANG WHERE MAKH = '{id}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new KHACHHANG(data.Rows[0]);
            }

            return null;
        }

        public KHACHHANG GetCustomerBySDT(string soDT)
        {
            string query = $"SELECT * FROM KHACHHANG WHERE SODT = '{soDT}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new KHACHHANG(data.Rows[0]);
            }

            return null;
        }

        public List<KHACHHANG> GetListCustomer()
        {
            string query = $"SELECT * FROM KHACHHANG";

            List<KHACHHANG> result = new List<KHACHHANG>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                result.Add(new KHACHHANG(row));
            }

            return result;
        }
    }
}
