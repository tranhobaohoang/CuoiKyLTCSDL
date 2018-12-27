using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class GOICOMBO_DTO
    {
        private string maPhieu;
        private string maSP;
        private string maNV;
        private DateTime ngayHetHan;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
    }
}
