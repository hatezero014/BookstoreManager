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
        public HOADONNHAPSACH(string maNS, string maNCC, string maNV, DateTime ngayNhap, SqlMoney tongTien)
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
            this.TongTien = (SqlMoney)row["TONGTIEN"];
        }

        private string maNS;

        private string maNCC;

        private string maNV;

        private DateTime ngayNhap;

        private SqlMoney tongTien;

        public string MaNS { get => maNS; set => maNS = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public SqlMoney TongTien { get => tongTien; set => tongTien = value; }
    }
}
