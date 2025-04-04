using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewTree.Models;

namespace ViewTree
{
    public partial class PlantForm : Form
    {
        public Plant Plant { get; private set; }
        private List<PlantSpecies> _species;

        public PlantForm(Plant plant = null)
        {
            InitializeComponent();
            Plant = plant ?? new Plant();
            txtPlantName.Text = Plant.PlantName;

            using (var context = new TreeContext())
            {
                _species = context.PlantSpecies.ToList();
            }

            var speciesList = _species
                .Select(spec => new { ID = (int?)spec.SpeciesID, Name = spec.SpeciesName.ToString() })
                .ToList();
            cmbSpecies.DataSource = speciesList;
            cmbSpecies.DisplayMember = "Name";
            cmbSpecies.ValueMember = "ID";

            if (Plant.SpeciesID != 0)
            {
                cmbSpecies.SelectedValue = Plant.SpeciesID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlantName.Text))
            {
                MessageBox.Show("The name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbSpecies.SelectedValue == null)
            {
                MessageBox.Show("Please select a species", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Plant.PlantName = txtPlantName.Text;
            Plant.SpeciesID = (int)cmbSpecies.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
