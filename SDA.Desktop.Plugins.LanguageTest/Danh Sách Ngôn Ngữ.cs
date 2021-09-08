using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDA.Desktop.Plugins.LanguageTest
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txt_maNgonNgu.Text = null;
            txt_search.Text = null;
            txt_tenNgonNgu.Text = null;
            cb_ngonNguCS.Checked = false;
            txt_maNgonNgu.Enabled = false;
            txt_tenNgonNgu.Enabled = false;
            cb_ngonNguCS.Enabled = false;
            btn_Them.Enabled = false;
            btn_Luu.Enabled = false;
        }
        public void LamMoi()
        {
            txt_maNgonNgu.Text = null;
            txt_search.Text = null;
            txt_tenNgonNgu.Text = null;
            cb_ngonNguCS.Checked = true;
            txt_maNgonNgu.Enabled = true;
            txt_tenNgonNgu.Enabled = true;
            cb_ngonNguCS.Enabled = true;
            btn_Them.Enabled = true;
        }
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            Reset();
        }

    }
}
