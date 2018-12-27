using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.BLL;
using QLTV.DTO;

namespace QLTV.Use_Control
{
    public partial class cnSach : UserControl
    {
        private SanPham_BLL sBUS = new SanPham_BLL();
        private NPP_BLL nxbBUS = new NPP_BLL();
        private DichVu_BLL tgBUS = new DichVu_BLL();
        private TheLoaiSanPham_BLL tlBUS = new TheLoaiSanPham_BLL();
        private bool add = false, update = false;

        private void cleantxt()
        {
            txtTenSP.Text = "";
            txtMoTa.Text = "";
            //txtSoTrang.Text = "";
            txtGia.Text = "";
            cboNPP.Text = "";
            cboDichVu.Text = "";
            cboTheLoai.Text = "";
            txtSoLuong.Text = "";
            dateEdit1.Text = "";
        }

        private void binding()
        {
            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", dgvSanPham.DataSource, "MaSP");
            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", dgvSanPham.DataSource, "TenSP");
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dgvSanPham.DataSource, "MoTa");
            //txtSoTrang.DataBindings.Clear();
            //.DataBindings.Add("Text", dgvSach.DataSource, "SoLuongg");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvSanPham.DataSource, "Gia");
            cboNPP.DataBindings.Clear();
            cboNPP.DataBindings.Add("EditValue", dgvSanPham.DataSource, "MaNPP");
            cboDichVu.DataBindings.Clear();
            cboDichVu.DataBindings.Add("EditValue", dgvSanPham.DataSource, "MaDV");
            cboTheLoai.DataBindings.Clear();
            cboTheLoai.DataBindings.Add("EditValue", dgvSanPham.DataSource, "MaTL");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvSanPham.DataSource, "SoLuong");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("Text", dgvSanPham.DataSource, "NgayNhapHang");
            cboTinhTrang.DataBindings.Clear();
            cboTinhTrang.DataBindings.Add("Text", dgvSanPham.DataSource, "TinhTrang");
        }

        //Lấy Thông tin Sách
        private SanPham_DTO LayTTSach()
        {
            SanPham_DTO s = new SanPham_DTO();
            s.MaSP = txtMaSP.Text;
            s.TenSP = txtTenSP.Text;
            s.MoTa = txtMoTa.Text;
            //s.SoLuongg = Convert.ToInt16(txtSoTrang.Text);
            s.Gia = Convert.ToInt32(txtGia.Text);
            s.MaNPP = cboNPP.EditValue.ToString();
            s.MaDV = cboDichVu.EditValue.ToString();
            s.MaTL = cboTheLoai.EditValue.ToString();
            s.TinhTrang = (cboTinhTrang.Text == "Sách Mới") ? 1 : 0;
            s.SoLuong = Convert.ToInt16(txtSoLuong.Text);
            s.NgayNhapHang = Convert.ToDateTime(dateEdit1.EditValue.ToString());  
            return s;
        }

        public cnSach()
        {
            InitializeComponent();
        }

        private void cnSach_Load(object sender, EventArgs e)
        {
            // Load combobox Mã NXB
            cboNPP.Properties.DataSource = nxbBUS.LayDSNPP();
            cboNPP.Properties.DisplayMember = "TenNPP";
            cboNPP.Properties.ValueMember = "MaNPP";

            // Load combobox Mã TG
            cboDichVu.Properties.DataSource = tgBUS.LayDSDV();
            cboDichVu.Properties.DisplayMember = "TenDV";
            cboDichVu.Properties.ValueMember = "MaDV";

            // Load combobox Mã TL
            cboTheLoai.Properties.DataSource = tlBUS.LayDSTL();
            cboTheLoai.Properties.DisplayMember = "TenTL";
            cboTheLoai.Properties.ValueMember = "MaTL";

            //Load DataGrid
            dgvSanPham.DataSource = sBUS.LayDanhSachSanPham();
            groupControl1.Enabled = false;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            groupControl1.Enabled = true;
            // Load NextID len textbox MaSV
            txtMaSP.Text = sBUS.NextID();
            cleantxt();
            txtTenSP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            groupControl1.Enabled = true;
            txtTenSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa Sách : " + txtTenSP.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sBUS.XoaSanPham(txtMaSP.Text);
                cnSach_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPham_DTO s = LayTTSach();
            if (add)
            {
                sBUS.ThemSanPham(s);
                cnSach_Load(sender, e);
            }
            if (update)
                sBUS.SuaSanPham(s);
                cnSach_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnSach_Load(sender, e);
        }

        //Chỉ cho phép nhập vào số
        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                //Bỏ qua những phím không hợp lệ
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
