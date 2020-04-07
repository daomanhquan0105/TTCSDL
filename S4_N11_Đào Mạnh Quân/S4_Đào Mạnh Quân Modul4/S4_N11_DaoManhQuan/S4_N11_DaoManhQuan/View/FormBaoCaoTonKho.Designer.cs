namespace S4_N11_DaoManhQuan.View
{
    partial class FormBaoCaoTonKho
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
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.DTEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTBegin = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataBaoCao = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LbCuoiKy = new System.Windows.Forms.Label();
            this.LbSLXuat = new System.Windows.Forms.Label();
            this.LbSLNhap = new System.Windows.Forms.Label();
            this.LbDauKy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBaoCao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCao)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1128, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Tồn Kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BtnTimKiem);
            this.panel2.Controls.Add(this.DTEnd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DTBegin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 157);
            this.panel2.TabIndex = 2;
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnTimKiem.ForeColor = System.Drawing.Color.White;
            this.BtnTimKiem.Location = new System.Drawing.Point(440, 89);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(176, 47);
            this.BtnTimKiem.TabIndex = 4;
            this.BtnTimKiem.Text = "Tìm Kiếm";
            this.BtnTimKiem.UseVisualStyleBackColor = false;
            this.BtnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // DTEnd
            // 
            this.DTEnd.CustomFormat = "yyyy/MM/dd";
            this.DTEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTEnd.Location = new System.Drawing.Point(739, 20);
            this.DTEnd.Name = "DTEnd";
            this.DTEnd.Size = new System.Drawing.Size(234, 36);
            this.DTEnd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(525, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Kết Thúc: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Bắt Đầu:";
            // 
            // DTBegin
            // 
            this.DTBegin.CustomFormat = "yyyy/MM/dd";
            this.DTBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTBegin.Location = new System.Drawing.Point(209, 20);
            this.DTBegin.Name = "DTBegin";
            this.DTBegin.Size = new System.Drawing.Size(234, 36);
            this.DTBegin.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataBaoCao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 333);
            this.panel3.TabIndex = 3;
            // 
            // DataBaoCao
            // 
            this.DataBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DataBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataBaoCao.Location = new System.Drawing.Point(0, 0);
            this.DataBaoCao.Name = "DataBaoCao";
            this.DataBaoCao.RowHeadersWidth = 51;
            this.DataBaoCao.RowTemplate.Height = 24;
            this.DataBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataBaoCao.Size = new System.Drawing.Size(1128, 333);
            this.DataBaoCao.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.LbCuoiKy);
            this.panel4.Controls.Add(this.LbSLXuat);
            this.panel4.Controls.Add(this.LbSLNhap);
            this.panel4.Controls.Add(this.LbDauKy);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 560);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1128, 60);
            this.panel4.TabIndex = 4;
            // 
            // LbCuoiKy
            // 
            this.LbCuoiKy.AutoSize = true;
            this.LbCuoiKy.Location = new System.Drawing.Point(1007, 13);
            this.LbCuoiKy.Name = "LbCuoiKy";
            this.LbCuoiKy.Size = new System.Drawing.Size(98, 29);
            this.LbCuoiKy.TabIndex = 14;
            this.LbCuoiKy.Text = "Cuối kỳ";
            // 
            // LbSLXuat
            // 
            this.LbSLXuat.AutoSize = true;
            this.LbSLXuat.Location = new System.Drawing.Point(832, 13);
            this.LbSLXuat.Name = "LbSLXuat";
            this.LbSLXuat.Size = new System.Drawing.Size(103, 29);
            this.LbSLXuat.TabIndex = 13;
            this.LbSLXuat.Text = "SL Xuất";
            // 
            // LbSLNhap
            // 
            this.LbSLNhap.AutoSize = true;
            this.LbSLNhap.Location = new System.Drawing.Point(690, 14);
            this.LbSLNhap.Name = "LbSLNhap";
            this.LbSLNhap.Size = new System.Drawing.Size(111, 29);
            this.LbSLNhap.TabIndex = 12;
            this.LbSLNhap.Text = "SL Nhập";
            // 
            // LbDauKy
            // 
            this.LbDauKy.AutoSize = true;
            this.LbDauKy.Location = new System.Drawing.Point(548, 14);
            this.LbDauKy.Name = "LbDauKy";
            this.LbDauKy.Size = new System.Drawing.Size(96, 29);
            this.LbDauKy.TabIndex = 11;
            this.LbDauKy.Text = "Đầu Kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng Số Lượng Sản Phẩm Trong Kỳ: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.BtnBaoCao);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 620);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1128, 127);
            this.panel5.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(900, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "Quay Lại";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(131, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBaoCao
            // 
            this.BtnBaoCao.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnBaoCao.ForeColor = System.Drawing.Color.White;
            this.BtnBaoCao.Location = new System.Drawing.Point(506, 42);
            this.BtnBaoCao.Name = "BtnBaoCao";
            this.BtnBaoCao.Size = new System.Drawing.Size(176, 47);
            this.BtnBaoCao.TabIndex = 6;
            this.BtnBaoCao.Text = "Print";
            this.BtnBaoCao.UseVisualStyleBackColor = false;
            this.BtnBaoCao.Click += new System.EventHandler(this.BtnBaoCao_Click);
            // 
            // FormBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1128, 747);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormBaoCaoTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaoCaoTonKho";
            this.Load += new System.EventHandler(this.FormBaoCaoTonKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBaoCao)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.DateTimePicker DTEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTBegin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LbCuoiKy;
        private System.Windows.Forms.Label LbSLXuat;
        private System.Windows.Forms.Label LbSLNhap;
        private System.Windows.Forms.Label LbDauKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnBaoCao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}