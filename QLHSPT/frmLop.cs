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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_Lop.GetAllLOP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string malop = textBox1.Text;
                string tenlop = textBox2.Text;
                string magv = textBox3.Text;
                string mahs = textBox6.Text;


                tbLop lop = new tbLop(malop, tenlop, magv, mahs);
                B_Lop.InserLOP(lop);
                MessageBox.Show("Bạn đã thêm thông tin lop : " + malop + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_Lop.GetAllLOP();
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

                textBox3.Text = row.Cells[2].Value.ToString();
                textBox6.Text = row.Cells[3].Value.ToString();

            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string malop = textBox1.Text;
                string tenlop = textBox2.Text;
                string magv = textBox3.Text;
                string mahs = textBox6.Text;


                tbLop lop = new tbLop(malop, tenlop, magv, mahs);
                B_Lop.UpdateLOP(lop);
                MessageBox.Show("Bạn đã sửa thông tin lop : " + malop + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_Lop.GetAllLOP();
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
                string malop = textBox1.Text;
                string tenlop = textBox2.Text;
                string magv = textBox3.Text;
                string mahs = textBox6.Text;


                tbLop lop = new tbLop(malop, tenlop, magv, mahs);
                B_Lop.DeleteLOP(malop);
                MessageBox.Show("Bạn đã xoá thông tin môn : " + malop + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_Lop.GetAllLOP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
