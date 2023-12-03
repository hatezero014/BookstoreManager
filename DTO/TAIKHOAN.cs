using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class TAIKHOAN
    {
        public TAIKHOAN(string maNV, string taiKhoan, string matKhau, int loai)
        {
            this.MaNV = maNV;
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
            this.Loai = loai;
        }

        public TAIKHOAN(DataRow row)
        {
            this.MaNV = row["MANV"].ToString();
            this.TaiKhoan = row["TAIKHOAN"].ToString();
            this.MatKhau = row["MATKHAU"].ToString();
            this.Loai = (int)row["LOAI"];
        }

        private string matKhau;

        private string taiKhoan;

        private string maNV;

        private int loai;

        public int Loai { get => loai; set => loai = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
    }
}
