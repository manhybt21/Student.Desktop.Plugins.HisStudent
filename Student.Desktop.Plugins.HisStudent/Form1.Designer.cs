
namespace Student.Desktop.Plugins.HisStudent
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_masinhvien = new DevExpress.XtraEditors.TextEdit();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_maSinhVien = new System.Windows.Forms.Label();
            this.rad_false = new System.Windows.Forms.RadioButton();
            this.lbl_ghiChu = new System.Windows.Forms.Label();
            this.rad_True = new System.Windows.Forms.RadioButton();
            this.lbl_thanhTichHocTap = new System.Windows.Forms.Label();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.lbl_hoVaTen = new System.Windows.Forms.Label();
            this.txt_thanhTichHocTap = new System.Windows.Forms.TextBox();
            this.lbl_doiTuong = new System.Windows.Forms.Label();
            this.txt_hoVaTen = new System.Windows.Forms.TextBox();
            this.lbl_hoNgheo = new System.Windows.Forms.Label();
            this.dlu_doituong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridDataStudent = new DevExpress.XtraGrid.GridControl();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDataStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaSinhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHovaTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldoiTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoNgheo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthanhTich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colghiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_masinhvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlu_doituong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(754, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(526, 564);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Sinh Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_masinhvien);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_lamMoi);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.lbl_maSinhVien);
            this.panel1.Controls.Add(this.rad_false);
            this.panel1.Controls.Add(this.lbl_ghiChu);
            this.panel1.Controls.Add(this.rad_True);
            this.panel1.Controls.Add(this.lbl_thanhTichHocTap);
            this.panel1.Controls.Add(this.txt_ghiChu);
            this.panel1.Controls.Add(this.lbl_hoVaTen);
            this.panel1.Controls.Add(this.txt_thanhTichHocTap);
            this.panel1.Controls.Add(this.lbl_doiTuong);
            this.panel1.Controls.Add(this.txt_hoVaTen);
            this.panel1.Controls.Add(this.lbl_hoNgheo);
            this.panel1.Controls.Add(this.dlu_doituong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 528);
            this.panel1.TabIndex = 0;
            // 
            // txt_masinhvien
            // 
            this.txt_masinhvien.Enabled = false;
            this.txt_masinhvien.Location = new System.Drawing.Point(212, 39);
            this.txt_masinhvien.Name = "txt_masinhvien";
            this.txt_masinhvien.Size = new System.Drawing.Size(220, 28);
            this.txt_masinhvien.TabIndex = 50;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(408, 440);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 39);
            this.btn_xoa.TabIndex = 49;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(9, 440);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(104, 39);
            this.btn_lamMoi.TabIndex = 48;
            this.btn_lamMoi.Text = "Làm Mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(274, 440);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 39);
            this.btn_Sua.TabIndex = 47;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(142, 440);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(104, 39);
            this.btn_Them.TabIndex = 46;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_maSinhVien
            // 
            this.lbl_maSinhVien.AutoSize = true;
            this.lbl_maSinhVien.ForeColor = System.Drawing.Color.Black;
            this.lbl_maSinhVien.Location = new System.Drawing.Point(58, 44);
            this.lbl_maSinhVien.Name = "lbl_maSinhVien";
            this.lbl_maSinhVien.Size = new System.Drawing.Size(97, 19);
            this.lbl_maSinhVien.TabIndex = 35;
            this.lbl_maSinhVien.Text = "Mã sinh viên";
            // 
            // rad_false
            // 
            this.rad_false.AutoSize = true;
            this.rad_false.Location = new System.Drawing.Point(214, 208);
            this.rad_false.Name = "rad_false";
            this.rad_false.Size = new System.Drawing.Size(79, 23);
            this.rad_false.TabIndex = 45;
            this.rad_false.TabStop = true;
            this.rad_false.Text = "Không";
            this.rad_false.UseVisualStyleBackColor = true;
            // 
            // lbl_ghiChu
            // 
            this.lbl_ghiChu.AutoSize = true;
            this.lbl_ghiChu.ForeColor = System.Drawing.Color.Black;
            this.lbl_ghiChu.Location = new System.Drawing.Point(92, 319);
            this.lbl_ghiChu.Name = "lbl_ghiChu";
            this.lbl_ghiChu.Size = new System.Drawing.Size(63, 19);
            this.lbl_ghiChu.TabIndex = 36;
            this.lbl_ghiChu.Text = "Ghi chú";
            // 
            // rad_True
            // 
            this.rad_True.AutoSize = true;
            this.rad_True.Location = new System.Drawing.Point(374, 205);
            this.rad_True.Name = "rad_True";
            this.rad_True.Size = new System.Drawing.Size(53, 23);
            this.rad_True.TabIndex = 44;
            this.rad_True.TabStop = true;
            this.rad_True.Text = "Có";
            this.rad_True.UseVisualStyleBackColor = true;
            // 
            // lbl_thanhTichHocTap
            // 
            this.lbl_thanhTichHocTap.AutoSize = true;
            this.lbl_thanhTichHocTap.ForeColor = System.Drawing.Color.Black;
            this.lbl_thanhTichHocTap.Location = new System.Drawing.Point(15, 265);
            this.lbl_thanhTichHocTap.Name = "lbl_thanhTichHocTap";
            this.lbl_thanhTichHocTap.Size = new System.Drawing.Size(141, 19);
            this.lbl_thanhTichHocTap.TabIndex = 37;
            this.lbl_thanhTichHocTap.Text = "Thành tích học tập";
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Location = new System.Drawing.Point(213, 316);
            this.txt_ghiChu.Multiline = true;
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(220, 98);
            this.txt_ghiChu.TabIndex = 43;
            // 
            // lbl_hoVaTen
            // 
            this.lbl_hoVaTen.AutoSize = true;
            this.lbl_hoVaTen.ForeColor = System.Drawing.Color.Black;
            this.lbl_hoVaTen.Location = new System.Drawing.Point(78, 99);
            this.lbl_hoVaTen.Name = "lbl_hoVaTen";
            this.lbl_hoVaTen.Size = new System.Drawing.Size(77, 19);
            this.lbl_hoVaTen.TabIndex = 38;
            this.lbl_hoVaTen.Text = "Họ và tên";
            // 
            // txt_thanhTichHocTap
            // 
            this.txt_thanhTichHocTap.Location = new System.Drawing.Point(214, 262);
            this.txt_thanhTichHocTap.Name = "txt_thanhTichHocTap";
            this.txt_thanhTichHocTap.Size = new System.Drawing.Size(220, 27);
            this.txt_thanhTichHocTap.TabIndex = 42;
            // 
            // lbl_doiTuong
            // 
            this.lbl_doiTuong.AutoSize = true;
            this.lbl_doiTuong.ForeColor = System.Drawing.Color.Black;
            this.lbl_doiTuong.Location = new System.Drawing.Point(76, 153);
            this.lbl_doiTuong.Name = "lbl_doiTuong";
            this.lbl_doiTuong.Size = new System.Drawing.Size(80, 19);
            this.lbl_doiTuong.TabIndex = 39;
            this.lbl_doiTuong.Text = "Đối tượng";
            // 
            // txt_hoVaTen
            // 
            this.txt_hoVaTen.Location = new System.Drawing.Point(213, 98);
            this.txt_hoVaTen.Name = "txt_hoVaTen";
            this.txt_hoVaTen.Size = new System.Drawing.Size(220, 27);
            this.txt_hoVaTen.TabIndex = 41;
            // 
            // lbl_hoNgheo
            // 
            this.lbl_hoNgheo.AutoSize = true;
            this.lbl_hoNgheo.ForeColor = System.Drawing.Color.Black;
            this.lbl_hoNgheo.Location = new System.Drawing.Point(76, 209);
            this.lbl_hoNgheo.Name = "lbl_hoNgheo";
            this.lbl_hoNgheo.Size = new System.Drawing.Size(78, 19);
            this.lbl_hoNgheo.TabIndex = 40;
            this.lbl_hoNgheo.Text = "Hộ nghèo";
            // 
            // dlu_doituong
            // 
            this.dlu_doituong.EditValue = "chọn loại đối tượng";
            this.dlu_doituong.Location = new System.Drawing.Point(214, 151);
            this.dlu_doituong.Name = "dlu_doituong";
            this.dlu_doituong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dlu_doituong.Properties.Items.AddRange(new object[] {
            "Miễn Giảm",
            "Miễm Giảm 1 Nửa",
            "Không Miễn Giảm"});
            this.dlu_doituong.Properties.NullText = "[EditValue is null]";
            this.dlu_doituong.Properties.PopupSizeable = true;
            this.dlu_doituong.Size = new System.Drawing.Size(220, 28);
            this.dlu_doituong.TabIndex = 34;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // gridDataStudent
            // 
            this.gridDataStudent.DataSource = this.studentBindingSource1;
            this.gridDataStudent.Location = new System.Drawing.Point(4, 0);
            this.gridDataStudent.MainView = this.gridViewDataStudent;
            this.gridDataStudent.Name = "gridDataStudent";
            this.gridDataStudent.Size = new System.Drawing.Size(744, 562);
            this.gridDataStudent.TabIndex = 19;
            this.gridDataStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDataStudent});
            // 
            // gridViewDataStudent
            // 
            this.gridViewDataStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colmaSinhVien,
            this.colHovaTen,
            this.coldoiTuong,
            this.colhoNgheo,
            this.colthanhTich,
            this.colghiChu});
            this.gridViewDataStudent.GridControl = this.gridDataStudent;
            this.gridViewDataStudent.Name = "gridViewDataStudent";
            this.gridViewDataStudent.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewDataStudent_RowClick);
            this.gridViewDataStudent.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewDataStudent_RowCellClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 30;
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 112;
            // 
            // colmaSinhVien
            // 
            this.colmaSinhVien.FieldName = "maSinhVien";
            this.colmaSinhVien.MinWidth = 30;
            this.colmaSinhVien.Name = "colmaSinhVien";
            this.colmaSinhVien.Visible = true;
            this.colmaSinhVien.VisibleIndex = 1;
            this.colmaSinhVien.Width = 112;
            // 
            // colHovaTen
            // 
            this.colHovaTen.FieldName = "HovaTen";
            this.colHovaTen.MinWidth = 30;
            this.colHovaTen.Name = "colHovaTen";
            this.colHovaTen.Visible = true;
            this.colHovaTen.VisibleIndex = 2;
            this.colHovaTen.Width = 112;
            // 
            // coldoiTuong
            // 
            this.coldoiTuong.FieldName = "doiTuong";
            this.coldoiTuong.MinWidth = 30;
            this.coldoiTuong.Name = "coldoiTuong";
            this.coldoiTuong.Visible = true;
            this.coldoiTuong.VisibleIndex = 3;
            this.coldoiTuong.Width = 112;
            // 
            // colhoNgheo
            // 
            this.colhoNgheo.FieldName = "hoNgheo";
            this.colhoNgheo.MinWidth = 30;
            this.colhoNgheo.Name = "colhoNgheo";
            this.colhoNgheo.Visible = true;
            this.colhoNgheo.VisibleIndex = 4;
            this.colhoNgheo.Width = 112;
            // 
            // colthanhTich
            // 
            this.colthanhTich.FieldName = "thanhTich";
            this.colthanhTich.MinWidth = 30;
            this.colthanhTich.Name = "colthanhTich";
            this.colthanhTich.Visible = true;
            this.colthanhTich.VisibleIndex = 5;
            this.colthanhTich.Width = 112;
            // 
            // colghiChu
            // 
            this.colghiChu.FieldName = "ghiChu";
            this.colghiChu.MinWidth = 30;
            this.colghiChu.Name = "colghiChu";
            this.colghiChu.Visible = true;
            this.colghiChu.VisibleIndex = 6;
            this.colghiChu.Width = 112;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 564);
            this.Controls.Add(this.gridDataStudent);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_masinhvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlu_doituong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txt_masinhvien;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_maSinhVien;
        private System.Windows.Forms.RadioButton rad_false;
        private System.Windows.Forms.Label lbl_ghiChu;
        private System.Windows.Forms.RadioButton rad_True;
        private System.Windows.Forms.Label lbl_thanhTichHocTap;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.Label lbl_hoVaTen;
        private System.Windows.Forms.TextBox txt_thanhTichHocTap;
        private System.Windows.Forms.Label lbl_doiTuong;
        private System.Windows.Forms.TextBox txt_hoVaTen;
        private System.Windows.Forms.Label lbl_hoNgheo;
        private DevExpress.XtraEditors.ComboBoxEdit dlu_doituong;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.GridControl gridDataStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDataStudent;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colmaSinhVien;
        private DevExpress.XtraGrid.Columns.GridColumn colHovaTen;
        private DevExpress.XtraGrid.Columns.GridColumn coldoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn colhoNgheo;
        private DevExpress.XtraGrid.Columns.GridColumn colthanhTich;
        private DevExpress.XtraGrid.Columns.GridColumn colghiChu;
    }
}

