using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;


namespace QLHSPT
{
    public partial class frmLogin : Form

    {

       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

       

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-THTB7M5\SQLEXPRESS;Initial Catalog=QLHSPT;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * From LoginTHPT Where Taikhoan= N'" + txtdangnhap.Text + "' and Matkhau= N'" + txtMk.Text + "'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMain frm = new frmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                frm.Show();

            }
            else
            {
                MessageBox.Show("Kiểm tra lại Tên Đăng Nhập hoặc Mật Khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtdangnhap.Text = "";
                txtMk.Text = "";
                txtdangnhap.Focus();
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
