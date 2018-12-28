using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QUANLY.DAL;
using QUANLY.DTO;

namespace QUANLY.BLL
{
    public class KhachHang_BLL
    {
        ConnectDB connData = new ConnectDB();
        private static KhachHang_BLL instance;

        public static KhachHang_BLL Instance { get { if (instance == null) instance = new KhachHang_BLL(); return instance; } private set => instance = value; }

        public KhachHang_BLL() { }

        //Hàm lấy tất cả danh sách Khách hàng để hiển thị
        public DataTable LayDanhSachKhachHang()
        {
            string sql = "SELECT MaKH, HoTenKH, EmailKH, (CASE GioiTinhKH WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhKH, NgaySinhKH, DiaChiKH, DienThoaiKH, NgayLamThe, NgayHetHan, (CASE HoatDong WHEN 'true' THEN N'Đang Hoạt động' ELSE N'Đã Hết hạn' END) AS HoatDong FROM KHACHHANG";
            return connData.getdata(sql);
        }

        //Lấy Danh sách Khách hàng load sang Reports Khách hàng
        public DataTable LaydsKhachHang()
        {
            string sql = "SELECT MaKH, HoTenKH, EmailKH, GioiTinhKH, NgaySinhKH, DiaChiKH, DienThoaiKH, NgayLamThe, NgayHetHan, HoatDong FROM KHACHHANG ";
            return connData.getdata(sql);
        }

        // Lấy danh sách KH cho load sang ComboBox PM
        public DataTable LayDSKH()
        {
            string sql = "SELECT MaKH, HoTenKH FROM KHACHHANG";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(KhachHang_DTO kh)
        {
            if (kh.HoTenKH.Equals(""))
            {
                MessageBox.Show("Tên Khách hàng không hợp lệ ! ");
                return false;
            }
            if (kh.NgaySinhKH.Equals(""))
            {
                MessageBox.Show("Ngày Sinh Khách hàng không hợp lệ ! ");
                return false;
            }
            if (kh.NgayLamThe.Equals(""))
            {
                MessageBox.Show("Ngày Làm thẻ Khách hàng không hợp lệ ! ");
                return false;
            }
            if (kh.NgayHetHan.Equals(""))
            {
                MessageBox.Show("Ngày Hết hạn thẻ không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Khách hàng vào CSDL
        public bool ThemKH(KhachHang_DTO kh)
        {
            if (KiemTraTruocKhiLuu(kh))
            {
                string sql = string.Format("INSERT INTO KHACHHANG (MaKH, HoTenKH, EmailKH, GioiTinhKH, NgaySinhKH, DiaChiKH, DienThoaiKH, NgayLamThe, NgayHetHan, HoatDong)"
                    + " VALUES ('{0}', N'{1}', N'{2}', '{3}',N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', '{9}')", kh.MaKH, kh.HoTenKH, kh.EmailKH, kh.GioiTinhKH, kh.NgaySinhKH, kh.DiaChiKH, kh.DienThoaiKH, kh.NgayLamThe, kh.NgayHetHan, kh.HoatDong);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Khách Hàng thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Khách hàng vào CSDL
        public bool SuaKH(KhachHang_DTO kh)
        {
            if (KiemTraTruocKhiLuu(kh))
            {
                string sql = string.Format("UPDATE KHACHHANG SET HoTenKH=N'{1}', EmailKH=N'{2}', GioiTinhKH={3}, NgaySinhKH=N'{4}', DiaChiKH=N'{5}', DienThoaiKH=N'{6}', NgayLamThe=N'{7}', NgayHetHan=N'{8}', HoatDong={9} WHERE MaKH=N'{0}'",
                    kh.MaKH, kh.HoTenKH, kh.EmailKH, kh.GioiTinhKH, kh.NgaySinhKH, kh.DiaChiKH, kh.DienThoaiKH, kh.NgayLamThe, kh.NgayHetHan, kh.HoatDong);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Khách Hàng thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Khách hàng trong CSDL
        public bool XoaKH(string MaKH)
        {
            string sql = "DELETE FROM KHACHHANG WHERE MaKH='" + MaKH + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa Khách Hàng thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã kh kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("KHACHHANG", "MaKH"), "KH");
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemKH(string DieuKien, string TieuChi)
        {
            string sql = " SELECT MaKH, HoTenKH, EmailKH, (CASE GioiTinhKH WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhKH, NgaySinhKH, DiaChiKH, DienThoaiKH, NgayLamThe, NgayHetHan, (CASE HoatDong WHEN 'true' THEN N'Đang Hoạt động' ELSE N'Đã Hết hạn' END) AS HoatDong FROM KHACHHANG WHERE " + DieuKien + " LIKE N'%" + TieuChi + "%'";
            return connData.getdata(sql);
        }
    }
}
