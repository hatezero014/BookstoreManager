using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class SACH
    {
        public SACH(string maSach, string tenSach, string tacGia, decimal? giaSach, short namXB, string moTa, int soLuong, string maNXB, string maLS, decimal? giaGoc)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.TacGia = tacGia;
            this.GiaSach = giaSach;
            this.NamXB = namXB;
            this.MoTa = moTa;
            this.SoLuong = soLuong;
            this.MaNXB = maNXB;
            this.MaLS = maLS;
            this.GiaGoc = giaGoc;
        }

        public SACH(DataRow row)
        {
            this.MaSach = row["MASACH"].ToString();
            this.TenSach = row["TENSACH"].ToString();
            this.TacGia = row["TACGIA"].ToString();
            if (row["GIASACH"].ToString() != "")
                this.GiaSach = (decimal)row["GIASACH"];
            else
            {
                this.GiaSach = null;
            }
            var namXB = row["NAMXB"];
            if (namXB.ToString() != "")
                this.NamXB = (short)row["NAMXB"];
            this.MoTa = row["MOTA"].ToString();
            this.SoLuong = (int)row["SOLUONG"];
            this.MaNXB = row["MANXB"].ToString();
            this.MaLS = row["MALS"].ToString();
            if (row["GIAGOC"].ToString() != "")
                this.GiaGoc = (decimal)row["GIAGOC"];
            else
            {
                this.GiaGoc = null;
            }
        }

        private string maSach;

        private string tenSach;

        private string tacGia;

        private decimal? giaSach;

        private short namXB;

        private string moTa;

        private int soLuong;

        private string maNXB;

        private string maLS;

        private decimal? giaGoc;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public decimal? GiaSach { get => giaSach; set => giaSach = value; }
        public short NamXB { get => namXB; set => namXB = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaNXB { get => maNXB; set => maNXB = value; }
        public string MaLS { get => maLS; set => maLS = value; }
        public decimal? GiaGoc { get => giaGoc; set => giaGoc = value; }
    }
}
