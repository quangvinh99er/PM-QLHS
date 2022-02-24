namespace QLHSPT
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlhs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlgv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqldiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthongtinhs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunuthongkedshs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudiemtk = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuDanhmuc,
            this.mnuQuanly,
            this.mnutimkiem,
            this.mnuthongke});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLg,
            this.mnuLout,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.mnuExit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(86, 25);
            this.mnuSystem.Text = "Hệ thống";
            // 
            // mnuLg
            // 
            this.mnuLg.Name = "mnuLg";
            this.mnuLg.Size = new System.Drawing.Size(173, 26);
            this.mnuLg.Text = "Đổi mật khẩu";
            this.mnuLg.Click += new System.EventHandler(this.mnuLg_Click);
            // 
            // mnuLout
            // 
            this.mnuLout.Name = "mnuLout";
            this.mnuLout.Size = new System.Drawing.Size(173, 26);
            this.mnuLout.Text = "Đăng xuất";
            this.mnuLout.Click += new System.EventHandler(this.mnuLout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(173, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMonhoc,
            this.mnuLop});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(93, 25);
            this.mnuDanhmuc.Text = "Danh mục";
            // 
            // mnuMonhoc
            // 
            this.mnuMonhoc.Name = "mnuMonhoc";
            this.mnuMonhoc.Size = new System.Drawing.Size(145, 26);
            this.mnuMonhoc.Text = "Môn học ";
            this.mnuMonhoc.Click += new System.EventHandler(this.mnuMonhoc_Click);
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(145, 26);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuQuanly
            // 
            this.mnuQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuqlhs,
            this.mnuqlgv,
            this.mnuqldiem});
            this.mnuQuanly.Name = "mnuQuanly";
            this.mnuQuanly.Size = new System.Drawing.Size(76, 25);
            this.mnuQuanly.Text = "Quản lý";
            // 
            // mnuqlhs
            // 
            this.mnuqlhs.Name = "mnuqlhs";
            this.mnuqlhs.Size = new System.Drawing.Size(182, 26);
            this.mnuqlhs.Text = "Học sinh";
            this.mnuqlhs.Click += new System.EventHandler(this.mnuqlhs_Click);
            // 
            // mnuqlgv
            // 
            this.mnuqlgv.Name = "mnuqlgv";
            this.mnuqlgv.Size = new System.Drawing.Size(182, 26);
            this.mnuqlgv.Text = "Giáo viên";
            this.mnuqlgv.Click += new System.EventHandler(this.giasoViênToolStripMenuItem_Click);
            // 
            // mnuqldiem
            // 
            this.mnuqldiem.Name = "mnuqldiem";
            this.mnuqldiem.Size = new System.Drawing.Size(182, 26);
            this.mnuqldiem.Text = "Điểm môn học";
            this.mnuqldiem.Click += new System.EventHandler(this.mnuqldiem_Click);
            // 
            // mnutimkiem
            // 
            this.mnutimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuthongtinhs});
            this.mnutimkiem.Name = "mnutimkiem";
            this.mnutimkiem.Size = new System.Drawing.Size(86, 25);
            this.mnutimkiem.Text = "Tìm kiếm";
            // 
            // mnuthongtinhs
            // 
            this.mnuthongtinhs.Name = "mnuthongtinhs";
            this.mnuthongtinhs.Size = new System.Drawing.Size(170, 26);
            this.mnuthongtinhs.Text = "Thông tin HS";
            this.mnuthongtinhs.Click += new System.EventHandler(this.mnuthongtinhs_Click);
            // 
            // mnuthongke
            // 
            this.mnuthongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnunuthongkedshs,
            this.mnudiemtk});
            this.mnuthongke.Name = "mnuthongke";
            this.mnuthongke.Size = new System.Drawing.Size(86, 25);
            this.mnuthongke.Text = "Thống kê";
            this.mnuthongke.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // mnunuthongkedshs
            // 
            this.mnunuthongkedshs.Name = "mnunuthongkedshs";
            this.mnunuthongkedshs.Size = new System.Drawing.Size(268, 26);
            this.mnunuthongkedshs.Text = "Danh sách học sinh";
            this.mnunuthongkedshs.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mnudiemtk
            // 
            this.mnudiemtk.Name = "mnudiemtk";
            this.mnudiemtk.Size = new System.Drawing.Size(268, 26);
            this.mnudiemtk.Text = "Điểm tổng kết của học sinh";
            this.mnudiemtk.Click += new System.EventHandler(this.mnudiemtk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 565);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHS";
            this.Column1.HeaderText = "MaHS";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ Và Tên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "GioiTinh";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "DiaChi";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaLop";
            this.Column6.HeaderText = "MaLop";
            this.Column6.Name = "Column6";
            this.Column6.Width = 70;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(0, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1366, 600);
            this.dataGridView2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(787, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLHSPT.Properties.Resources._20180720_Capture0002_2;
            this.ClientSize = new System.Drawing.Size(845, 594);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản Lý Học Sinh";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLg;
        private System.Windows.Forms.ToolStripMenuItem mnuLout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuMonhoc;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanly;
        private System.Windows.Forms.ToolStripMenuItem mnuqlhs;
        private System.Windows.Forms.ToolStripMenuItem mnuqlgv;
        private System.Windows.Forms.ToolStripMenuItem mnutimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnuthongke;
        private System.Windows.Forms.ToolStripMenuItem mnuqldiem;
        private System.Windows.Forms.ToolStripMenuItem mnuthongtinhs;
        private System.Windows.Forms.ToolStripMenuItem mnunuthongkedshs;
        private System.Windows.Forms.ToolStripMenuItem mnudiemtk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
    }
}