using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUANLY.BLL;
using QUANLY.DTO;

namespace QUANLY.Use_Control
{
    public partial class cnDichVu : UserControl
    {
        private DichVu_BLL tgBUS = new DichVu_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenDV.Text = "";
            txtMoTaDV.Text = "";
            //txtSdt.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaDV.DataBindings.Clear();
            txtMaDV.DataBindings.Add("Text", dgvDichVu.DataSource, "MaDV");
            txtTenDV.DataBindings.Clear();
            txtTenDV.DataBindings.Add("Text", dgvDichVu.DataSource, "TenDV");
            txtMoTaDV.DataBindings.Clear();
            txtMoTaDV.DataBindings.Add("Text", dgvDichVu.DataSource, "MoTaDV");
            //txtSdt.DataBindings.Clear();
            //txtSdt.DataBindings.Add("Text", dgvTacGia.DataSource, "DienThoaiTG");
        }

        //Lấy Thông tin Dịch Vụ
        private DichVu_DTO LayTTTG()
        {
            DichVu_DTO tg = new DichVu_DTO();
            tg.MaDV = txtMaDV.Text;
            tg.TenDV = txtTenDV.Text;
            tg.MoTaDV = txtMoTaDV.Text;
            //tg.DienThoaiTG = txtSdt.Text;
            return tg;
        }

        public cnDichVu()
        {
            InitializeComponent();
        }

        private void cnTacGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvDichVu.DataSource = tgBUS.LayDanhSachDichVu();
            groupControl1.Enabled = false;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            groupControl1.Enabled = true;
            // Load NextID len textbox MaSV
            txtMaDV.Text = tgBUS.NextID();
            cleantxt();
            txtTenDV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            groupControl1.Enabled = true;
            txtMaDV.Enabled = false;
            txtTenDV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Dịch Vụ: " + txtTenDV.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tgBUS.KiemTra(txtMaDV.Text))
                {
                    MessageBox.Show("Bạn phải xóa những loại sách có mã TG '" + txtMaDV.Text + "' trong bảng Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tgBUS.XoaDV(txtMaDV.Text);
                    cnTacGia_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DichVu_DTO tg = LayTTTG();
            if (add)
            {
                tgBUS.ThemDV(tg);
                cnTacGia_Load(sender, e);
            }
            if (update)
                tgBUS.SuaDV(tg);
            cnTacGia_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnTacGia_Load(sender, e);
        }
    }
}
