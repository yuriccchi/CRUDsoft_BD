using ViewTree.Models;

namespace ViewTree
{
    public partial class EditUserForm : Form
    {
        private User user;

        public EditUserForm(User u)
        {
            InitializeComponent();
            user = u;

            txtUserName.Text = user.Name;
            chkIsAdmin.Checked = user.isAdmin;
            chkIsActive.Checked = user.isActive;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (User.GetPasswordHash(txtActPass.Text) != user.Password)
            {
                MessageBox.Show("Incorrect actual password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.Name = txtUserName.Text;
            user.Password = User.GetPasswordHash(txtNewPass.Text);
            user.isAdmin = chkIsAdmin.Checked;
            user.isActive = chkIsActive.Checked;

            using (var db = new UserContext())
            {
                db.Users.Update(user);
                db.SaveChanges();
            }

            MessageBox.Show("Changes saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
