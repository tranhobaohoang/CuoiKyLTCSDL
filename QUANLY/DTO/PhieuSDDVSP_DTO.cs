using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLY.DTO
{
    class PhieuSDDVSP_DTO
    {
        private string maPhieu;
        private string maKH;
        private string maNV;
        private DateTime ngaySuDung;
       //public DateTime NgaySuDung { get; set; }
        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgaySuDung { get => ngaySuDung; set => ngaySuDung = value; }
    }
}
