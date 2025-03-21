using ViewTree.Models;

namespace ViewTree
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = User.Login(UserName, Password);

            if (user != null)
            {
                this.Hide();

                if (user.isAdmin)
                {
                    MainFormP mainFormP = new MainFormP();
                    MainFormU mainFormU = new MainFormU();

                    mainFormP.FormClosed += (s, args) => Application.Exit();
                    mainFormU.FormClosed += (s, args) => Application.Exit();

                    mainFormP.Show();
                    mainFormU.Show();
                }
                else
                {
                    MainFormP mainFormP = new MainFormP();
                    mainFormP.FormClosed += (s, args) => Application.Exit();
                    mainFormP.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnRegistraton_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
        }
    }
}
