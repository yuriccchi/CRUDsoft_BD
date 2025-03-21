using Npgsql;
using ViewTree.Models;

namespace ViewTree
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
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

        public string secPassword
        {
            get { return txtConfirmPassword.Text; }
            set { txtConfirmPassword.Text = value; }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(secPassword))
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            if (Password != secPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (isUserNameTaken(UserName))
            {
                MessageBox.Show("A user with this username already exists");
                return;
            }

            string passwordHash = User.GetPasswordHash(Password);

            try
            {
                using (var connection = new NpgsqlConnection("Host=localhost;Database=SoftWEngNew;Username=postgres;Password=123654;"))
                {
                    connection.Open();

                    var sql = @"
                        INSERT INTO ""Users"" (""Name"", ""Password"", ""isAdmin"", ""isActive"")
                        VALUES (@username, @passwordHash, false, true);
                    ";

                    using (var command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", UserName);
                        command.Parameters.AddWithValue("@passwordHash", passwordHash);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration was successful");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}");
            }
        }

        private bool isUserNameTaken(string username)
        {
            using (var connection = new NpgsqlConnection("Host=localhost;Database=SoftWEngNew;Username=postgres;Password=123654;"))
            {
                connection.Open();

                var sql = "SELECT COUNT(*) FROM \"Users\" WHERE \"Name\" = @username;";
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
