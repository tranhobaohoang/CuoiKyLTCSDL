namespace QLTV.Use_Control
{
    partial class ttTacGia
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
            this.dgvDichVu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDichVu.MainView = this.gridView1;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(860, 450);
            this.dgvDichVu.TabIndex = 0;
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
            this.MaDV.Caption = "Mã Dịch Vụ";
            this.MaDV.FieldName = "MaDV";
            this.MaDV.Name = "MaDV";
            this.MaDV.Visible = true;
            this.MaDV.VisibleIndex = 0;
            // 
            // TenDV
            // 
            this.TenDV.Caption = "Tên Dịch Vụ";
            this.TenDV.FieldName = "TenDV";
            this.TenDV.Name = "TenDV";
            this.TenDV.Visible = true;
            this.TenDV.VisibleIndex = 1;
            // 
            // MoTaDV
            // 
            this.MoTaDV.Caption = "Mô Tả DV";
            this.MoTaDV.FieldName = "MoTaDV";
            this.MoTaDV.Name = "MoTaDV";
            this.MoTaDV.Visible = true;
            this.MoTaDV.VisibleIndex = 2;
            // 
            // ttTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDichVu);
            this.Name = "ttTacGia";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.ttTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDV;
        private DevExpress.XtraGrid.Columns.GridColumn TenDV;
        private DevExpress.XtraGrid.Columns.GridColumn MoTaDV;
    }
}
