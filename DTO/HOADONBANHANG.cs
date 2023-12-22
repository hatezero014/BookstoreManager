using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class HOADONBANHANG
    {
        public HOADONBANHANG(string maBH, string maKH, string maNV, DateTime ngayBan, decimal tongTien)
        {
            this.MaBH = maBH;
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.NgayBan = ngayBan;
            this.TongTien = tongTien;
        }

        public HOADONBANHANG(DataRow row)
        {
            this.MaBH = row["MABH"].ToString();
            this.MaKH = row["MAKH"].ToString();
            this.MaNV = row["MANV"].ToString();
            this.NgayBan = (DateTime)row["NGAYBAN"];
            this.TongTien = (decimal)row["TONGTIEN"];
        }

        private string maBH;

        private string maKH;

        private string maNV;

        private DateTime ngayBan;

        private decimal tongTien;

        public string MaBH { get => maBH; set => maBH = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
    }
}
