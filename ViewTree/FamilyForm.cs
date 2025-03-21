using ViewTree.Models;

namespace ViewTree
{
    public partial class FamilyForm : Form
    {
        public PlantFamily PlantFamily { get; private set; }

        public FamilyForm(PlantFamily family = null)
        {
            InitializeComponent();
            PlantFamily = family ?? new PlantFamily();
            txtFamilyName.Text = PlantFamily.FamilyName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFamilyName.Text))
            {
                MessageBox.Show("The name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlantFamily.FamilyName = txtFamilyName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
