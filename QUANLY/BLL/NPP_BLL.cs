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
    class NPP_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách NPP để hiển thị
        public DataTable LayDanhSachNPP()
        {
            string sql = "SELECT MaNPP, TenNPP, DiaChiNPP, DienThoaiNPP, Website FROM NHAPHANPHOI";
            return connData.getdata(sql);
        }

        // Lấy danh sách NPP load sang Combobox
        public DataTable LayDSNPP()
        {
            string sql = "SELECT MaNPP, TenNPP FROM NHAPHANPHOI";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(NPP_DTO NPP)
        {
            if (NPP.MaNPP.Equals(""))
            {
                MessageBox.Show("Mã Nhà Phân Phối không hợp lệ ! ");
                return false;
            }
            if (NPP.TenNPP.Equals(""))
            {
                MessageBox.Show("Tên Nhà Phân Phối không hợp lệ ! ");
                return false;
            }
            if (NPP.DiaChiNPP.Equals(""))
            {
                MessageBox.Show("Địa chỉ Nhà Phân Phối không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra tồn tại của Mã NPP
        public bool KiemTra(string manpp)
        {
            if (connData.KiemTraTonTai("SANPHAM", "MaNPP", manpp))
                return true;
            return false;
        }

        //Thêm Nhà Phân Phối vào CSDL
        public bool ThemNPP(NPP_DTO NPP)
        {
            if (KiemTraTruocKhiLuu(NPP))
            {
                string sql = string.Format("INSERT INTO NHAPHANPHOI (MaNPP, TenNPP, DiaChiNPP, DienThoaiNPP, Website)"
                    + " VALUES ('{0}', N'{1}', N'{2}', N'{3}',N'{4}')", NPP.MaNPP, NPP.TenNPP, NPP.DiaChiNPP, NPP.DienThoaiNPP, NPP.Website);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Nhà Phân Phối thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Nhà Phân Phối vào CSDL
        public bool SuaNPP(NPP_DTO NPP)
        {
            if (KiemTraTruocKhiLuu(NPP))
            {
                string sql = string.Format("UPDATE NHAPHANPHOI SET TenNPP=N'{1}', DiaChiNPP=N'{2}', DienThoaiNPP=N'{3}', Website=N'{4}' WHERE MaNPP=N'{0}'", NPP.MaNPP, NPP.TenNPP, NPP.DiaChiNPP, NPP.DienThoaiNPP, NPP.Website);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Nhà Phân Phối thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Nhà Phân Phối trong CSDL
        public bool XoaNPP(string MaNPP)
        {
            string sql = "DELETE FROM NHAPHANPHOI WHERE MaNPP='" + MaNPP + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa Nhà Phân Phối thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("NHAPHANPHOI", "MaNPP"), "NPP");
        }
    }
}
