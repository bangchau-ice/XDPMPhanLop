using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddJob : Form
    {
        public AddJob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTencv.TextLength>0)
            {
                if (cbPhamvi.Text !="")
                {
                    int result = DateTime.Compare(dtNgkt.Value, dtNgbd.Value);
                    if (result>=0)
                    {
                        
                        JobDTO job = new JobDTO();
                        job.jTitle = txtTencv.Text;
                        job.jStarday = dtNgbd.Value.ToString();
                        job.jEndday = dtNgkt.Value.ToString();
                        job.jStatus = "1";
                        job.jPartner = cbNglc.SelectedValue.ToString();
                        job.jCircle = cbPhamvi.Text;
                        job.jAttachments = txtfile.Text;
                        JobDAL.insert(job);
                        this.dBJobTableAdapter.Fill(this.todoList_DBDataSet.DBJob);
                    }
                    else
                    {
                        string error = "Hãy đảm bảo thời gian hoàn thành công việc";
                        MessageBox.Show(error);

                    }
                }
                else
                {
                    string error = "Hãy chọn phạm vi cho công việc";
                    MessageBox.Show(error);

                }
            }
            else
            {
                string error = "Hãy nhập tên công việc";
                MessageBox.Show(error);

            }
            
        }

        

        private void txtDinhkem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String fileName;
                fileName = dlg.FileName;
                txtfile.Text=fileName;
            }
        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todoList_DBDataSet1.DBUser' table. You can move, or remove it, as needed.
            this.dBUserTableAdapter.Fill(this.todoList_DBDataSet1.DBUser);
            // TODO: This line of code loads data into the 'todoList_DBDataSet.DBJob' table. You can move, or remove it, as needed.
            this.dBJobTableAdapter.Fill(this.todoList_DBDataSet.DBJob);

        }
    }
}
