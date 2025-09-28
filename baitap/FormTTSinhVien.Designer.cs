namespace BaiTap
{
    partial class FormTTSinhVien
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
            this.txtHoTenLot = new System.Windows.Forms.TextBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.ctxtmsMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtCCCD = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDSSV = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTenLot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxtmsSV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmsMonHoc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctxtmsSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHoTenLot
            // 
            this.txtHoTenLot.Location = new System.Drawing.Point(106, 50);
            this.txtHoTenLot.Name = "txtHoTenLot";
            this.txtHoTenLot.Size = new System.Drawing.Size(181, 20);
            this.txtHoTenLot.TabIndex = 1;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(585, 20);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 39;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "MSSV:";
            // 
            // mtxtMaSo
            // 
            this.mtxtMaSo.Location = new System.Drawing.Point(106, 19);
            this.mtxtMaSo.Mask = "0000000";
            this.mtxtMaSo.Name = "mtxtMaSo";
            this.mtxtMaSo.Size = new System.Drawing.Size(181, 20);
            this.mtxtMaSo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Lớp:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(384, 270);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(78, 35);
            this.btnCapNhat.TabIndex = 45;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(106, 143);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(568, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(319, 270);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(53, 35);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK45A",
            "CTK45B",
            "CTK46A",
            "CTK46B",
            "CTK47A",
            "CTK47B",
            "CTK47C"});
            this.cboLop.Location = new System.Drawing.Point(493, 76);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(181, 21);
            this.cboLop.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(571, 270);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(76, 35);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Địa chỉ liên lạc:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Họ và tên lót:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(106, 77);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(181, 20);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMacDinh.ForeColor = System.Drawing.Color.Black;
            this.btnMacDinh.Location = new System.Drawing.Point(475, 270);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(83, 35);
            this.btnMacDinh.TabIndex = 46;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(252, 270);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 35);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Môn học đăng ký:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ngày sinh:";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(493, 20);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.CheckOnClick = true;
            this.clbMonHoc.ColumnWidth = 350;
            this.clbMonHoc.ContextMenuStrip = this.ctxtmsMonHoc;
            this.clbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "Mạng máy tính",
            "Hệ điều hành",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Đồ án cơ sở",
            "Phương pháp NCKH",
            "Lập trình trên thiết bị di động",
            "An toàn và bảo mật hệ thống"});
            this.clbMonHoc.Location = new System.Drawing.Point(106, 170);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(568, 94);
            this.clbMonHoc.TabIndex = 9;
            // 
            // ctxtmsMonHoc
            // 
            this.ctxtmsMonHoc.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxtmsMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMônHọcToolStripMenuItem,
            this.xóaMônHọcToolStripMenuItem});
            this.ctxtmsMonHoc.Name = "contextMenuStrip1";
            this.ctxtmsMonHoc.Size = new System.Drawing.Size(156, 48);
            // 
            // thêmMônHọcToolStripMenuItem
            // 
            this.thêmMônHọcToolStripMenuItem.Name = "thêmMônHọcToolStripMenuItem";
            this.thêmMônHọcToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.thêmMônHọcToolStripMenuItem.Text = "Thêm môn học";
            this.thêmMônHọcToolStripMenuItem.Click += new System.EventHandler(this.thêmMônHọcToolStripMenuItem_Click);
            // 
            // xóaMônHọcToolStripMenuItem
            // 
            this.xóaMônHọcToolStripMenuItem.Name = "xóaMônHọcToolStripMenuItem";
            this.xóaMônHọcToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.xóaMônHọcToolStripMenuItem.Text = "Xóa môn học";
            this.xóaMônHọcToolStripMenuItem.Click += new System.EventHandler(this.xóaMônHọcToolStripMenuItem_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(493, 48);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(181, 20);
            this.txtTen.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tên:";
            // 
            // mtxtCCCD
            // 
            this.mtxtCCCD.Location = new System.Drawing.Point(106, 110);
            this.mtxtCCCD.Mask = "000000000";
            this.mtxtCCCD.Name = "mtxtCCCD";
            this.mtxtCCCD.Size = new System.Drawing.Size(181, 20);
            this.mtxtCCCD.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "CCCD:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Số ĐT:";
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(493, 110);
            this.mtxtSDT.Mask = "0000.000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(181, 20);
            this.mtxtSDT.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(106, 270);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(77, 35);
            this.btnTimKiem.TabIndex = 43;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDSSV);
            this.groupBox1.Location = new System.Drawing.Point(28, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(646, 206);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // lvDSSV
            // 
            this.lvDSSV.CheckBoxes = true;
            this.lvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.HoTenLot,
            this.Ten,
            this.Lop,
            this.NgS,
            this.CCCD,
            this.SDT,
            this.DiaChi,
            this.GioiTinh,
            this.MonHoc});
            this.lvDSSV.ContextMenuStrip = this.ctxtmsSV;
            this.lvDSSV.FullRowSelect = true;
            this.lvDSSV.GridLines = true;
            this.lvDSSV.HideSelection = false;
            this.lvDSSV.Location = new System.Drawing.Point(4, 17);
            this.lvDSSV.Margin = new System.Windows.Forms.Padding(2);
            this.lvDSSV.Name = "lvDSSV";
            this.lvDSSV.Size = new System.Drawing.Size(638, 181);
            this.lvDSSV.TabIndex = 0;
            this.lvDSSV.UseCompatibleStateImageBehavior = false;
            this.lvDSSV.View = System.Windows.Forms.View.Details;
            this.lvDSSV.SelectedIndexChanged += new System.EventHandler(this.lvDSSV_SelectedIndexChanged);
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            // 
            // HoTenLot
            // 
            this.HoTenLot.Text = "Họ và tên lót";
            this.HoTenLot.Width = 121;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên";
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            // 
            // NgS
            // 
            this.NgS.Text = "Ngày sinh";
            this.NgS.Width = 103;
            // 
            // CCCD
            // 
            this.CCCD.Text = "CCCD";
            this.CCCD.Width = 102;
            // 
            // SDT
            // 
            this.SDT.Text = "Số điện thoại";
            this.SDT.Width = 110;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ liên lạc";
            this.DiaChi.Width = 161;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới tính";
            // 
            // MonHoc
            // 
            this.MonHoc.Text = "Môn học đăng ký";
            this.MonHoc.Width = 80;
            // 
            // ctxtmsSV
            // 
            this.ctxtmsSV.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxtmsSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaSinhViênToolStripMenuItem});
            this.ctxtmsSV.Name = "ctxtmsSV";
            this.ctxtmsSV.Size = new System.Drawing.Size(145, 26);
            // 
            // xóaSinhViênToolStripMenuItem
            // 
            this.xóaSinhViênToolStripMenuItem.Name = "xóaSinhViênToolStripMenuItem";
            this.xóaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.xóaSinhViênToolStripMenuItem.Text = "Xóa sinh viên";
            this.xóaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.xóaSinhViênToolStripMenuItem_Click);
            // 
            // FormTTSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoTenLot);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.mtxtCCCD);
            this.Controls.Add(this.mtxtMaSo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTTSinhVien";
            this.Text = "Nhập thông tin sinh viên";
            this.ctxtmsMonHoc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ctxtmsSV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTenLot;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtMaSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtCCCD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDSSV;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader HoTenLot;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader NgS;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.ColumnHeader CCCD;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader MonHoc;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ContextMenuStrip ctxtmsMonHoc;
        private System.Windows.Forms.ToolStripMenuItem thêmMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaMônHọcToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxtmsSV;
        private System.Windows.Forms.ToolStripMenuItem xóaSinhViênToolStripMenuItem;
    }
}

