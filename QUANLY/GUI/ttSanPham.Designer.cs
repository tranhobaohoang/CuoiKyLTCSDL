namespace QUANLY.Use_Control
{
    partial class ttSach
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
            this.dgvSanPham = new DevExpress.XtraGrid.GridControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.MainView = this.gridView1;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(860, 450);
            this.dgvSanPham.TabIndex = 3;
            this.dgvSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.dgvSanPham;
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
            this.MoTa.Caption = "Mô Tả";
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
            // ttSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSanPham);
            this.Name = "ttSach";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.ttSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvSanPham;
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
