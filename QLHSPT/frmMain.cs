using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLHSPT
{
    
    public partial class frmMain : Form
    {
        string Taikhoan = "", Matkhau = "", Quyen = "";

       public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string Taikhoan, string Matkhau, string Quyen)
        {
            InitializeComponent();
            this.Taikhoan = Taikhoan;
            this.Matkhau = Matkhau;
            this.Quyen = Quyen;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;

            dataGridView1.Hide();
            button1.Hide();
            dataGridView1.DataSource = B_TimKiem.GetAllDS();

            dataGridView2.Hide();
            button2.Hide();
            dataGridView2.DataSource = B_SumScroes.GetAllload();


            if (Quyen == "user")
            {
                mnuDanhmuc.Enabled = false;
                mnuQuanly.Enabled = false;
                mnutimkiem.Enabled = false;
            }


        }

        private void giasoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGV gv = new frmGV();
            gv.MdiParent = this;
            gv.Show();
            gv.Location = new Point(0, 0);

        }

        private void họcLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            button1.Show();



        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btl1_Click(object sender, EventArgs e)
        {

        }

        private void mnuqlhs_Click(object sender, EventArgs e)
        {
            frmHS hs = new frmHS();
            hs.MdiParent = this;
            hs.Show();
            hs.Location = new Point(0, 0);
        }

        private void mnuLout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lg = new frmLogin();
            lg.Show();
        }

        private void mnuLg_Click(object sender, EventArgs e)
        {
            frmchpass hs = new frmchpass();
            hs.MdiParent = this;
            hs.Show();
            hs.Location = new Point(0, 0);
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop hs = new frmLop();
            hs.MdiParent = this;
            hs.Show();
            hs.Location = new Point(0, 0);
        }

        private void mnuMonhoc_Click(object sender, EventArgs e)
        {
            frmMonhoc hs = new frmMonhoc();
            hs.MdiParent = this;
            hs.Show();
            hs.Location = new Point(0, 0);
        }

        private void mnuqldiem_Click(object sender, EventArgs e)
        {
            frmDiem diem = new frmDiem();
            diem.MdiParent = this;
            diem.Show();
            diem.Location = new Point(0, 0);
        }

        private void mnuthongtinhs_Click(object sender, EventArgs e)
        {
            frmSearchThongtin timkiem = new frmSearchThongtin();
            timkiem.MdiParent = this;
            timkiem.Show();
            timkiem.Location = new Point(0, 0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            button1.Hide();
            dataGridView1.DataSource = B_TimKiem.GetAllDS();

        }

        private void mnudiemtk_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
            button2.Show();
            button2.Location = new Point(1308, 28);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            dataGridView2.Hide();
        }
    }
}
