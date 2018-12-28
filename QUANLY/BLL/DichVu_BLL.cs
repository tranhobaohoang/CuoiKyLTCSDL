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
    class DichVu_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public  DataTable LayDanhSachDichVu()
        {
            string sql = "SELECT * FROM DICHVU";
            return connData.getdata(sql);
        }

        // Lấy danh sách Dịch Vụ
        public DataTable LayDSDV()
        {
            string sql = "SELECT MaDV, TenDV, MoTaDV FROM DICHVU";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(DichVu_DTO dv)
        {
            if (dv.MaDV.Equals(""))
            {
                MessageBox.Show("Mã Dịch Vụ không hợp lệ ! ");
                return false;
            }
            if (dv.TenDV.Equals(""))
            {
                MessageBox.Show("Tên Dịch Vụ không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra sự tồn tại của Mã dv trong bảng Sản Phẩm
        public bool KiemTra(string madv)
        {
            if (connData.KiemTraTonTai("SANPHAM", "MaDV", madv))
                return true;
            return false;
        }

        //Thêm Dịch Vụ vào CSDL
        public bool ThemDV(DichVu_DTO dv)
        {
            if (KiemTraTruocKhiLuu(dv))
            {
                string sql = string.Format("INSERT INTO DICHVU (MaDV, TenDV, MoTaDV)" 
                    + " VALUES ('{0}', N'{1}', N'{2}')", dv.MaDV, dv.TenDV, dv.MoTaDV);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Dịnh Vụ thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        //Sửa Dịch Vụ vào CSDL
        public bool SuaDV(DichVu_DTO dv)
        {
            if (KiemTraTruocKhiLuu(dv))
            {
                string sql = string.Format("UPDATE DICHVU SET TenDV=N'{1}', MoTaDV=N'{2}' WHERE MaDV=N'{0}'", dv.MaDV, dv.TenDV, dv.MoTaDV);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Dịch Vụ thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Dịch Vụ trong CSDL
        public bool XoaDV(string MaDV)
        {
            string sql = "DELETE FROM DICHVU WHERE MaDV='" + MaDV + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa Dịch Vụ thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("DICHVU", "MaDV"), "DV");
        }
    }
}
