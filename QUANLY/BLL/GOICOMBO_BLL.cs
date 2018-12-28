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
    class GOICOMBO_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Gói Combo
        public DataTable LayDanhSachGOICOMBO()
        {
            string sql = "SELECT MaPhieu, MaSP, MaNV, NgayHetHan FROM GOICOMBO";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(GOICOMBO_DTO goicb)
        {
            if (goicb.MaSP.Equals(""))
            {
                MessageBox.Show("Mã Sản Phẩm không hợp lệ ! ");
                return false;
            }
            if (goicb.MaNV.Equals(""))
            {
                MessageBox.Show("Nhân Viên không hợp lệ ! ");
                return false;
            }
            if (goicb.NgayHetHan.Equals(""))
            {
                MessageBox.Show("Ngày Hết Hạn không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Gói Combo vào CSDL
        public bool ThemPT(GOICOMBO_DTO goicb)
        {
            if (KiemTraTruocKhiLuu(goicb))
            {
                string sql = string.Format("INSERT INTO GOICOMBO (MaPhieu, MaSP, MaNV, NgayHetHan)"
                    + " VALUES ('{0}', '{1}', '{2}', '{3}')", 
                    goicb.MaPhieu, goicb.MaSP, goicb.MaNV, goicb.NgayHetHan);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Gói Combo thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        //Sửa Gói Combo vào CSDL
        public bool SuaGoiCombo(GOICOMBO_DTO goicb)
        {
            if (KiemTraTruocKhiLuu(goicb))
            {
                string sql = string.Format("UPDATE GOICOMBO SET MaSP=N'{1}', MaNV=N'{2}', NgayHetHan=N'{3}' WHERE MaPhieu=N'{0}'", goicb.MaPhieu, goicb.MaSP, goicb.MaNV, goicb.NgayHetHan);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Gói Combo thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Gói Combo trong CSDL
        public bool XoaGoiCombo(string MaSP)
        {
            string sql = "DELETE FROM GOICOMBO WHERE MaSP='" + MaSP + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa Gói Combo thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
