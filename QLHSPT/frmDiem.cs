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
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_DIEM.GetAllDIEM();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mamon = textBox1.Text;
                string tenmon = textBox2.Text;
                string mahs = textBox3.Text;
                string hoten = textBox6.Text;
                string diemtb = textBox4.Text;


                tbDiem diem = new tbDiem(mamon, tenmon, mahs, hoten, diemtb);
                B_DIEM.InserDIEM(diem);
                MessageBox.Show("Bạn đã thêm thông tin quản lý điểm môn : " + mamon + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_DIEM.GetAllDIEM();
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
                textBox4.Text = row.Cells[4].Value.ToString();

            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string mamon = textBox1.Text;
                string tenmon = textBox2.Text;
                string mahs = textBox3.Text;
                string hoten = textBox6.Text;
                string diemtb = textBox4.Text;


                tbDiem diem = new tbDiem(mamon, tenmon, mahs, hoten, diemtb);
                B_DIEM.UpdateDIEM(diem);
                MessageBox.Show("Bạn đã sửa thông tin quản lý điểm môn : " + mamon + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_DIEM.GetAllDIEM();
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
                string mamon = textBox1.Text;
                string tenmon = textBox2.Text;
                string mahs = textBox3.Text;
                string hoten = textBox6.Text;
                string diemtb = textBox4.Text;


                tbDiem diem = new tbDiem(mamon, tenmon, mahs, hoten, diemtb);
                B_DIEM.DeleteDIEM(mamon);
                MessageBox.Show("Bạn đã xóa thông tin quản lý điểm môn : " + mamon + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_DIEM.GetAllDIEM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
