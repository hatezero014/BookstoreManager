using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class HOADONNHAPSACH
    {
        public HOADONNHAPSACH(string maNS, string maNCC, string maNV, DateTime ngayNhap, decimal tongTien)
        {
            this.MaNS = maNS;
            this.MaNCC = maNCC;
            this.MaNV = maNV;
            this.NgayNhap = ngayNhap;
            this.TongTien = tongTien;
        }

        public HOADONNHAPSACH(DataRow row)
        {
            this.MaNS = row["MANS"].ToString();
            this.MaNCC = row["MANCC"].ToString();
            this.MaNV = row["MANV"].ToString();
            this.NgayNhap = (DateTime)row["NGAYNHAP"];
            this.TongTien = (decimal)row["TONGTIEN"];
        }

        private string maNS;

        private string maNCC;

        private string maNV;

        private DateTime ngayNhap;

        private decimal tongTien;

        public string MaNS { get => maNS; set => maNS = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
    }
}
