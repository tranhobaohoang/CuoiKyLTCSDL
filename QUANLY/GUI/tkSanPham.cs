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

namespace QLTV.GUI
{
    public partial class tkSanPham : UserControl
    {
        private SanPham_BLL sBUS = new SanPham_BLL();
        private NPP_BLL nxbBUS = new NPP_BLL();
        private DichVu_BLL tgBUS = new DichVu_BLL();
        private TheLoaiSanPham_BLL tlBUS = new TheLoaiSanPham_BLL();
        public tkSanPham()
        {
            InitializeComponent();
        }

        private void cleantxt()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cboNPP.Text = "";
            cboDichVu.Text = "";
            cboTheLoai.Text = "";
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            cboNPP.Enabled = false;
            cboDichVu.Enabled = false;
            cboTheLoai.Enabled = false;
            cboNPP.ClosePopup();
            cboDichVu.ClosePopup();
            cboTheLoai.ClosePopup();
        }

        private void tkSach_Load(object sender, EventArgs e)
        {
            //Load combobox tìm kiếm theo tên nhà Phân Phối
            cboNPP.Properties.DataSource = nxbBUS.LayDSNPP();
            cboNPP.Properties.DisplayMember = "TenNPP";
            cboNPP.Properties.ValueMember = "MaNPP";

            //Load combobox tìm kiếm theo tên Dịch Vụ
            cboDichVu.Properties.DataSource = tgBUS.LayDSDV();
            cboDichVu.Properties.DisplayMember = "TenDV";
            cboDichVu.Properties.ValueMember = "MaDV";

            //Load combobox tìm kiếm theo thể loại
            cboTheLoai.Properties.DataSource = tlBUS.LayDSTL();
            cboTheLoai.Properties.DisplayMember = "TenTL";
            cboTheLoai.Properties.ValueMember = "MaTL";
            
            //Load GridControl
            dgvDanhSachSP.DataSource = sBUS.LayDanhSachSanPham();
            cleantxt();
        }

        private void radMaSach_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radMaSP.Checked == true) txtMaSP.Enabled = true;
        }

        private void radTenSach_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTenSP.Checked == true) txtTenSP.Enabled = true;
        }

        private void radTenNXB_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTenNPP.Checked == true) cboNPP.Enabled = true;
        }

        private void radTenTG_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTenDV.Checked == true) cboDichVu.Enabled = true;
        }

        private void radTheLoai_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTheLoai.Checked == true) cboTheLoai.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (radMaSP.Checked)
            {
                dgvDanhSachSP.DataSource = sBUS.TimKiemSanPham("MaSP",txtMaSP.Text);
            }
            if (radTenSP.Checked)
            {
                dgvDanhSachSP.DataSource = sBUS.TimKiemSanPham("TenSP",txtTenSP.Text);
            }
            
            if (radTenNPP.Checked)
            {
                dgvDanhSachSP.DataSource = sBUS.TimKiemSanPham("MaNPP", cboNPP.EditValue.ToString());
            }
            if (radTenDV.Checked)
            {
                dgvDanhSachSP.DataSource = sBUS.TimKiemSanPham("MaDV", cboDichVu.EditValue.ToString());
            }
            if (radTheLoai.Checked)
            {
                dgvDanhSachSP.DataSource = sBUS.TimKiemSanPham("MaTL", cboTheLoai.EditValue.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cleantxt();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            tkSach_Load(sender, e);
        }
    }
}
