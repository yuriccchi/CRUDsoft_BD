using ViewTree.Models;

namespace ViewTree
{
    public partial class MainFormU : Form
    {
        public MainFormU()
        {
            InitializeComponent();
            LoadUsers();

            listUsers.MouseClick += listUsers_MouseClick;
        }

        private void LoadUsers()
        {
            try
            {
                var bd = new UserContext();

                var users = bd.Users;

                listUsers.Items.Clear();

                foreach (var user in users)
                {
                    var item = new ListViewItem(new[] { user.Name, user.isAdmin.ToString(), user.isActive.ToString() });
                    listUsers.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listUsers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = listUsers.GetItemAt(e.X, e.Y);

                if (item != null)
                {
                    item.Selected = true;

                    contextMenuStrip.Items[0].Visible = true;
                    contextMenuStrip.Items[1].Visible = true;
                    contextMenuStrip.Show(listUsers, e.Location);
                }
                else
                {
                    contextMenuStrip.Items[0].Visible = false;
                    contextMenuStrip.Items[1].Visible = false;
                    contextMenuStrip.Show(listUsers, e.Location);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItems.Count > 0)
            {
                var selectedItem = listUsers.SelectedItems[0];
                var userName = selectedItem.Text;

                using (var db = new UserContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Name == userName);
                    if (user != null)
                    {
                        var editForm = new EditUserForm(user);
                        editForm.ShowDialog();
                        LoadUsers();
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItems.Count > 0)
            {
                var selectedItem = listUsers.SelectedItems[0];
                var userName = selectedItem.Text;

                using (var db = new UserContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Name == userName);
                    if (user != null)
                    {
                        db.Users.Remove(user);
                        db.SaveChanges();
                        LoadUsers();
                    }
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
            LoadUsers();
        }
    }
}
