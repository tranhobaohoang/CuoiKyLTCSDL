using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class CTPhieuSDDVSP_DTO
    {
        private string maPhieu;
        private string maSP;
        private DateTime ngaySuDung;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public DateTime NgaySuDung { get => ngaySuDung; set => ngaySuDung = value; }
    }
}
