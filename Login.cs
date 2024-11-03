using Login.cs;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : FormBase // Turunan dari FormBase
    {
        private string username; // Menggunakan private access modifier

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Username = tbUsername.Text;

            if (!string.IsNullOrEmpty(Username))
            {
                ShowSuccessMessage("Login Berhasil, Username anda adalah : " + Username);
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                ShowErrorMessage("Harap masukkan username.");
            }
        }
    }
}
