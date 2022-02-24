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
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_GV.GetAllGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = textBox1.Text;
                string tengv = textBox2.Text;
                string gioitinh = comboBox1.Text;
                string phone = textBox3.Text;
                string email = textBox6.Text;
                string giangdaymon = textBox4.Text;
                string malop = textBox5.Text;


                tbGV gv = new tbGV(magv, tengv,gioitinh, phone, email, giangdaymon, malop);
                B_GV.InserGV(gv);
                MessageBox.Show("Bạn đã thêm thông tin giáo viên tên : " + tengv + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_GV.GetAllGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox4.Text = row.Cells[5].Value.ToString();
                textBox5.Text = row.Cells[6].Value.ToString();

            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = textBox1.Text;
                string tengv = textBox2.Text;
                string gioitinh = comboBox1.Text;
                string phone = textBox3.Text;
                string email = textBox6.Text;
                string giangdaymon = textBox4.Text;
                string malop = textBox5.Text;


                tbGV gv = new tbGV(magv, tengv, gioitinh, phone, email, giangdaymon, malop);
                B_GV.UpdateGV(gv);
                MessageBox.Show("Bạn đã sửa thông tin giáo viên tên : " + tengv + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_GV.GetAllGV();
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
                string magv = textBox1.Text;
                string tengv = textBox2.Text;
                string gioitinh = comboBox1.Text;
                string phone = textBox3.Text;
                string email = textBox6.Text;
                string giangdaymon = textBox4.Text;
                string malop = textBox5.Text;


                tbGV gv = new tbGV(magv, tengv, gioitinh, phone, email, giangdaymon, malop);
                B_GV.DeleteGV(magv);
                MessageBox.Show("Bạn đã xoá thông tin giáo viên tên : " + tengv + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_GV.GetAllGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
