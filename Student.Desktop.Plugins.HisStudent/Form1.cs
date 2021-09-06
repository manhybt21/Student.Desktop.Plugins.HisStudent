using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace Student.Desktop.Plugins.HisStudent
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public StudentEntities _context = new StudentEntities();
        public Form1()

        {

            InitializeComponent();

           
        }
        public void Reset() {
            txt_ghiChu.Enabled = false;
            txt_hoVaTen.Enabled = false;
            txt_thanhTichHocTap.Enabled = false;
            rad_false.Enabled = false;
            rad_True.Enabled = false;
            txt_ghiChu.Enabled = false;
            dlu_doituong.Enabled = false;
            txt_ghiChu.Text = null;
            txt_hoVaTen.Text = null;
            txt_masinhvien.Text = null;
            txt_thanhTichHocTap.Text = null;
            rad_false.Checked = false;
            rad_True.Checked = false;
            btn_Sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_Them.Enabled = false;
            dlu_doituong.EditValue = "chọn loại đối tượng";
            getDataStudent();
        }
        public void RefreshForm()
        {
            txt_ghiChu.Text = null;
            txt_hoVaTen.Text = null;
            txt_masinhvien.Text = null;
            txt_thanhTichHocTap.Text = null;
            rad_false.Checked = false;
            rad_True.Checked = false;
            dlu_doituong.EditValue = "chọn loại đối tượng";
            txt_ghiChu.Enabled = true;
            txt_hoVaTen.Enabled = true;
            txt_thanhTichHocTap.Enabled = true;
            rad_false.Enabled = true;
            rad_True.Enabled = true;
            txt_ghiChu.Enabled = true;
            dlu_doituong.Enabled = true;
            btn_Them.Enabled = true;
        }
        public void unEnable()
        {
            txt_ghiChu.Enabled = true;
            txt_hoVaTen.Enabled = true;
            txt_thanhTichHocTap.Enabled = true;
            rad_false.Enabled = true;
            rad_True.Enabled = true;
            txt_ghiChu.Enabled = true;
            dlu_doituong.Enabled = true;
        }
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            RefreshForm();
            btn_Sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        public void getDataStudent()
        {
            gridDataStudent.DataSource = _context.Student.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getDataStudent();
            Reset();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            var findSt = (from n in _context.Student
                         select n).ToList();
            if (findSt.Count == 0)
            {
                st.maSinhVien = "SV1";
            }
            else {
                var maxID = (from n in _context.Student select n).Max(x => x.id);
                st.maSinhVien = "SV" + (maxID+1).ToString();
            }
            if (txt_hoVaTen.Text == null || txt_thanhTichHocTap.Text == null || dlu_doituong.Text == null ||dlu_doituong.Text=="chọn loại đối tượng") 
            { MessageBox.Show("Mời nhập đẩy đủ thông tin Sinh viên"); }
            else if (rad_false.Checked == false && rad_True.Checked == false)
            {
                MessageBox.Show("Bạn nhập thiếu thông tin");
            }
            else { 
            st.HovaTen = txt_hoVaTen.Text;
            st.doiTuong = dlu_doituong.Text;
            if(rad_false.Checked== true) { st.hoNgheo = "Không"; }
            if (rad_True.Checked == true) { st.hoNgheo = "Có"; }
            st.thanhTich = txt_thanhTichHocTap.Text;
            st.ghiChu = txt_ghiChu.Text;
            _context.Student.Add(st);
            _context.SaveChanges();

                Reset();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var findStudent = (from n in _context.Student
                              where n.maSinhVien == txt_masinhvien.Text
                              select n).FirstOrDefault();
            if (txt_hoVaTen.Text == null || txt_thanhTichHocTap.Text == null || dlu_doituong.Text == null || dlu_doituong.Text == "chọn loại đối tượng")
            { MessageBox.Show("Mời nhập đẩy đủ thông tin Sinh viên"); }
            else if (rad_false.Checked == false && rad_True.Checked == false)
            {
                MessageBox.Show("Bạn nhập thiếu thông tin");
            }
            else { 
            findStudent.HovaTen = txt_hoVaTen.Text;
            findStudent.doiTuong = dlu_doituong.Text;
            findStudent.thanhTich = txt_thanhTichHocTap.Text;
            findStudent.ghiChu = txt_ghiChu.Text;
            if (rad_false.Checked==true)
            {
                findStudent.hoNgheo = "Không";
            }
            if (rad_True.Checked == true)
            {
                findStudent.hoNgheo = "Có";
            }
            if (XtraMessageBox.Show("Bạn có muốn cập nhật bản ghi này không", "Cảnh Báo", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                _context.SaveChanges();
            }
                Reset();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var findStudent = (from n in _context.Student
                               where n.maSinhVien == txt_masinhvien.Text
                               select n).FirstOrDefault();
            if(XtraMessageBox.Show("Bạn có muốn xoá bản ghi này không","Cảnh Báo",MessageBoxButtons.YesNo) != DialogResult.No) {
                _context.Student.Remove(findStudent);
                _context.SaveChanges();
                Reset();
            }
           
        }

        private void gridViewDataStudent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            clickData();
        }

        private void gridViewDataStudent_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            clickData();
        }
        public void clickData()
        {
            txt_masinhvien.Text = gridViewDataStudent.GetFocusedRowCellValue("maSinhVien").ToString();
            txt_hoVaTen.Text = gridViewDataStudent.GetFocusedRowCellValue("HovaTen").ToString();
            txt_thanhTichHocTap.Text = gridViewDataStudent.GetFocusedRowCellValue("thanhTich").ToString();
            if (gridViewDataStudent.GetFocusedRowCellValue("ghiChu").ToString()== null)
            {
                txt_ghiChu.Text = "";
            }
            else
            {
                txt_ghiChu.Text = gridViewDataStudent.GetFocusedRowCellValue("ghiChu").ToString();
            }
            dlu_doituong.Text = gridViewDataStudent.GetFocusedRowCellValue("doiTuong").ToString();
            if (gridViewDataStudent.GetFocusedRowCellValue("hoNgheo").ToString() == "Không")
            {
                rad_false.Checked = true;
            }
            if (gridViewDataStudent.GetFocusedRowCellValue("hoNgheo").ToString() == "Có")
            {
                rad_True.Checked = true;
            }
            btn_Sua.Enabled = true;
             btn_xoa.Enabled = true;
            unEnable();
        }

    }
}
