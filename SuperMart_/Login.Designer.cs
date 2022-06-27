
namespace SuperMart_
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExxit = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testHttps = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(151, 168);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExxit
            // 
            this.btnExxit.Location = new System.Drawing.Point(259, 168);
            this.btnExxit.Name = "btnExxit";
            this.btnExxit.Size = new System.Drawing.Size(75, 23);
            this.btnExxit.TabIndex = 1;
            this.btnExxit.Text = "Exit";
            this.btnExxit.UseVisualStyleBackColor = true;
            this.btnExxit.Click += new System.EventHandler(this.btnExxit_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(183, 81);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(151, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "username";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(183, 132);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(151, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "123456";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(45, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(416, 146);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pass :";
            // 
            // testHttps
            // 
            this.testHttps.Location = new System.Drawing.Point(626, 180);
            this.testHttps.Name = "testHttps";
            this.testHttps.Size = new System.Drawing.Size(75, 23);
            this.testHttps.TabIndex = 6;
            this.testHttps.Text = "Test HTTPs";
            this.testHttps.UseVisualStyleBackColor = true;
            this.testHttps.Click += new System.EventHandler(this.testHttps_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(614, 30);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(100, 20);
            this.txtToken.TabIndex = 7;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(614, 81);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 8;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(376, 167);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(75, 23);
            this.btnSale.TabIndex = 9;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 249);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.testHttps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnExxit);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExxit;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testHttps;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnSale;
    }
}