namespace QUANLY.Use_Control
{
    partial class ttNXB
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
            this.dgvNPP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiNPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiNPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Website = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNPP
            // 
            this.dgvNPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNPP.Location = new System.Drawing.Point(0, 0);
            this.dgvNPP.MainView = this.gridView1;
            this.dgvNPP.Name = "dgvNPP";
            this.dgvNPP.Size = new System.Drawing.Size(860, 450);
            this.dgvNPP.TabIndex = 0;
            this.dgvNPP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNPP,
            this.TenNPP,
            this.DiaChiNPP,
            this.DienThoaiNPP,
            this.Website});
            this.gridView1.GridControl = this.dgvNPP;
            this.gridView1.Name = "gridView1";
            // 
            // MaNPP
            // 
            this.MaNPP.Caption = "Mã Nhà PP";
            this.MaNPP.FieldName = "MaNPP";
            this.MaNPP.Name = "MaNPP";
            this.MaNPP.Visible = true;
            this.MaNPP.VisibleIndex = 0;
            // 
            // TenNPP
            // 
            this.TenNPP.Caption = "Tên Nhà PP";
            this.TenNPP.FieldName = "TenNPP";
            this.TenNPP.Name = "TenNPP";
            this.TenNPP.Visible = true;
            this.TenNPP.VisibleIndex = 1;
            // 
            // DiaChiNPP
            // 
            this.DiaChiNPP.Caption = "Địa Chỉ NPP";
            this.DiaChiNPP.FieldName = "DiaChiNPP";
            this.DiaChiNPP.Name = "DiaChiNPP";
            this.DiaChiNPP.Visible = true;
            this.DiaChiNPP.VisibleIndex = 2;
            // 
            // DienThoaiNPP
            // 
            this.DienThoaiNPP.Caption = "Điện Thoại NPP";
            this.DienThoaiNPP.FieldName = "DienThoaiNPP";
            this.DienThoaiNPP.Name = "DienThoaiNPP";
            this.DienThoaiNPP.Visible = true;
            this.DienThoaiNPP.VisibleIndex = 3;
            // 
            // Website
            // 
            this.Website.Caption = "Website";
            this.Website.FieldName = "Website";
            this.Website.Name = "Website";
            this.Website.Visible = true;
            this.Website.VisibleIndex = 4;
            // 
            // ttNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvNPP);
            this.Name = "ttNXB";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.ttNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvNPP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNPP;
        private DevExpress.XtraGrid.Columns.GridColumn TenNPP;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiNPP;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiNPP;
        private DevExpress.XtraGrid.Columns.GridColumn Website;
    }
}
