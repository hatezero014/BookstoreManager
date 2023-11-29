using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class TAIKHOANDAO
    {
        private static TAIKHOANDAO instance;

        public static TAIKHOANDAO Instance
        {
            get { if (instance == null) instance = new TAIKHOANDAO(); return instance; }
            private set { instance = value; }
        }

        private TAIKHOANDAO() { }
        public int Login(string username, string password)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE @TAIKHOAN = TAIKHOAN AND @MATKHAU = MATKHAU";

            DataTable data = DataProvider.Intstance.ExcuteQuery(query, new object[] { username, password });

            if (data.Rows.Count > 0)
            {
                TAIKHOAN taiKhoan = new TAIKHOAN(data.Rows[0]);
                return taiKhoan.Loai;
            }
            return -1;
        }
    }
}
