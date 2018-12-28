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
    public partial class ttTacGia : UserControl
    {
        private DichVu_BLL tgBUS = new DichVu_BLL();
        public ttTacGia()
        {
            InitializeComponent();
        }

        private void ttTacGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvDichVu.DataSource = tgBUS.LayDanhSachDichVu();
        }
    }
}
