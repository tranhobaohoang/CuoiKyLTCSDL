using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLY.BLL;
using QUANLY.DTO;

namespace QUANLY.GUI
{
    public partial class ttBanThan : UserControl
    {
        NhanVien_BLL nvBUS = new NhanVien_BLL();
        public ttBanThan()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            Utilities.user= nvBUS.LayThongTinBanThan(Utilities.user.MaNV);
            txtMaNV.Text = Utilities.user.MaNV;
            txtHoTenNV.Text = Utilities.user.HoTenNV;
            //lỗi. không lấy đúng 
            if (Convert.ToString(Utilities.user.GioiTinhNV) == "True")
            {
                txtGioiTinh.Text = "Nam";
            }
            else
            {
                txtGioiTinh.Text = "Nữ";
            }
            dateNgaySinh.Text = Convert.ToString(Utilities.user.NgaySinhNV);
            txtSdt.Text = Utilities.user.DienThoaiNV;
            txtDiaChi.Text = Utilities.user.DiaChiNV;
            txtEmail.Text = Utilities.user.EmailNV;
            dateNgayVaoLam.Text = Convert.ToString(Utilities.user.NgayVaoLam);
            //lỗi. không lấy đúng 
            if (Convert.ToString(Utilities.user.QuyenHan)=="True")
            {
                txtQuyenHan.Text = "Quản Lý";
            }
            else txtQuyenHan.Text = "Nhân Viên";           
        }

    }
}
