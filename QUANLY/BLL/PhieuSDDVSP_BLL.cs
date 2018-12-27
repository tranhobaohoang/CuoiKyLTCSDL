using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLTV.DAL;
using QLTV.DTO;

namespace QLTV.BLL
{
    class PhieuSDDVSP_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Phiếu Sử dụng để hiển thị
        public DataTable LayDanhSachSD()
        {
            string sql = " SELECT MaPhieu, MaKH, NgaySuDung, MaNV FROM PHIEUSUDUNG";
            return connData.getdata(sql);
        }

        // Lấy danh sách SD cho load sang ComboBox 
        public DataTable LayDSSD()
        {
            string sql = "SELECT MaPhieu, MaKH, NgaySuDung, MaNV FROM PHIEUSUDUNG";
            return connData.getdata(sql);
        }

        //Lấy danh sách số lượt sử dụng
        public DataTable LayDSLuotSuDung()
        {
            string sql = "SELECT CT_PHIEUSUDUNG.MaSP, SANPHAM.TenSP, SANPHAM.Gia, SANPHAM.SoLuong, THELOAI.TenTL, DICHVU.TenDV, COUNT(CT_PHIEUSUDUNG.MaSP) AS TongLuotSuDung FROM CT_PHIEUSUDUNG INNER JOIN PHIEUSUDUNG ON CT_PHIEUSUDUNG.MaPhieu = PHIEUSUDUNG.MaPhieu INNER JOIN SANPHAM ON CT_PHIEUSUDUNG.MaSP = SACH.MaSP INNER JOIN THELOAI ON SANPHAM.MaTL = THELOAI.MaTL INNER JOIN DICHVU ON SANPHAM.MaDV = DICHVU.MaDV WHERE (SANPHAM.MaSP IN (SELECT MaSP FROM CT_PHIEUSUDUNG AS CT_PHIEUSUDUNG_1)) GROUP BY CT_PHIEUSUDUNG.MaSP, SANPHAM.TenSP, SANPHAM.Gia, SANPHAM.SoLuong, THELOAI.TenTL, DICHVU.TenDV";
            return connData.getdata(sql);
        }

        //Lấy danh sách số lượt sử dụng Quá hạn
        


        //Lấy danh sách Sản Phẩm chưa được mượn
        public DataTable LayDSSPChuaDuocSuDung()
        {
            string sql = "SELECT  SANPHAM.MaSP, SANPHAM.TenSP, DICHVU.TenDV, THELOAI.TenTL, NHAPHANPHOI.TenNPP, SANPHAM.Gia, SANPHAM.SoLuong, SANPHAM.NgayNhapHang FROM SANPHAM INNER JOIN DICHVU ON SANPHAM.MaDV = DICHVU.MaDV INNER JOIN THELOAI ON SANPHAM.MaTL = THELOAI.MaTL INNER JOIN NHAPHANPHOI ON SANPHAM.MaNPP = NHAPHANPHOI.MaNPP WHERE (SANPHAM.MaSP NOT IN (SELECT MaSP FROM CT_PHIEUSUDUNG))";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(PhieuSDDVSP_DTO SD)
        {
            if (SD.MaPhieu.Equals(""))
            {
                MessageBox.Show("Mã Phiếu không hợp lệ ! ");
                return false;
            }
            if (SD.NgaySuDung.Equals(""))
            {
                MessageBox.Show("Ngày sử dụng không hợp lệ ! ");
                return false;
            }
            if (SD.MaNV.Equals(""))
            {
                MessageBox.Show("Mã Nhân Viên không hợp lệ ! ");
                return false;
            }
            return true;
        }

        public bool KiemTra(string maphieu)
        {
            if (connData.KiemTraTonTai("CT_PHIEUSUDUNG", "MaPhieu", maphieu))
                return true;
            return false;
        }

        //Thêm Phiếu Sử dụng vào CSDL
        public bool ThemSDDVSP(PhieuSDDVSP_DTO SD)
        {
            if (KiemTraTruocKhiLuu(SD))
            {
                string sql = string.Format("INSERT INTO PHIEUSUDUNG (MaPhieu, MaKH, NgaySuDung, MaNV)"
                    + " VALUES ('{0}', '{1}', '{2}', '{3}')",
                    SD.MaPhieu, SD.MaKH, SD.NgaySuDung, SD.MaNV);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Phiếu Sử dụng thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Phiếu Sử dụng vào CSDL
        public bool SuaSDSPDV(PhieuSDDVSP_DTO SD)
        {
            if (KiemTraTruocKhiLuu(SD))
            {
                string sql = string.Format("UPDATE PHIEUSUDUNG SET MaKH='{1}', NgaySuDung=N'{2}', MaNV='{3}' WHERE MaPhieu='{0}'",
                    SD.MaPhieu, SD.MaKH, SD.NgaySuDung, SD.MaNV);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin Phiếu Sử dụng thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Phiếu Sử dụng trong CSDL
        public bool XoaSDSPDV(string MaPhieu)
        {
            string sql = "DELETE FROM PHIEUSUDUNG WHERE MaPhieu='" + MaPhieu + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa thông tin Phiếu Sử dụng thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã KH kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("PHIEUSUDUNG", "MaPhieu"), "SD");
        }
    }
}
