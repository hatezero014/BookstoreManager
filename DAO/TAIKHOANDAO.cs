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

        public bool UpdateTKByID(string taiKhoan, string matKhau)
        {
            string query = $"UPDATE TAIKHOAN SET MATKHAU = N'{matKhau}' WHERE TAIKHOAN = '{taiKhoan}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool InsertTK(string maNV, string taiKhoan, string matKhau)
        {
            string query = $"INSERT INTO TAIKHOAN VALUES ('{maNV}', N'{taiKhoan}', N'{matKhau}', 1)";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public List<TAIKHOAN> GetListTK()
        {
            List<TAIKHOAN> result = new List<TAIKHOAN>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM TAIKHOAN");

            foreach (DataRow row in data.Rows)
            {
                result.Add(new TAIKHOAN(row));
            }

            return result;
        }

        public int Login(string username, string password)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE @TAIKHOAN = TAIKHOAN AND @MATKHAU = MATKHAU";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { username, password });

            if (data.Rows.Count > 0)
            {
                TAIKHOAN taiKhoan = new TAIKHOAN(data.Rows[0]);
                return taiKhoan.Loai;
            }
            return -1;
        }

        public TAIKHOAN GetMaNVByTK(string username)
        {
            string query = $"SELECT * FROM TAIKHOAN WHERE TAIKHOAN = '{username}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new TAIKHOAN(data.Rows[0]);
            }
            return null;
        }

        public TAIKHOAN GetTKByTK(string taiKhoan)
        {
            string query = $"SELECT * FROM TAIKHOAN WHERE TAIKHOAN = '{taiKhoan}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new TAIKHOAN(data.Rows[0]);
            }
            return null;
        }

        public TAIKHOAN GetTKByMaNV(string maNV)
        {
            string query = $"SELECT * FROM TAIKHOAN WHERE MANV = '{maNV}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return new TAIKHOAN(data.Rows[0]);
            }
            return null;
        }

        public bool DeleteTKByMaNV(string maNV)
        {
            string query = $"DELETE TAIKHOAN WHERE MANV = '{maNV}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }
    }
}
