using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class CTNS
    {
        public CTNS(string maNS, string maSach, int soLuong, SqlMoney giaNhap, SqlMoney thanhTien)
        {
            this.MaNS = maNS;
            this.MaSach = maSach;
            this.SoLuong = soLuong;
            this.GiaNhap = giaNhap;
            this.ThanhTien = thanhTien;
        }

        public CTNS(DataRow row)
        {
            this.MaNS = row["MANS"].ToString();
            this.MaSach = row["MASACH"].ToString();
            this.SoLuong = (int)row["SOLUONG"];
            this.GiaNhap = (SqlMoney)row["GIANHAP"];
            this.ThanhTien = (SqlMoney)row["THANHTIEN"];
        }

        private string maNS;

        private string maSach;

        private int soLuong;

        private SqlMoney giaNhap;

        private SqlMoney thanhTien;

        public string MaNS { get => maNS; set => maNS = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public SqlMoney GiaNhap { get => giaNhap; set => giaNhap = value; }
        public SqlMoney ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
