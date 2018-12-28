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
    public partial class cnNXB : UserControl
    {
        private NPP_BLL nxbBUS = new NPP_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenNPP.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtWebsite.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaNPP.DataBindings.Clear();
            txtMaNPP.DataBindings.Add("Text", dgvNPP.DataSource, "MaNPP");
            txtTenNPP.DataBindings.Clear();
            txtTenNPP.DataBindings.Add("Text", dgvNPP.DataSource, "TenNPP");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNPP.DataSource, "DiaChiNPP");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dgvNPP.DataSource, "DienThoaiNPP");
            txtWebsite.DataBindings.Clear();
            txtWebsite.DataBindings.Add("Text", dgvNPP.DataSource, "Website");
        }

        //Lấy Thông tin NXB
        private NPP_DTO LayTTNXB()
        {
            NPP_DTO nxb = new NPP_DTO();
            nxb.MaNPP = txtMaNPP.Text;
            nxb.TenNPP = txtTenNPP.Text;
            nxb.DiaChiNPP = txtDiaChi.Text;
            nxb.DienThoaiNPP = txtSdt.Text;
            nxb.Website = txtWebsite.Text;
            return nxb;
        }

        public cnNXB()
        {
            InitializeComponent();
        }

        private void cnNXB_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvNPP.DataSource = nxbBUS.LayDanhSachNPP();
            groupControl1.Enabled = false;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            groupControl1.Enabled = true;
            // Load NextID len textbox MaNXB
            txtMaNPP.Text = nxbBUS.NextID();
            cleantxt();
            txtMaNPP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            groupControl1.Enabled = true;
            txtMaNPP.Enabled = false;
            txtTenNPP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Nhà Phân Phối: " + txtTenNPP.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nxbBUS.KiemTra(txtMaNPP.Text))
                {
                    MessageBox.Show("Bạn phải xóa những sách có mã NXB '" + txtMaNPP.Text + "' trong bảng Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nxbBUS.XoaNPP(txtMaNPP.Text);
                    cnNXB_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NPP_DTO nxb = LayTTNXB();
            if (add)
            {
                nxbBUS.ThemNPP(nxb);
                cnNXB_Load(sender, e);
            }
            if (update)
                nxbBUS.SuaNPP(nxb);
                cnNXB_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnNXB_Load(sender, e);
        }
    }
}
