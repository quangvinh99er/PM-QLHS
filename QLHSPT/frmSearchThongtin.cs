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
using System.Data.SqlClient;

namespace QLHSPT
{
    public partial class frmSearchThongtin : Form
    {
        public frmSearchThongtin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSearchThongtin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_TimKiem.GetAllDS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-THTB7M5\SQLEXPRESS;Initial Catalog=QLHSPT;Integrated Security=True");

            conn.Open();

            string select = "Select * From StudentTHPT  where MaHS='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(select, conn);

            // Tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Tạo đối tượng điều hợp
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Fill dữ liệu từ adapter vào DataSet
            adapter.Fill(ds, "QLHSPT");

            // Đưa ra DataGridView
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "QLHSPT";

            cmd.Dispose();

        }
    }
}
