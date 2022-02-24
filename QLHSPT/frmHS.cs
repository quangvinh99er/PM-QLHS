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
    public partial class frmHS : Form
    {
        public frmHS()
        {
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_Hocsinh.GetAllHS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mahs = textBox1.Text;
                string hoten = textBox2.Text;
                string ngaysinh = dateTimePicker1.Text;
                string gioiting = comboBox1.Text;
                string diachi = textBox6.Text;
                string malop = textBox3.Text;


                tbHocsinh hocsinh = new tbHocsinh(mahs, hoten, ngaysinh, gioiting, diachi, malop);
                B_Hocsinh.InserHS(hocsinh);
                MessageBox.Show("Bạn đã thêm thông tin học sinh tên : " + hoten + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_Hocsinh.GetAllHS();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            try{
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox3.Text = row.Cells[5].Value.ToString();

            }
            catch 
            {
                
            }
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string mahs = textBox1.Text;
                string hoten = textBox2.Text;
                string ngaysinh = dateTimePicker1.Text;
                string gioiting = comboBox1.Text;
                string diachi = textBox6.Text;
                string malop = textBox3.Text;


                tbHocsinh hocsinh = new tbHocsinh(mahs, hoten, ngaysinh, gioiting, diachi, malop);
                B_Hocsinh.UpdateHS(hocsinh);
                MessageBox.Show("Bạn đã sửa thông tin học sinh tên : " + hoten + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_Hocsinh.GetAllHS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mahs = textBox1.Text;
                string hoten = textBox2.Text;
                string ngaysinh = dateTimePicker1.Text;
                string gioiting = comboBox1.Text;
                string diachi = textBox6.Text;
                string malop = textBox3.Text;


                tbHocsinh hocsinh = new tbHocsinh(mahs, hoten, ngaysinh, gioiting, diachi, malop);
                B_Hocsinh.DeleteHS(mahs);
                MessageBox.Show("Bạn đã xoá thông tin học sinh tên : " + hoten + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_Hocsinh.GetAllHS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
