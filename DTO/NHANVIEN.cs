using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class NHANVIEN
    {
        public NHANVIEN(string maNV, string hoTen, string diaChi, string soDT, string email, DateTime ngaySinh, string cCCD)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.CCCD = cCCD;
            this.DiaChi = diaChi;
            this.SoDT = soDT;
            this.NgaySinh = ngaySinh;
            this.Email = email;
        }

        public NHANVIEN(DataRow row)
        {
            this.MaNV = row["MANV"].ToString();
            this.HoTen = row["HOTEN"].ToString();
            this.CCCD = row["CCCD"].ToString();
            this.DiaChi = row["DIACHI"].ToString();
            this.SoDT = row["SODT"].ToString();
            this.NgaySinh = (DateTime)row["NGAYSINH"];
            this.Email = row["EMAIL"].ToString();
        }

        private string maNV;

        private string hoTen;

        private string diaChi;

        private string soDT;

        private string email;

        private DateTime ngaySinh;

        private string cCCD;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
    }
}
