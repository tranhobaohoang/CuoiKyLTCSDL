using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class SanPham_DTO
    {
        private string _MaSP;

        public string MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }
        private string _TenSP;

        public string TenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }
        private string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        
        private int _Gia;

        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private DateTime _NgayNhapHang;

        public DateTime NgayNhapHang
        {
            get { return _NgayNhapHang; }
            set { _NgayNhapHang = value; }
        }
        private string _MaNPP;

        public string MaNPP
        {
            get { return _MaNPP; }
            set { _MaNPP = value; }
        }
        private string _MaDV;

        public string MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }
        private string _MaTL;

        public string MaTL
        {
            get { return _MaTL; }
            set { _MaTL = value; }
        }
        private int _TinhTrang;

        public int TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

        public NPP_DTO _NPP_DTO { get; set; }
        public DichVu_DTO _DichVu_DTO { get; set; }
        public TheLoaiSanPham_DTO _TheLoaiSanPham_DTO { get; set; }
    }
}
