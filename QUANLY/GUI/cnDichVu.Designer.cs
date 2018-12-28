namespace QUANLY.Use_Control
{
    partial class cnDichVu
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
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoTaDV = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dgvDichVu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtMoTaDV);
            this.groupControl1.Controls.Add(this.txtTenDV);
            this.groupControl1.Controls.Add(this.txtMaDV);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(156, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(704, 143);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Điền các Thông tin";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QLTV.Properties.Resources.cen1;
            this.btnHuy.Location = new System.Drawing.Point(589, 98);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 26);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QLTV.Properties.Resources.apply;
            this.btnLuu.Location = new System.Drawing.Point(422, 98);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 26);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(96, 75);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(14, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "(*)";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(96, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "(*)";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(34, 114);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "(*)";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(54, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(174, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = ": Vui lòng nhập đầy đủ các Thông tin";
            // 
            // txtMoTaDV
            // 
            this.txtMoTaDV.Location = new System.Drawing.Point(459, 30);
            this.txtMoTaDV.Name = "txtMoTaDV";
            this.txtMoTaDV.Size = new System.Drawing.Size(210, 20);
            this.txtMoTaDV.TabIndex = 14;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(143, 72);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(210, 20);
            this.txtTenDV.TabIndex = 13;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Enabled = false;
            this.txtMaDV.Location = new System.Drawing.Point(143, 30);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(210, 20);
            this.txtMaDV.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mã Dịch Vụ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Tên Dịch Vụ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(376, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Mô Tả DV";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.Location = new System.Drawing.Point(0, 149);
            this.dgvDichVu.MainView = this.gridView1;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(860, 301);
            this.dgvDichVu.TabIndex = 8;
            this.dgvDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDV,
            this.TenDV,
            this.MoTaDV});
            this.gridView1.GridControl = this.dgvDichVu;
            this.gridView1.Name = "gridView1";
            // 
            // MaDV
            // 
            this.MaDV.Caption = "Mã DV";
            this.MaDV.FieldName = "MaDV";
            this.MaDV.Name = "MaDV";
            this.MaDV.Visible = true;
            this.MaDV.VisibleIndex = 0;
            this.MaDV.Width = 79;
            // 
            // TenDV
            // 
            this.TenDV.Caption = "Tên Dịch Vụ";
            this.TenDV.FieldName = "TenDV";
            this.TenDV.Name = "TenDV";
            this.TenDV.Visible = true;
            this.TenDV.VisibleIndex = 1;
            this.TenDV.Width = 188;
            // 
            // MoTaDV
            // 
            this.MoTaDV.Caption = "Mô Tả Dịch Vụ";
            this.MoTaDV.FieldName = "MoTaDV";
            this.MoTaDV.Name = "MoTaDV";
            this.MoTaDV.Visible = true;
            this.MoTaDV.VisibleIndex = 2;
            this.MoTaDV.Width = 574;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Controls.Add(this.btnSua);
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(150, 143);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = global::QLTV.Properties.Resources.del;
            this.btnXoa.Location = new System.Drawing.Point(35, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 26);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = global::QLTV.Properties.Resources.update;
            this.btnSua.Location = new System.Drawing.Point(35, 67);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 26);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::QLTV.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(35, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 26);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cnDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.groupControl1);
            this.Name = "cnDichVu";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.cnTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMoTaDV;
        private DevExpress.XtraEditors.TextEdit txtTenDV;
        private DevExpress.XtraEditors.TextEdit txtMaDV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl dgvDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDV;
        private DevExpress.XtraGrid.Columns.GridColumn TenDV;
        private DevExpress.XtraGrid.Columns.GridColumn MoTaDV;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}
