using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class CTBH
    {
        public CTBH(string maBH, string maSach, int soLuong, SqlMoney donGia, SqlMoney thanhTien)
        {
            this.MaBH = maBH;
            this.MaSach = maSach;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }

        public CTBH(DataRow row)
        {
            this.MaBH = row["MABH"].ToString();
            this.MaSach = row["MASACH"].ToString();
            this.SoLuong = (int)row["SOLUONG"];
            this.DonGia = (SqlMoney)row["DONGIA"];
            this.ThanhTien = (SqlMoney)row["THANHTIEN"];
        }

        private string maBH;

        private string maSach;

        private int soLuong;

        private SqlMoney donGia;

        private SqlMoney thanhTien;
        public string MaBH { get => maBH; set => maBH = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public SqlMoney DonGia { get => donGia; set => donGia = value; }
        public SqlMoney ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
