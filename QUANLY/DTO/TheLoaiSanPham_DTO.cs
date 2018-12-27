using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class TheLoaiSanPham_DTO
    {
        private string maTL;
        private string tenTL;
        private string ghiChu;

        public string MaTL { get => maTL; set => maTL = value; }
        public string TenTL { get => tenTL; set => tenTL = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
