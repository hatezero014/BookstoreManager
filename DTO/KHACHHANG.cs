using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class KHACHHANG
    {
        public KHACHHANG(string maKH, string hoTen, string diaChi, string soDT)
        {
            this.MaKH = maKH;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.SoDT = soDT;
        }

        public KHACHHANG(DataRow row)
        {
            this.MaKH = row["MAKH"].ToString();
            this.HoTen = row["HOTEN"].ToString();
            this.DiaChi = row["DIACHI"].ToString();
            this.SoDT = row["SODT"].ToString();
        }

        private string maKH;

        private string hoTen;

        private string diaChi;

        private string soDT;

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
