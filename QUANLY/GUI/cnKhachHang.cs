using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QUANLY.BLL;
using QUANLY.DTO;

namespace QUANLY.Use_Control
{
    public partial class cnDocGia : UserControl
    {

        private KhachHang_BLL dgBUS = new KhachHang_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        private void cleantxt()
        {
            txtTenKH.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            dateEdit1.Text = "";
            dateEdit3.Text = "";
            dateEdit2.Text = "";
        }

        private void binding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "HoTenKH");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvKhachHang.DataSource, "EmailKH");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text",dgvKhachHang.DataSource, "GioiTinhKH");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("Text",dgvKhachHang.DataSource, "NgaySinhKH");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text",dgvKhachHang.DataSource, "DiaChiKH");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text",dgvKhachHang.DataSource, "DienThoaiKH");
            dateEdit2.DataBindings.Clear();
            dateEdit2.DataBindings.Add("Text",dgvKhachHang.DataSource,"NgayLamThe");
            dateEdit3.DataBindings.Clear();
            dateEdit3.DataBindings.Add("Text", dgvKhachHang.DataSource, "NgayHetHan");
            cboTinhTrang.DataBindings.Clear();
            cboTinhTrang.DataBindings.Add("Text",dgvKhachHang.DataSource,"HoatDong");
        }

        //Lấy Thông tin Độc giả
        private KhachHang_DTO LayTTDG()
        {
            KhachHang_DTO dg = new KhachHang_DTO();
            dg.MaKH = txtMaKH.Text;
            dg.HoTenKH = txtTenKH.Text;
            dg.EmailKH = txtEmail.Text;
            dg.GioiTinhKH = (cboGioiTinh.Text == "Nam") ? 1 : 0;
            dg.NgaySinhKH = Convert.ToDateTime(dateEdit1.EditValue.ToString());
            dg.DiaChiKH = txtDiaChi.Text;
            dg.DienThoaiKH = txtSdt.Text;
            dg.NgayLamThe = Convert.ToDateTime(dateEdit2.EditValue.ToString());
            dg.NgayHetHan = Convert.ToDateTime(dateEdit3.EditValue.ToString());
            dg.HoatDong = (cboTinhTrang.Text == "Đang Hoạt Động") ? 1 : 0;
            return dg;
        }

        public cnDocGia()
        {
            InitializeComponent();
        }

        private void cnDocGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvKhachHang.DataSource = dgBUS.LayDanhSachKhachHang();
            groupControl1.Enabled = false;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            groupControl1.Enabled = true;
            // Load NextID len textbox MaSV
            txtMaKH.Text = dgBUS.NextID();
            cleantxt();
            txtTenKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            groupControl1.Enabled = true;
            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Khách Hàng: " + txtTenKH.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgBUS.XoaKH(txtMaKH.Text);
                cnDocGia_Load(sender, e);
            }
        }

        private void btnLuulai_Click(object sender, EventArgs e)
        {
            KhachHang_DTO tg = LayTTDG();
            if (add)
            {
                dgBUS.ThemKH(tg);
                cnDocGia_Load(sender, e);
            }
            if (update)
                dgBUS.SuaKH(tg);
                cnDocGia_Load(sender, e);        
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            cnDocGia_Load(sender, e);   
        }
    }
}
