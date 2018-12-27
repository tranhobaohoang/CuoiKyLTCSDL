﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.BLL;
using QLTV.DTO;

namespace QLTV.Use_Control
{
    public partial class ttDocGia : UserControl
    {
        private KhachHang_BLL dgBUS = new KhachHang_BLL();
        public ttDocGia()
        {
            InitializeComponent();
        }

        private void ttDocGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvKhachHang.DataSource = dgBUS.LayDanhSachKhachHang();
        }
    }
}
