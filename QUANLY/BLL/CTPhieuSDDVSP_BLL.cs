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
    class CTPhieuSDDVSP_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Phiếu Sử Dụng để hiển thị
        public DataTable LayDanhSachctpsddvsp()
        {
            string sql = " SELECT MaPhieu, MaSP, NgaySuDung FROM CT_PHIEUSUDUNG";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(CTPhieuSDDVSP_DTO ctpsddvsp)
        {
            if (ctpsddvsp.MaPhieu.Equals(""))
            {
                MessageBox.Show("Mã Phiếu không hợp lệ ! ");
                return false;
            }
            if (ctpsddvsp.MaSP.Equals(""))
            {
                MessageBox.Show("Mã Sản Phẩm không hợp lệ ! ");
                return false;
            }
            if (ctpsddvsp.NgaySuDung.Equals(""))
            {
                MessageBox.Show("Hạn trả không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm CT Phiếu Sử Dụng vào CSDL
        public bool Themctpsddvsp(CTPhieuSDDVSP_DTO ctpsddvsp)
        {
            if (KiemTraTruocKhiLuu(ctpsddvsp))
            {
                string sql = string.Format("INSERT INTO CT_PHIEUSUDUNG (MaPhieu, MaSP, NgaySuDung)"
                    + " VALUES ('{0}', '{1}', '{2}')",
                    ctpsddvsp.MaPhieu, ctpsddvsp.MaSP, ctpsddvsp.NgaySuDung);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Chi tiết Phiếu Sử Dụng thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa CT Phiếu Sử Dụng vào CSDL
        public bool Suactpsddvsp(CTPhieuSDDVSP_DTO ctpsddvsp)
        {
            if (KiemTraTruocKhiLuu(ctpsddvsp))
            {
                string sql = string.Format("UPDATE CT_PHIEUSUDUNG SET MaSP='{1}',                               HanTra='{2}' WHERE MaPhieu='{0}'",
                    ctpsddvsp.MaPhieu, ctpsddvsp.MaSP, ctpsddvsp.NgaySuDung);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin Chi tiết thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa CT Phiếu Sử Dụng trong CSDL
        public bool Xoactpsddvsp(string MaPhieu)
        {
            string sql = "DELETE FROM CT_PHIEUSUDUNG WHERE MaPhieu='" + MaPhieu + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa thông tin Chi tiết thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
