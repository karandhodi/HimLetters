using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace HimLetters
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            pictureBoxLoginForm.ImageLocation = "../../LoginForm.png";
            pictureBoxLoginForm.SizeMode = PictureBoxSizeMode.StretchImage;

            txtBoxPassword.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            if ( txtBoxUsername.Text == String.Empty)
            {
                MessageBox.Show("Username field cannot be empty", "Log on failure");
            }
            else
            {
                if( txtBoxPassword.Text == String.Empty)
                {
                    MessageBox.Show("Password field cannot be empty", "Log on failure");
                }
                else
                {
                    if (txtBoxDomain.Text == String.Empty)
                    {
                        MessageBox.Show("Domain field cannot be empty", "Log on failure");
                    }
                    else
                    {
                        WebClient proxy = new WebClient();
                        String url = String.Format("http://localhost:49962/ServicePassword.svc/getpassword/{0}", txtBoxUsername.Text);
                        byte[] data = proxy.DownloadData(url);
                        Stream stream = new MemoryStream(data);
                        DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<ServiceReferencePassword.getPass_Results>));
                        List<ServiceReferencePassword.getPass_Results> srlt = obj.ReadObject(stream) as List<ServiceReferencePassword.getPass_Results>;

                        if (srlt[0].Password != txtBoxPassword.Text)
                        {
                            MessageBox.Show("Invalid Username and/or Password", "Error: Security Failure");
                        }

                        else
                        {
                            MainForm mf = new MainForm();
                            mf.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
    }
}
