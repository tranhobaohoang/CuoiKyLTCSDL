namespace QLTV.Use_Control
{
    partial class ttDocGia
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
            this.GioiTinhKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinhKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLamThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgvKhachHang.MainView = this.gridView1;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(860, 450);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKH,
            this.TenKH,
            this.EmailKH,
            this.GioiTinhKH,
            this.NgaySinhKH,
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
            // GioiTinhKH
            // 
            this.GioiTinhKH.Caption = "Giới Tính KH";
            this.GioiTinhKH.FieldName = "GioiTinhKH";
            this.GioiTinhKH.Name = "GioiTinhKH";
            this.GioiTinhKH.Visible = true;
            this.GioiTinhKH.VisibleIndex = 3;
            // 
            // NgaySinhKH
            // 
            this.NgaySinhKH.Caption = "Ngày Sinh KH";
            this.NgaySinhKH.FieldName = "NgaySinhKH";
            this.NgaySinhKH.Name = "NgaySinhKH";
            this.NgaySinhKH.Visible = true;
            this.NgaySinhKH.VisibleIndex = 4;
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
            // ttDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "ttDocGia";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.ttDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn EmailKH;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinhKH;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinhKH;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiKH;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiKH;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLamThe;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn HoatDong;
    }
}
