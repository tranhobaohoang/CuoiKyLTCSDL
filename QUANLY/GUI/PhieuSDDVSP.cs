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

namespace QUANLY.Use_Control
{
    public partial class PhieuSDDVSP : UserControl
    {
        private PhieuSDDVSP_BLL pmBUS = new PhieuSDDVSP_BLL();
        private KhachHang_BLL dgBUS = new KhachHang_BLL();
        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        private SanPham_BLL sBUS = new SanPham_BLL();
        private CTPhieuSDDVSP_BLL ctpmBUS = new CTPhieuSDDVSP_BLL();
        private bool addpm = false, updatepm = false, addctpm=false, updatectpm=false;

        private void cleantxtPM()
        {
            cboMaKH.Text = "";
            dateEdit1.Text = "";
            cboMaNV.Text = "";
        }
        private void cleantxtCTPM()
        {
            cboMaPhieu.Text = "";
            cboSach.Text = "";
            dateEdit2.Text = "";
        }

        private void bindingPM()
        {
            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", dgvPhieuSDDVSP.DataSource, "MaPhieu");
            cboMaKH.DataBindings.Clear();
            cboMaKH.DataBindings.Add("EditValue", dgvPhieuSDDVSP.DataSource, "MaKH");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("Text", dgvPhieuSDDVSP.DataSource, "NgaySuDung");
            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("EditValue", dgvPhieuSDDVSP.DataSource, "MaNV");
        }
        private void bindingCTPM()
        {
            cboMaPhieu.DataBindings.Clear();
            cboMaPhieu.DataBindings.Add("EditValue", dgvCTPhieuSDDVSP.DataSource, "MaPhieu");
            cboSach.DataBindings.Clear();
            cboSach.DataBindings.Add("EditValue", dgvCTPhieuSDDVSP.DataSource, "MaSP");
            dateEdit2.DataBindings.Clear();
            dateEdit2.DataBindings.Add("Text", dgvCTPhieuSDDVSP.DataSource, "NgaySuDung");
        }

        //Lấy Thông tin Phieu Muon
        private PhieuSDDVSP_DTO LayTTPM()
        {
            PhieuSDDVSP_DTO pm = new PhieuSDDVSP_DTO();
            pm.MaPhieu = txtMaPhieu.Text; 
            pm.MaKH = cboMaKH.EditValue.ToString();
            pm.NgaySuDung = Convert.ToDateTime(dateEdit1.EditValue.ToString());
            pm.MaNV = cboMaNV.EditValue.ToString();
            return pm;
        }
        private CTPhieuSDDVSP_DTO LayTTCTPM()
        {
            CTPhieuSDDVSP_DTO ctpm = new CTPhieuSDDVSP_DTO();
            ctpm.MaPhieu = cboMaPhieu.EditValue.ToString();
            ctpm.MaSP = cboSach.EditValue.ToString();
            ctpm.NgaySuDung = Convert.ToDateTime(dateEdit2.EditValue.ToString());
            return ctpm;
        }

        public PhieuSDDVSP()
        {
            InitializeComponent();
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {
            // Load combobox Mã NPP
            cboMaKH.Properties.DataSource = dgBUS.LayDSKH();
            cboMaKH.Properties.DisplayMember = "HoTenKH";
            cboMaKH.Properties.ValueMember = "MaKH";

            // Load combobox Mã DV
            cboMaNV.Properties.DataSource = nvBUS.LayDSNV();
            cboMaNV.Properties.DisplayMember = "HoTenNV";
            cboMaNV.Properties.ValueMember = "MaNV";

            //Load ComboBox Mã Phiếu
            cboMaPhieu.Properties.DataSource = pmBUS.LayDSSD();
            cboMaPhieu.Properties.DisplayMember = "MaPhieu";
            cboMaPhieu.Properties.ValueMember = "MaPhieu";

            //Load ComboBox Mã SP
            cboSach.Properties.DataSource = sBUS.LayDSSanPham();
            cboSach.Properties.DisplayMember = "TenSP";
            cboSach.Properties.ValueMember = "MaSP";

            //Load DataGrid
            dgvPhieuSDDVSP.DataSource = pmBUS.LayDanhSachSD();
            dgvCTPhieuSDDVSP.DataSource = ctpmBUS.LayDanhSachctpsddvsp();
            groupControl2.Enabled = false;
            groupControl4.Enabled = false;
            bindingPM();
            bindingCTPM();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addpm = true;
            groupControl2.Enabled = true;
            // Load NextID len textbox MaPM
            txtMaPhieu.Text = pmBUS.NextID();
            cleantxtPM();
            cboMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updatepm = true;
            groupControl2.Enabled = true;
            cboMaKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CTPhieuSDDVSP_DTO ctpm = LayTTCTPM();
            if (MessageBox.Show("Bạn có muốn xóa Phiếu Sử Dụng : " + txtMaPhieu.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pmBUS.KiemTra(txtMaPhieu.Text))
                {
                    MessageBox.Show("Bạn phải xóa thông tin trong bảng Chi Tiết Phiếu Sử Dụng trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                pmBUS.XoaSDSPDV(txtMaPhieu.Text);
                MuonSach_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuSDDVSP_DTO pm = LayTTPM();
            if (addpm)
            {
                pmBUS.ThemSDDVSP(pm);
                MuonSach_Load(sender, e);
            }
            if (updatepm)
                pmBUS.SuaSDSPDV(pm);
            MuonSach_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            MuonSach_Load(sender, e);
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            addctpm = true;
            groupControl4.Enabled = true;
            // Load NextID len textbox MaPM
            cleantxtPM();
            cboMaPhieu.Focus();
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            updatepm = true;
            groupControl4.Enabled = true;
            cboMaPhieu.Enabled = false;
            cboSach.Focus();
        }

        private void cboSach_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btthanhtoan_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Chi tiết Phiếu Sử Dụng : " + txtMaPhieu.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctpmBUS.Xoactpsddvsp(txtMaPhieu.Text);
                MuonSach_Load(sender, e);
            }
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            CTPhieuSDDVSP_DTO ctpm = LayTTCTPM();
            if (addctpm)
            {
                ctpmBUS.Themctpsddvsp(ctpm);
                MuonSach_Load(sender, e);
            }
            if (updatectpm)
                ctpmBUS.Suactpsddvsp(ctpm);
            MuonSach_Load(sender, e);
        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            MuonSach_Load(sender, e);
        }
    }
}
