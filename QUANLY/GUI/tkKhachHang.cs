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
    public partial class tkKhachHang : UserControl
    {
        private KhachHang_BLL dgBUS = new KhachHang_BLL();

        public tkKhachHang()
        {
            InitializeComponent();
        }

        private void cleantxt()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
        }

        private void tkDocGia_Load(object sender, EventArgs e)
        {
            // Load DataGrid
            dgvKhachHang.DataSource = dgBUS.LayDanhSachKhachHang();
            cleantxt();
        }

        private void radMaDG_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radMaKH.Checked == true) txtMaKH.Enabled = true;
        }

        private void radTenDG_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTenKH.Checked == true) txtTenKH.Enabled = true;
        }

        private void radDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radDiaChi.Checked == true) txtDiaChi.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (radMaKH.Checked)
            {
                dgvKhachHang.DataSource = dgBUS.TimKiemKH("MaKH", txtMaKH.Text);
            }
            if (radTenKH.Checked)
            {
                dgvKhachHang.DataSource = dgBUS.TimKiemKH("HoTenKH", txtTenKH.Text);
            }
            if (radDiaChi.Checked)
            {
                dgvKhachHang.DataSource = dgBUS.TimKiemKH("DiaChiKH", txtDiaChi.Text);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cleantxt();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            tkDocGia_Load(sender, e);
        }
    }
}
