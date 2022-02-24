using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace QLHSPT
{
    public partial class frmchpass : Form
    {
        public frmchpass()
        {
            InitializeComponent();
        }

        private void frmchpass_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-THTB7M5\SQLEXPRESS;Initial Catalog=QLHSPT;Integrated Security=True");

            conn.Open();
            string select2 = "Select * From LoginTHPT where Taikhoan='" + textBox1.Text + "' and MatKhau='" + textBox2.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();




            errorProvider1.Clear();
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Chưa nhập tên tài khoản !");
            else if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "!");
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "!");
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "!");
                textBox4.Focus();
            }
            else if (textBox4.Text != textBox3.Text)
                MessageBox.Show("Bạn nhập lại password không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            else if (reader2.Read())
            {
                cmd2.Dispose();
                reader2.Dispose();
                // Thực hiện truy vấn
                string update = "Update LoginTHPT Set MatKhau='" + textBox3.Text + "' where Taikhoan='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                // Trả tài nguyên
                cmd.Dispose();
            }

            else
            {
                MessageBox.Show("Tên tài khoản không tồn tại hoặc mật khẩu sai! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();

            }
            cmd2.Dispose();
            reader2.Dispose();
        }
    }
}

      
