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
    class SanPham_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Sản Phẩm để hiển thị
        public DataTable LayDanhSachSanPham()
        {
            string sql = " SELECT MaSP, TenSP, MoTa, Gia, SoLuong, NgayNhapHang, MaNPP, MaDV, MaTL, (CASE TinhTrang WHEN 'true' THEN N'Mới' ELSE N'Cũ' END) AS TinhTrang FROM SANPHAM";
            return connData.getdata(sql);
        }

        //Hàm lấy tất cả danh sách Sản Phẩm để hiển thị cho Reports
        public DataTable LayDSSPReport()
        {
            string sql = " SELECT MaSP, TenSP, Gia, SoLuong, NgayNhapHang, TinhTrang FROM SANPHAM";
            return connData.getdata(sql);
        }

        // Lấy danh sách Sản Phẩm load lên Combobox
        public DataTable LayDSSanPham()
        {
            string sql = "SELECT MaSP, TenSP FROM SANPHAM";
            return connData.getdata(sql);
        }

        // Lấy danh sách Sản Phẩm theo PM
        public DataTable LayDSSanPhamTheoPSDDV(string MaPhieu)
        {
            string sql = "SELECT MaPhieu, MaSP FROM CT_PHIEUSUDUNG WHERE MaPhieu='" + MaPhieu + "'";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(SanPham_DTO sp)
        {
            if (sp.TenSP.Equals(""))
            {
                MessageBox.Show("Tên Sản Phẩm không hợp lệ ! ");
                return false;
            }
            if (sp.NgayNhapHang.Equals(""))
            {
                MessageBox.Show("Ngày nhập Sản Phẩm không hợp lệ ! ");
                return false;
            }
            if (sp.MaNPP.Equals(""))
            {
                MessageBox.Show("Mã Nhà Phân Phối không hợp lệ ! ");
                return false;
            }
            if (sp.MaDV.Equals(""))
            {
                MessageBox.Show("Mã Dịch Vụ không hợp lệ ! ");
                return false;
            }
            if (sp.MaTL.Equals(""))
            {
                MessageBox.Show("Mã Thể loại không hợp lệ ! ");
                return false;
            }
            if (sp.TinhTrang.Equals(""))
            {
                MessageBox.Show("Tình trạng không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Sản Phẩm vào CSDL
        public bool ThemSanPham(SanPham_DTO sp)
        {
            if (KiemTraTruocKhiLuu(sp))
            {
                string sql = string.Format("INSERT INTO SANPHAM (MaSP, TenSP, MoTa, Gia, SoLuong, NgayNhapHang, MaNPP, MaDV, MaTL, TinhTrang)"
                    + " VALUES ('{0}', N'{1}', N'{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}','{9}')",
                    sp.MaSP, sp.TenSP, sp.MoTa, sp.Gia, sp.SoLuong, sp.NgayNhapHang, sp.MaNPP, sp.MaDV, sp.MaTL, sp.TinhTrang);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Sản Phẩm thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Sản Phẩm vào CSDL
        public bool SuaSanPham(SanPham_DTO sp)
        {
            if (KiemTraTruocKhiLuu(sp))
            {
                string sql = string.Format("UPDATE SANPHAM SET TenSP=N'{1}', MoTa=N'{2}', Gia='{3}', SoLuong='{4}', NgayNhapHang='{5}', MaNPP='{6}', MaDV='{7}', MaTL='{8}', TinhTrang={9} WHERE MaSP='{0}'",
                    sp.MaSP, sp.TenSP, sp.MoTa, sp.Gia, sp.SoLuong, sp.NgayNhapHang, sp.MaNPP, sp.MaDV, sp.MaTL, sp.TinhTrang);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin Sản Phẩm thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Sản Phẩm trong CSDL
        public bool XoaSanPham(string MaSP)
        {
            string sql = "DELETE FROM SANPHAM WHERE MaSP='" + MaSP + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa thông tin Sản Phẩm thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã SP kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("SANPHAM", "MaSP"), "SP");
        }

        //Tim kiem san pham theo Tieu Chi
        public DataTable TimKiemSanPham(string DieuKien, string TieuChi)
        {
            string sql = " SELECT MaSP, TenSP, Mota, Gia, SoLuong, NgayNhapHang, MaNPP, MaDV, MaTL, (CASE TinhTrang WHEN 'true' THEN N'Mới' ELSE N'Cũ' END) AS TinhTrang FROM SANPHAM WHERE "+DieuKien+" LIKE N'%" + TieuChi + "%'";
            return connData.getdata(sql);
        }
    }
}
