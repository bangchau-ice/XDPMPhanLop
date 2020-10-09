using DAL;
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
    public partial class UserJob : Form
    {
        public UserJob(string id)
        {
            InitializeComponent();
            DataTable dt = JobDAL.getUserJob(id);
            dataGridView1.DataSource = dt;
        }

        private void UserJob_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todoList_DBDataSet2.DBJob' table. You can move, or remove it, as needed.
            this.dBJobTableAdapter.Fill(this.todoList_DBDataSet2.DBJob);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
