using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLY.DTO
{
    class DichVu_DTO
    {
        private string maDV;
        private string tenDV;
        private string moTaDV;

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string MoTaDV { get => moTaDV; set => moTaDV = value; }
    }
}
