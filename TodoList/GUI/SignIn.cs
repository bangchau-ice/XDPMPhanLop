using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            if (i != 0)
            {

                ListJob a = new ListJob();
                UserDTO user = new UserDTO();
                user = UserBLL.getUser(i);
                MessageBox.Show(user.uType.ToString());
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                config.AppSettings.Settings["uid"].Value=i.ToString();
                config.AppSettings.Settings["utype"].Value=user.uType.ToString();
                config.Save(ConfigurationSaveMode.Minimal);
                ConfigurationManager.RefreshSection("appSettings");
                a.Show();
               
                //AddJob a = new AddJob();
                //a.Show();
            }
            else MessageBox.Show("Email hoặc Password không đúng. Vui lòng nhập lại!");
        }
    }
}
