using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class SACH
    {
        public SACH(string maSach, string tenSach, string tacGia, SqlMoney giaSach, int namXB, string moTa, int soLuong, string maNXB, string maLS)
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
        }

        public SACH(DataRow row)
        {
            this.MaSach = row["MASACH"].ToString();
            this.TenSach = row["TENSACH"].ToString();
            this.TacGia = row["TACGIA"].ToString();
            this.GiaSach = (SqlMoney)row["GIASACH"];
            this.NamXB = (int)row["NAMXB"];
            this.MoTa = row["MOTA"].ToString();
            this.SoLuong = (int)row["SOLUONG"];
            this.MaNXB = row["MANXB"].ToString();
            this.MaLS = row["MALS"].ToString();
        }

        private string maSach;

        private string tenSach;

        private string tacGia;

        private SqlMoney giaSach;

        private int namXB;

        private string moTa;

        private int soLuong;

        private string maNXB;

        private string maLS;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public SqlMoney GiaSach { get => giaSach; set => giaSach = value; }
        public int NamXB { get => namXB; set => namXB = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaNXB { get => maNXB; set => maNXB = value; }
        public string MaLS { get => maLS; set => maLS = value; }
    }
}
