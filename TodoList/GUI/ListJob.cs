using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;




namespace GUI
{
    public partial class ListJob : Form
    {
        private object dt;
        private SqlConnection conn;

        public ListJob()
        {
            InitializeComponent();
        }

        private void ListJob_Load(object sender, EventArgs e)
        {
            DataTable dt = JobDAL.get_AllJob();
            dataGridView1.DataSource = dt;
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            AddJob a = new AddJob();
            a.Show();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            int tim = Int16.Parse(txttim.Text);
            DataTable dt = BLL.JobBLL.search(tim);
            dataGridView1.DataSource = dt;
        }

        private void lblocngay_Click(object sender, EventArgs e)
        {

        }

        private void lblocnv_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            chitietJob myjob = new chitietJob();
            //  myjob.textBox1.Text = Convert.ToString(dataGridView1[0, row]).ToString);
            //   myjob.textBox1.Text = dataGridView1.CurrentRow.Cells[0].ToString();
            myjob.textBox1.Text = dataGridView1.SelectedCells[2].Value.ToString();
            myjob.textBox2.Text = dataGridView1.SelectedCells[3].Value.ToString();
            myjob.textBox3.Text = dataGridView1.SelectedCells[4].Value.ToString();
            myjob.textBox4.Text = dataGridView1.SelectedCells[5].Value.ToString();
            myjob.textBox5.Text = dataGridView1.SelectedCells[6].Value.ToString();
            myjob.textBox6.Text = dataGridView1.SelectedCells[7].Value.ToString();
            myjob.textBox7.Text = dataGridView1.SelectedCells[8].Value.ToString();
            myjob.textBox8.Text = dataGridView1.SelectedCells[9].Value.ToString();
            myjob.ShowDialog();
        }
        private void lbtim_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                JobDTO job = new JobDTO();
                int currentIndex = dataGridView1.CurrentCell.RowIndex;
                int job_id = Convert.ToInt32(dataGridView1.Rows[currentIndex].Cells[1].Value.ToString());
                JobDAL.delete(job);

                dataGridView1.DataSource = dt;
                //  string deleteStr = "delete from DBJob where DBJob.job_id = '" + job_id + "' ";
                //  SqlCommand cmd = new SqlCommand(deleteStr, conn);
                // cmd.CommandType = CommandType.Text;
                // cmd.EndExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }





            /* DataTable sourceData = (DataTable)dataGridView1.DataSource;
             foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
             {
                 if (MessageBox.Show("Sure you wanna delete?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                 {
                     JobDTO job = new JobDTO();
                     JobDAL.delete(job);
                     dataGridView1.DataSource = dt;

                 }
                     int rowIndex = dataGridView1.CurrentCell.RowIndex;
                      dataGridView1.Rows.RemoveAt(rowIndex);
                     int IdColumn = 0;
                     dataGridView1.Rows.RemoveAt(row.Index);
                     string sql = "delete DBJob" + "where job_id =  ('" + job.jId + "')";

             } */

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            int id= int.Parse(row.Cells[2].Value.ToString());
            ChiTiet ct = new ChiTiet(id);
            ct.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btXoa")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa công việc này","Đóng hộp thoại", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dataGridView1.Rows[e.RowIndex];
                    int id = int.Parse(row.Cells[1].Value.ToString());
                    BLL.JobBLL.deleteJob(id);
                    MessageBox.Show("Xóa thành công");
                    DataTable dt = JobDAL.get_AllJob();
                    dataGridView1.DataSource = dt;
                    //dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[e.RowIndex].Index);

                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btSua")
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                int id = int.Parse(row.Cells[2].Value.ToString());
                formsua update = new formsua(id);
                update.Show();

            }
        }
    }





    /*private void btloc_Click(object sender, EventArgs e)
    {
        if (txtmanv.TextLength > 0)
        {
            int manv = Int16.Parse(txtmanv.Text);
            int result = DateTime.Compare(dtngkt.Value, dtngbd.Value);
            if (result >= 0)
            {
                DataTable dt = JobDAL.loc(dtngbd.Value.ToString(), dtngkt.Value.ToString(),manv);
                dataGridView1.DataSource = dt;
            }
            else
            {
                string error = "Hãy đảm bảo thời gian hoàn thành công việc";
                MessageBox.Show(error);
            }    
        }
        else
        {
            DataTable dt = JobDAL.locday(dtngbd.Value.ToString(), dtngkt.Value.ToString());
            dataGridView1.DataSource = dt;
        }

    }*/

}
