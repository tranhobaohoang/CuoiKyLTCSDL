using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class NPP_DTO
    {
        private string _MaNPP;

        public string MaNPP
        {
            get { return _MaNPP; }
            set { _MaNPP = value; }
        }
        private string _TenNPP;

        public string TenNPP
        {
            get { return _TenNPP; }
            set { _TenNPP = value; }
        }
        private string _DiaChiNPP;

        public string DiaChiNPP
        {
            get { return _DiaChiNPP; }
            set { _DiaChiNPP = value; }
        }
        private string _DienThoaiNPP;

        public string DienThoaiNPP
        {
            get { return _DienThoaiNPP; }
            set { _DienThoaiNPP = value; }
        }
        private string _Website;

        public string Website
        {
            get { return _Website; }
            set { _Website = value; }
        }
    }
}
