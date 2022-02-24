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
    public partial class frmMonhoc : Form
    {
        public frmMonhoc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_Monhoc.GetAllMH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mamon = textBox1.Text;
                string tenmon = textBox2.Text;              
                string magv = textBox3.Text;
                string mahs = textBox6.Text;


                tbMonhoc monhoc = new tbMonhoc(mamon, tenmon, magv,mahs);
                B_Monhoc.InserMH(monhoc);
                MessageBox.Show("Bạn đã thêm thông tin môn : " + tenmon + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_Monhoc.GetAllMH();
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
                string mamon = textBox1.Text;
                string tenmon = textBox2.Text;
                string magv = textBox3.Text;
                string mahs = textBox6.Text;


                tbMonhoc monhoc = new tbMonhoc(mamon, tenmon, magv, mahs);
                B_Monhoc.UpdateMH(monhoc);
                MessageBox.Show("Bạn đã sữa thông tin môn : " + tenmon + " thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = B_Monhoc.GetAllMH();
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
                string magv = textBox3.Text;
                string mahs = textBox6.Text;


                tbMonhoc monhoc = new tbMonhoc(mamon, tenmon, magv, mahs);
                B_Monhoc.DeleteMH(mamon);
                MessageBox.Show("Bạn đã xoá thông tin môn : " + tenmon + " thành công!!!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = B_Monhoc.GetAllMH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
