using BLL;
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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            int i;
            i = UserBLL.SignIn(txtEmail.Text, txtPass.Text);
            if (i == 1)
            {
                AddJob a = new AddJob();
                a.Show();
            }
            else MessageBox.Show("Email hoặc Password không đúng. Vui lòng nhập lại!");
        }
    }
}
