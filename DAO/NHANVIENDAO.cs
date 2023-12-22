using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class NHANVIENDAO
    {
        private static NHANVIENDAO instance;

        public static NHANVIENDAO Instance
        {
            get { if (instance == null) instance = new NHANVIENDAO(); return instance; }
            private set { instance = value; }
        }

        private NHANVIENDAO() { }

        public bool DeleteStaffByID(string iD)
        {
            string query = $"DELETE NHANVIEN WHERE MANV = '{iD}'";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }

        public bool UpdateStaffByID(string maNV, string tenNV, string diaChi, DateTime ngaySinh, string email, string soDT, string cCCD)
        {
            string query = $"USP_UpdateStaff @MANV , @HOTEN , @DIACHI , @SODT , @EMAIL , @NGAYSINH , @CCCD";

            return DataProvider.Intstance.ExcuteNonQuery(query, new object[] { maNV, tenNV, diaChi, soDT, email, ngaySinh, cCCD }) > 0;
        }

        public NHANVIEN LoadStaffByID(string maNV)
        {
            string query = $"SELECT * FROM NHANVIEN WHERE MANV = '{maNV}'";

            NHANVIEN result = null;

            DataTable data = DataProvider.Intstance.ExcuteQuery(query);

            if (data.Rows.Count > 0)
            {
                result = new NHANVIEN(data.Rows[0]);
            }

            return result;
        }

        public string GetIDOfStaff()
        {
            string query = "SELECT TOP 1 * FROM NHANVIEN ORDER BY MANV DESC";

            DataTable data = DataProvider.Intstance.ExcuteQuery(query);

            string result = "NV001";

            if (data != null)
            {
                NHANVIEN nhanvien = new NHANVIEN(data.Rows[0]);

                result = nhanvien.MaNV;
            }

            return result;
        }

        public bool InsertStaff(string maNV, string hoTen, string soDT, string email, string diaChi, string ngaySinh, string cCCD)
        {
            string query = $"INSERT INTO NHANVIEN VALUES ('{maNV}', N'{hoTen}', N'{diaChi}', '{soDT}', '{email}', '{ngaySinh}', '{cCCD}')";

            return DataProvider.Intstance.ExcuteNonQuery(query) > 0;
        }
    }
}
