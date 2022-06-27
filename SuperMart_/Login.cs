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
using System.Security;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using SuperMart_.UX;
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
            // List<LoginSuccessDto>  data=             U Utils.getListObjectDataFromServer<LoginSuccessDto>(Action,"","");
            LoginPostDto login = new LoginPostDto();
            login.username = txtUser.Text;
            login.password = txtPass.Text;
            String logins = Utils.PostData(Action, login);
            LoginSuccessDto loginSuccessDto = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginSuccessDto>(logins);
            richTextBox1.Text = logins;
            txtToken.Text = loginSuccessDto.accessToken;
            txt2.Text = loginSuccessDto.user.fullname;
            Utils.token = loginSuccessDto.accessToken;


            //FrmSuperMart_AddProduct frm = new FrmSuperMart_AddProduct(loginSuccessDto.accessToken);
            //frm.Visible = true;

            FrmSuperMart_UpdateProduct frm = new FrmSuperMart_UpdateProduct(loginSuccessDto.accessToken);
            frm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSA rsa = RSA.Create();
            using (var rsa2 = new RSACryptoServiceProvider(2048))
            {
                //UseRsaKey(rsa);
                var param = rsa.ExportParameters(false);
               // 
               
            }
            RSACng rSACng = null;
            // https://jpassing.com/2021/12/07/exporting-rsa-public-keys-in-dotnet-and-dotnet-framework/
        }

        private void testHttps_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(
            "https://docs.microsoft.com");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                // Console.WriteLine(responseFromServer);
                richTextBox1.Text = responseFromServer;
            }

            // Close the response.
            response.Close();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            FrmSuperMart_Sale frmSale = new FrmSuperMart_Sale();
            frmSale.Show();
            this.Hide();
        }
    }
}
