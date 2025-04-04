using System.Data;
using ViewTree.Models;

namespace ViewTree
{
    public partial class SpeciesForm : Form
    {
        public PlantSpecies PlantSpecies { get; private set; }
        private List<PlantFamily> _families;

        public SpeciesForm(PlantSpecies spec = null)
        {
            InitializeComponent();
            PlantSpecies = spec ?? new PlantSpecies();
            txtSpeciesName.Text = PlantSpecies.SpeciesName;

            using (var context = new TreeContext())
            {
                _families = context.PlantFamilies.ToList();
            }

            var familyList = _families
                .Select(fam => new { ID = (int?)fam.FamilyID, Name = fam.FamilyName })
                .ToList();

            cmbFamily.DataSource = familyList;
            cmbFamily.DisplayMember = "Name";
            cmbFamily.ValueMember = "ID";

            if (PlantSpecies.FamilyID != 0)
            {
                cmbFamily.SelectedValue = PlantSpecies.FamilyID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpeciesName.Text))
            {
                MessageBox.Show("The name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbFamily.SelectedValue == null)
            {
                MessageBox.Show("Please select a family", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlantSpecies.SpeciesName = txtSpeciesName.Text;
            PlantSpecies.FamilyID = (int)cmbFamily.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
