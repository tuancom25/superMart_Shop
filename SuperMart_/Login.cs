using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMart_.Model;
using SuperMart_.DTO;

namespace SuperMart_
{
    public partial class Login : Form
    {
        String Action = "/auth/user/login";
        public Login()
        {
            InitializeComponent();
        }

        private void btnExxit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // List<LoginSuccessDto>  data= Utils.getListObjectDataFromServer<LoginSuccessDto>(Action,"","");
            LoginPostDto login = new LoginPostDto();
            login.username = txtUser.Text;
            login.password = txtPass.Text;
            String logins = Utils.PostData(Action, login);
            richTextBox1.Text = logins;
        }
    }
}
