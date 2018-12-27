using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.DTO
{
    class KhachHang_DTO
    {
        private string _MaKH;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private string _HoTenKH;

        public string HoTenKH
        {
            get { return _HoTenKH; }
            set { _HoTenKH = value; }
        }
        private string _EmailKH;

        public string EmailKH
        {
            get { return _EmailKH; }
            set { _EmailKH = value; }
        }
        private int _GioiTinhKH;

        public int GioiTinhKH
        {
            get { return _GioiTinhKH; }
            set { _GioiTinhKH = value; }
        }
        private DateTime _NgaySinhKH;

        public DateTime NgaySinhKH
        {
            get { return _NgaySinhKH; }
            set { _NgaySinhKH = value; }
        }
        private string _DiaChiKH;

        public string DiaChiKH
        {
            get { return _DiaChiKH; }
            set { _DiaChiKH = value; }
        }
        private string _DienThoaiKH;

        public string DienThoaiKH
        {
            get { return _DienThoaiKH; }
            set { _DienThoaiKH = value; }
        }
        private DateTime _NgayLamThe;

        public DateTime NgayLamThe
        {
            get { return _NgayLamThe; }
            set { _NgayLamThe = value; }
        }
        private DateTime _NgayHetHan;

        public DateTime NgayHetHan
        {
            get { return _NgayHetHan; }
            set { _NgayHetHan = value; }
        }
        private int _HoatDong;

        public int HoatDong
        {
            get { return _HoatDong; }
            set { _HoatDong = value; }
        }
    }
}
