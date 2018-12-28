namespace QUANLY.GUI
{
    partial class tkKhachHang
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
            this.dgvKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLamThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.radDiaChi = new System.Windows.Forms.RadioButton();
            this.radTenKH = new System.Windows.Forms.RadioButton();
            this.radMaKH = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHienThi = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 138);
            this.dgvKhachHang.MainView = this.gridView1;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(860, 312);
            this.dgvKhachHang.TabIndex = 1;
            this.dgvKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKH,
            this.TenKH,
            this.EmailKH,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChiKH,
            this.DienThoaiKH,
            this.NgayLamThe,
            this.NgayHetHan,
            this.HoatDong});
            this.gridView1.GridControl = this.dgvKhachHang;
            this.gridView1.Name = "gridView1";
            // 
            // MaKH
            // 
            this.MaKH.Caption = "Mã KH";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 0;
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Tên KH";
            this.TenKH.FieldName = "HoTenKH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 1;
            // 
            // EmailKH
            // 
            this.EmailKH.Caption = "Email KH";
            this.EmailKH.FieldName = "EmailKH";
            this.EmailKH.Name = "EmailKH";
            this.EmailKH.Visible = true;
            this.EmailKH.VisibleIndex = 2;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinhKH";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 3;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.FieldName = "NgaySinhKH";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 4;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.Caption = "Địa Chỉ KH";
            this.DiaChiKH.FieldName = "DiaChiKH";
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.Visible = true;
            this.DiaChiKH.VisibleIndex = 5;
            // 
            // DienThoaiKH
            // 
            this.DienThoaiKH.Caption = "Điện Thoại KH";
            this.DienThoaiKH.FieldName = "DienThoaiKH";
            this.DienThoaiKH.Name = "DienThoaiKH";
            this.DienThoaiKH.Visible = true;
            this.DienThoaiKH.VisibleIndex = 6;
            // 
            // NgayLamThe
            // 
            this.NgayLamThe.Caption = "Ngày Làm Thẻ";
            this.NgayLamThe.FieldName = "NgayLamThe";
            this.NgayLamThe.Name = "NgayLamThe";
            this.NgayLamThe.Visible = true;
            this.NgayLamThe.VisibleIndex = 7;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.Caption = "Ngày Hết Hạn";
            this.NgayHetHan.FieldName = "NgayHetHan";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.Visible = true;
            this.NgayHetHan.VisibleIndex = 8;
            // 
            // HoatDong
            // 
            this.HoatDong.Caption = "Hoạt Động";
            this.HoatDong.FieldName = "HoatDong";
            this.HoatDong.Name = "HoatDong";
            this.HoatDong.Visible = true;
            this.HoatDong.VisibleIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtTenKH);
            this.groupControl1.Controls.Add(this.txtMaKH);
            this.groupControl1.Controls.Add(this.radDiaChi);
            this.groupControl1.Controls.Add(this.radTenKH);
            this.groupControl1.Controls.Add(this.radMaKH);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnHienThi);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnTim);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(860, 132);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Nhập các thông tin";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(350, 102);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(271, 20);
            this.txtDiaChi.TabIndex = 52;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(350, 66);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(271, 20);
            this.txtTenKH.TabIndex = 51;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(350, 30);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(271, 20);
            this.txtMaKH.TabIndex = 50;
            // 
            // radDiaChi
            // 
            this.radDiaChi.AutoSize = true;
            this.radDiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDiaChi.Location = new System.Drawing.Point(226, 102);
            this.radDiaChi.Name = "radDiaChi";
            this.radDiaChi.Size = new System.Drawing.Size(66, 20);
            this.radDiaChi.TabIndex = 49;
            this.radDiaChi.TabStop = true;
            this.radDiaChi.Text = "Địa chỉ";
            this.radDiaChi.UseVisualStyleBackColor = true;
            this.radDiaChi.CheckedChanged += new System.EventHandler(this.radDiaChi_CheckedChanged);
            // 
            // radTenKH
            // 
            this.radTenKH.AutoSize = true;
            this.radTenKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenKH.Location = new System.Drawing.Point(226, 66);
            this.radTenKH.Name = "radTenKH";
            this.radTenKH.Size = new System.Drawing.Size(120, 20);
            this.radTenKH.TabIndex = 47;
            this.radTenKH.TabStop = true;
            this.radTenKH.Text = "Tên Khách Hàng";
            this.radTenKH.UseVisualStyleBackColor = true;
            this.radTenKH.CheckedChanged += new System.EventHandler(this.radTenDG_CheckedChanged);
            // 
            // radMaKH
            // 
            this.radMaKH.AutoSize = true;
            this.radMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaKH.Location = new System.Drawing.Point(226, 33);
            this.radMaKH.Name = "radMaKH";
            this.radMaKH.Size = new System.Drawing.Size(118, 20);
            this.radMaKH.TabIndex = 46;
            this.radMaKH.TabStop = true;
            this.radMaKH.Text = "Mã Khách Hàng";
            this.radMaKH.UseVisualStyleBackColor = true;
            this.radMaKH.CheckedChanged += new System.EventHandler(this.radMaDG_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 15);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Tìm kiếm thông tin khách hàng theo:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Appearance.Options.UseFont = true;
            this.btnHienThi.ImageOptions.Image = global::QLTV.Properties.Resources.search_all;
            this.btnHienThi.Location = new System.Drawing.Point(696, 62);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(116, 26);
            this.btnHienThi.TabIndex = 44;
            this.btnHienThi.Text = "Hiển thị Tất cả";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QLTV.Properties.Resources.cen1;
            this.btnHuy.Location = new System.Drawing.Point(696, 96);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 26);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = global::QLTV.Properties.Resources.search_16;
            this.btnTim.Location = new System.Drawing.Point(696, 28);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(116, 26);
            this.btnTim.TabIndex = 42;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // tkKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "tkKhachHang";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.tkDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn EmailKH;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiKH;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiKH;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLamThe;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn HoatDong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private System.Windows.Forms.RadioButton radDiaChi;
        private System.Windows.Forms.RadioButton radTenKH;
        private System.Windows.Forms.RadioButton radMaKH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHienThi;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnTim;
    }
}
