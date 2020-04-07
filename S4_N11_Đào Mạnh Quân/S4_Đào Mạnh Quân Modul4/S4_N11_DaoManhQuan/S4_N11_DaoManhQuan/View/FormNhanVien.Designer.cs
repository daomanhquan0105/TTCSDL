namespace S4_N11_DaoManhQuan.View
{
    partial class FormNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListViewNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.TbTimKiem = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.TbDiaChi = new System.Windows.Forms.TextBox();
            this.TbTen = new System.Windows.Forms.TextBox();
            this.TbHo = new System.Windows.Forms.TextBox();
            this.TbMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnGioiTinh = new System.Windows.Forms.Panel();
            this.RadNu = new System.Windows.Forms.RadioButton();
            this.RadNam = new System.Windows.Forms.RadioButton();
            this.CbPhongBan = new System.Windows.Forms.ComboBox();
            this.DTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.TbLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.PnGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1121, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 336);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListViewNhanVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // ListViewNhanVien
            // 
            this.ListViewNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ListViewNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewNhanVien.FullRowSelect = true;
            this.ListViewNhanVien.GridLines = true;
            this.ListViewNhanVien.HideSelection = false;
            this.ListViewNhanVien.Location = new System.Drawing.Point(3, 32);
            this.ListViewNhanVien.Name = "ListViewNhanVien";
            this.ListViewNhanVien.Size = new System.Drawing.Size(1115, 301);
            this.ListViewNhanVien.TabIndex = 0;
            this.ListViewNhanVien.UseCompatibleStateImageBehavior = false;
            this.ListViewNhanVien.View = System.Windows.Forms.View.Details;
            this.ListViewNhanVien.SelectedIndexChanged += new System.EventHandler(this.ListViewNhanVien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 193;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 157;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa Chỉ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giới tính";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày Sinh";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lương";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 157;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã Phòng Ban";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 185;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 436);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 328);
            this.panel3.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1118, 328);
            this.splitContainer1.SplitterDistance = 72;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.BtnXoa);
            this.splitContainer2.Panel1.Controls.Add(this.BtnSua);
            this.splitContainer2.Panel1.Controls.Add(this.BtnThem);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TbTimKiem);
            this.splitContainer2.Size = new System.Drawing.Size(1118, 72);
            this.splitContainer2.SplitterDistance = 531;
            this.splitContainer2.TabIndex = 0;
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnXoa.ForeColor = System.Drawing.Color.Blue;
            this.BtnXoa.Location = new System.Drawing.Point(348, 10);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(119, 42);
            this.BtnXoa.TabIndex = 5;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSua.ForeColor = System.Drawing.Color.Blue;
            this.BtnSua.Location = new System.Drawing.Point(186, 10);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(119, 42);
            this.BtnSua.TabIndex = 4;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = false;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnThem.ForeColor = System.Drawing.Color.Blue;
            this.BtnThem.Location = new System.Drawing.Point(21, 10);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(119, 42);
            this.BtnThem.TabIndex = 3;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // TbTimKiem
            // 
            this.TbTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbTimKiem.Location = new System.Drawing.Point(65, 15);
            this.TbTimKiem.Name = "TbTimKiem";
            this.TbTimKiem.Size = new System.Drawing.Size(480, 36);
            this.TbTimKiem.TabIndex = 1;
            this.TbTimKiem.Text = "Tìm Kiếm Tên Nhân viên";
            this.TbTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbTimKiem_MouseClick);
            this.TbTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTimKiem_KeyPress);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.TbDiaChi);
            this.splitContainer3.Panel1.Controls.Add(this.TbTen);
            this.splitContainer3.Panel1.Controls.Add(this.TbHo);
            this.splitContainer3.Panel1.Controls.Add(this.TbMaNV);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.PnGioiTinh);
            this.splitContainer3.Panel2.Controls.Add(this.CbPhongBan);
            this.splitContainer3.Panel2.Controls.Add(this.DTNgaySinh);
            this.splitContainer3.Panel2.Controls.Add(this.TbLuong);
            this.splitContainer3.Panel2.Controls.Add(this.label7);
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Panel2.Controls.Add(this.label9);
            this.splitContainer3.Panel2.Controls.Add(this.label10);
            this.splitContainer3.Size = new System.Drawing.Size(1118, 252);
            this.splitContainer3.SplitterDistance = 530;
            this.splitContainer3.TabIndex = 0;
            // 
            // TbDiaChi
            // 
            this.TbDiaChi.Location = new System.Drawing.Point(151, 186);
            this.TbDiaChi.Name = "TbDiaChi";
            this.TbDiaChi.Size = new System.Drawing.Size(299, 36);
            this.TbDiaChi.TabIndex = 13;
            // 
            // TbTen
            // 
            this.TbTen.Location = new System.Drawing.Point(151, 137);
            this.TbTen.Name = "TbTen";
            this.TbTen.Size = new System.Drawing.Size(299, 36);
            this.TbTen.TabIndex = 12;
            // 
            // TbHo
            // 
            this.TbHo.Location = new System.Drawing.Point(151, 75);
            this.TbHo.Name = "TbHo";
            this.TbHo.Size = new System.Drawing.Size(299, 36);
            this.TbHo.TabIndex = 11;
            // 
            // TbMaNV
            // 
            this.TbMaNV.Location = new System.Drawing.Point(151, 19);
            this.TbMaNV.Name = "TbMaNV";
            this.TbMaNV.Size = new System.Drawing.Size(299, 36);
            this.TbMaNV.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa Chỉ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã NV: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Họ: ";
            // 
            // PnGioiTinh
            // 
            this.PnGioiTinh.Controls.Add(this.RadNu);
            this.PnGioiTinh.Controls.Add(this.RadNam);
            this.PnGioiTinh.Location = new System.Drawing.Point(193, 3);
            this.PnGioiTinh.Name = "PnGioiTinh";
            this.PnGioiTinh.Size = new System.Drawing.Size(299, 48);
            this.PnGioiTinh.TabIndex = 20;
            // 
            // RadNu
            // 
            this.RadNu.AutoSize = true;
            this.RadNu.ForeColor = System.Drawing.Color.White;
            this.RadNu.Location = new System.Drawing.Point(208, 12);
            this.RadNu.Name = "RadNu";
            this.RadNu.Size = new System.Drawing.Size(66, 33);
            this.RadNu.TabIndex = 1;
            this.RadNu.TabStop = true;
            this.RadNu.Text = "Nữ";
            this.RadNu.UseVisualStyleBackColor = true;
            // 
            // RadNam
            // 
            this.RadNam.AutoSize = true;
            this.RadNam.ForeColor = System.Drawing.Color.White;
            this.RadNam.Location = new System.Drawing.Point(3, 12);
            this.RadNam.Name = "RadNam";
            this.RadNam.Size = new System.Drawing.Size(88, 33);
            this.RadNam.TabIndex = 0;
            this.RadNam.TabStop = true;
            this.RadNam.Text = "Nam";
            this.RadNam.UseVisualStyleBackColor = true;
            // 
            // CbPhongBan
            // 
            this.CbPhongBan.FormattingEnabled = true;
            this.CbPhongBan.Location = new System.Drawing.Point(193, 186);
            this.CbPhongBan.Name = "CbPhongBan";
            this.CbPhongBan.Size = new System.Drawing.Size(299, 37);
            this.CbPhongBan.TabIndex = 19;
            // 
            // DTNgaySinh
            // 
            this.DTNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.DTNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgaySinh.Location = new System.Drawing.Point(193, 72);
            this.DTNgaySinh.Name = "DTNgaySinh";
            this.DTNgaySinh.Size = new System.Drawing.Size(299, 36);
            this.DTNgaySinh.TabIndex = 18;
            // 
            // TbLuong
            // 
            this.TbLuong.Location = new System.Drawing.Point(193, 137);
            this.TbLuong.Name = "TbLuong";
            this.TbLuong.Size = new System.Drawing.Size(299, 36);
            this.TbLuong.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã PB: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Giới Tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "Lương: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày Sinh: ";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 328);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 764);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.PnGioiTinh.ResumeLayout(false);
            this.PnGioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ListViewNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.TextBox TbTimKiem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox TbDiaChi;
        private System.Windows.Forms.TextBox TbTen;
        private System.Windows.Forms.TextBox TbHo;
        private System.Windows.Forms.TextBox TbMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnGioiTinh;
        private System.Windows.Forms.RadioButton RadNu;
        private System.Windows.Forms.RadioButton RadNam;
        private System.Windows.Forms.ComboBox CbPhongBan;
        private System.Windows.Forms.DateTimePicker DTNgaySinh;
        private System.Windows.Forms.TextBox TbLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Splitter splitter1;
    }
}