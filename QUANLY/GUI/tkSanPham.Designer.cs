namespace QLTV.GUI
{
    partial class tkSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHienThi = new DevExpress.XtraEditors.SimpleButton();
            this.cboTheLoai = new DevExpress.XtraEditors.LookUpEdit();
            this.cboDichVu = new DevExpress.XtraEditors.LookUpEdit();
            this.cboNPP = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.radTheLoai = new System.Windows.Forms.RadioButton();
            this.radTenDV = new System.Windows.Forms.RadioButton();
            this.radTenNPP = new System.Windows.Forms.RadioButton();
            this.radTenSP = new System.Windows.Forms.RadioButton();
            this.radMaSP = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDanhSachSP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhapHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNPP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnHienThi);
            this.groupControl1.Controls.Add(this.cboTheLoai);
            this.groupControl1.Controls.Add(this.cboDichVu);
            this.groupControl1.Controls.Add(this.cboNPP);
            this.groupControl1.Controls.Add(this.txtTenSP);
            this.groupControl1.Controls.Add(this.txtMaSP);
            this.groupControl1.Controls.Add(this.radTheLoai);
            this.groupControl1.Controls.Add(this.radTenDV);
            this.groupControl1.Controls.Add(this.radTenNPP);
            this.groupControl1.Controls.Add(this.radTenSP);
            this.groupControl1.Controls.Add(this.radMaSP);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnTim);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(860, 179);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Nhập các thông tin";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Appearance.Options.UseFont = true;
            this.btnHienThi.ImageOptions.Image = global::QLTV.Properties.Resources.find;
            this.btnHienThi.Location = new System.Drawing.Point(699, 76);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(126, 36);
            this.btnHienThi.TabIndex = 41;
            this.btnHienThi.Text = "Hiển thị Tất cả";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.Location = new System.Drawing.Point(369, 146);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTheLoai.Size = new System.Drawing.Size(250, 20);
            this.cboTheLoai.TabIndex = 40;
            // 
            // cboDichVu
            // 
            this.cboDichVu.Location = new System.Drawing.Point(369, 117);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDichVu.Size = new System.Drawing.Size(250, 20);
            this.cboDichVu.TabIndex = 39;
            // 
            // cboNPP
            // 
            this.cboNPP.Location = new System.Drawing.Point(369, 88);
            this.cboNPP.Name = "cboNPP";
            this.cboNPP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNPP.Size = new System.Drawing.Size(250, 20);
            this.cboNPP.TabIndex = 38;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(369, 59);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(250, 20);
            this.txtTenSP.TabIndex = 37;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(369, 31);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(250, 20);
            this.txtMaSP.TabIndex = 36;
            // 
            // radTheLoai
            // 
            this.radTheLoai.AutoSize = true;
            this.radTheLoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheLoai.Location = new System.Drawing.Point(216, 146);
            this.radTheLoai.Name = "radTheLoai";
            this.radTheLoai.Size = new System.Drawing.Size(72, 20);
            this.radTheLoai.TabIndex = 32;
            this.radTheLoai.TabStop = true;
            this.radTheLoai.Text = "Thể loại";
            this.radTheLoai.UseVisualStyleBackColor = true;
            this.radTheLoai.CheckedChanged += new System.EventHandler(this.radTheLoai_CheckedChanged);
            // 
            // radTenDV
            // 
            this.radTenDV.AutoSize = true;
            this.radTenDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenDV.Location = new System.Drawing.Point(216, 117);
            this.radTenDV.Name = "radTenDV";
            this.radTenDV.Size = new System.Drawing.Size(95, 20);
            this.radTenDV.TabIndex = 31;
            this.radTenDV.TabStop = true;
            this.radTenDV.Text = "Tên Dịch Vụ";
            this.radTenDV.UseVisualStyleBackColor = true;
            this.radTenDV.CheckedChanged += new System.EventHandler(this.radTenTG_CheckedChanged);
            // 
            // radTenNPP
            // 
            this.radTenNPP.AutoSize = true;
            this.radTenNPP.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenNPP.Location = new System.Drawing.Point(216, 88);
            this.radTenNPP.Name = "radTenNPP";
            this.radTenNPP.Size = new System.Drawing.Size(132, 20);
            this.radTenNPP.TabIndex = 30;
            this.radTenNPP.TabStop = true;
            this.radTenNPP.Text = "Tên nhà Phân Phối";
            this.radTenNPP.UseVisualStyleBackColor = true;
            this.radTenNPP.CheckedChanged += new System.EventHandler(this.radTenNXB_CheckedChanged);
            // 
            // radTenSP
            // 
            this.radTenSP.AutoSize = true;
            this.radTenSP.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenSP.Location = new System.Drawing.Point(216, 59);
            this.radTenSP.Name = "radTenSP";
            this.radTenSP.Size = new System.Drawing.Size(103, 20);
            this.radTenSP.TabIndex = 29;
            this.radTenSP.TabStop = true;
            this.radTenSP.Text = "Tên sản phẩm";
            this.radTenSP.UseVisualStyleBackColor = true;
            this.radTenSP.CheckedChanged += new System.EventHandler(this.radTenSach_CheckedChanged);
            // 
            // radMaSP
            // 
            this.radMaSP.AutoSize = true;
            this.radMaSP.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaSP.Location = new System.Drawing.Point(216, 31);
            this.radMaSP.Name = "radMaSP";
            this.radMaSP.Size = new System.Drawing.Size(101, 20);
            this.radMaSP.TabIndex = 28;
            this.radMaSP.TabStop = true;
            this.radMaSP.Text = "Mã sản phẩm";
            this.radMaSP.UseVisualStyleBackColor = true;
            this.radMaSP.CheckedChanged += new System.EventHandler(this.radMaSach_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 15);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tìm kiếm thông tin sản phẩm theo:";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QLTV.Properties.Resources.cen2;
            this.btnHuy.Location = new System.Drawing.Point(699, 120);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(126, 36);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = global::QLTV.Properties.Resources.search;
            this.btnTim.Location = new System.Drawing.Point(699, 34);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(126, 36);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvDanhSachSP
            // 
            this.dgvDanhSachSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachSP.Location = new System.Drawing.Point(0, 185);
            this.dgvDanhSachSP.MainView = this.gridView1;
            this.dgvDanhSachSP.Name = "dgvDanhSachSP";
            this.dgvDanhSachSP.Size = new System.Drawing.Size(860, 265);
            this.dgvDanhSachSP.TabIndex = 4;
            this.dgvDanhSachSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSP,
            this.TenSP,
            this.MoTa,
            this.Gia,
            this.SoLuong,
            this.NgayNhapHang,
            this.MaNPP,
            this.MaDV,
            this.MaTL,
            this.TinhTrang});
            this.gridView1.GridControl = this.dgvDanhSachSP;
            this.gridView1.Name = "gridView1";
            // 
            // MaSP
            // 
            this.MaSP.Caption = "Mã Sản Phẩm";
            this.MaSP.FieldName = "MaSP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Visible = true;
            this.MaSP.VisibleIndex = 0;
            // 
            // TenSP
            // 
            this.TenSP.Caption = "Tên Sản Phẩm";
            this.TenSP.FieldName = "TenSP";
            this.TenSP.Name = "TenSP";
            this.TenSP.Visible = true;
            this.TenSP.VisibleIndex = 1;
            // 
            // MoTa
            // 
            this.MoTa.Caption = "Mô Tả SP";
            this.MoTa.FieldName = "MoTa";
            this.MoTa.Name = "MoTa";
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 2;
            // 
            // Gia
            // 
            this.Gia.Caption = "Giá Sản Phẩm";
            this.Gia.FieldName = "Gia";
            this.Gia.Name = "Gia";
            this.Gia.Visible = true;
            this.Gia.VisibleIndex = 3;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 4;
            // 
            // NgayNhapHang
            // 
            this.NgayNhapHang.Caption = "Ngày Nhập Hàng";
            this.NgayNhapHang.FieldName = "NgayNhapHang";
            this.NgayNhapHang.Name = "NgayNhapHang";
            this.NgayNhapHang.Visible = true;
            this.NgayNhapHang.VisibleIndex = 5;
            // 
            // MaNPP
            // 
            this.MaNPP.Caption = "Mã NPP";
            this.MaNPP.FieldName = "MaNPP";
            this.MaNPP.Name = "MaNPP";
            this.MaNPP.Visible = true;
            this.MaNPP.VisibleIndex = 6;
            // 
            // MaDV
            // 
            this.MaDV.Caption = "Mã DV";
            this.MaDV.FieldName = "MaDV";
            this.MaDV.Name = "MaDV";
            this.MaDV.Visible = true;
            this.MaDV.VisibleIndex = 7;
            // 
            // MaTL
            // 
            this.MaTL.Caption = "Mã TL";
            this.MaTL.FieldName = "MaTL";
            this.MaTL.Name = "MaTL";
            this.MaTL.Visible = true;
            this.MaTL.VisibleIndex = 8;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Caption = "Tình Trạng";
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 9;
            // 
            // tkSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDanhSachSP);
            this.Controls.Add(this.groupControl1);
            this.Name = "tkSanPham";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.tkSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNPP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.RadioButton radTheLoai;
        private System.Windows.Forms.RadioButton radTenDV;
        private System.Windows.Forms.RadioButton radTenNPP;
        private System.Windows.Forms.RadioButton radTenSP;
        private System.Windows.Forms.RadioButton radMaSP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHienThi;
        private DevExpress.XtraEditors.LookUpEdit cboTheLoai;
        private DevExpress.XtraEditors.LookUpEdit cboDichVu;
        private DevExpress.XtraEditors.LookUpEdit cboNPP;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        //private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraGrid.GridControl dgvDanhSachSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSP;
        private DevExpress.XtraGrid.Columns.GridColumn TenSP;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhapHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaNPP;
        private DevExpress.XtraGrid.Columns.GridColumn MaDV;
        private DevExpress.XtraGrid.Columns.GridColumn MaTL;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
    }
}
