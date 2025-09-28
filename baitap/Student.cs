using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class Student
    {
        public string MSSV { get; set; }
        public string HoTenLot { get; set; }
        public string Ten {  get; set; }
        public string Lop { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public List<string> MonHoc { get; set; }

        public Student()
        {
            MonHoc = new List<string>();
        }

        public Student(string ms, string hoTenLot, string ten, string lop, DateTime ns, string cccd, string sdt,string diaChi, bool gioitinh, List<string> mh)
        {
            this.MSSV = ms;
            this.HoTenLot = hoTenLot;
            this.Ten = ten;
            this.Lop = lop;
            this.NgaySinh = ns;
            this.CCCD = cccd;
            this.SDT = sdt;
            this.DiaChi = diaChi;
            this.GioiTinh = gioitinh;
            this.MonHoc = mh;
        }

        public override string ToString()
        {
            return $"{MSSV}|{HoTenLot}|{Ten}|{Lop}|{NgaySinh:dd/MM/yyyy}|{CCCD}|{SDT}|{DiaChi}|{(GioiTinh ? "1" : "0")}|{string.Join("; ", MonHoc)}";
        }


    }
}
