using Microsoft.EntityFrameworkCore;
using ViewTree.Models;

namespace ViewTree
{
    public partial class MainFormP : Form
    {
        private TreeContext context;

        public MainFormP()
        {
            InitializeComponent();
            context = new TreeContext();

            trvPlants.NodeMouseClick += trvData_NodeMouseClick;
            trvPlants.ItemDrag += trvPlants_ItemDrag;
            trvPlants.DragEnter += trvPlants_DragEnter;
            trvPlants.DragDrop += trvPlants_DragDrop;
            trvPlants.BeforeExpand += trvPlants_BeforeExpand;

            LoadRootNode();
        }

        private void LoadRootNode()
        {
            trvPlants.Nodes.Clear();
            var rootNode = new TreeNode("Plants");
            trvPlants.Nodes.Add(rootNode);

            rootNode.Nodes.Add(new TreeNode("Loading..."));
        }

        private void LoadData()
        {
            trvPlants.Nodes.Clear();
            var plantsNode = new TreeNode("Plants");

            try
            {
                var families = context.PlantFamilies.Include(pf => pf.PlantSpecies).ThenInclude(ps => ps.Plants).ToList();
                if (families == null || !families.Any())
                {
                    MessageBox.Show("No data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var family in families)
                {
                    var familyNode = new TreeNode(family.FamilyName) { Tag = family };

                    if (family.PlantSpecies != null)
                    {
                        foreach (var species in family.PlantSpecies)
                        {
                            var speciesNode = new TreeNode(species.SpeciesName) { Tag = species };

                            if (species.Plants != null)
                            {
                                foreach (var plant in species.Plants)
                                {
                                    var plantNode = new TreeNode(plant.PlantName) { Tag = plant };
                                    speciesNode.Nodes.Add(plantNode);
                                }
                            }

                            familyNode.Nodes.Add(speciesNode);
                        }
                    }

                    plantsNode.Nodes.Add(familyNode);
                }

                trvPlants.Nodes.Add(plantsNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void trvData_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                trvPlants.SelectedNode = e.Node;
                if (trvPlants.SelectedNode?.Tag is PlantFamily)
                    FamilyContextMenu.Show(trvPlants, e.Location);
                else if (trvPlants.SelectedNode?.Tag is PlantSpecies)
                    SpeciesContextMenu.Show(trvPlants, e.Location);
                else if (trvPlants.SelectedNode?.Tag is Plant)
                    PlantContextMenu.Show(trvPlants, e.Location);
            }
        }

        private void addFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FamilyForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.PlantFamilies.Add(form.PlantFamily);
                context.SaveChanges();
                trvPlants.Nodes[0].Nodes.Add(new TreeNode(form.PlantFamily.FamilyName) { Tag = form.PlantFamily });
            }
        }

        private void editFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvPlants.SelectedNode?.Tag is PlantFamily f)
            {
                var form = new FamilyForm(f);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    context.SaveChanges();
                    trvPlants.SelectedNode.Text = form.PlantFamily.FamilyName;
                }
            }
        }

        private void deleteFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvPlants.SelectedNode?.Tag is PlantFamily family)
            {
                context.PlantFamilies.Remove(family);
                context.SaveChanges();
                trvPlants.SelectedNode.Remove();
            }
        }

        private void addSpeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SpeciesForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                context.PlantSpecies.Add(form.PlantSpecies);
                context.SaveChanges();

                var famNode = trvPlants.Nodes[0].Nodes
                    .Cast<TreeNode>()
                    .FirstOrDefault(node => node.Tag is PlantFamily f && f.FamilyID == form.PlantSpecies.FamilyID);

                if (famNode != null)
                {
                    var specNode = new TreeNode(form.PlantSpecies.ToString()) { Tag = form.PlantSpecies };
                    famNode.Nodes.Add(specNode);
                    famNode.Expand();
                }
            }
        }

        private void editSpeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvPlants.SelectedNode?.Tag is PlantSpecies spec)
            {
                int? curSpeciesID = spec.SpeciesID;

                var form = new SpeciesForm(spec);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    context.SaveChanges();
                    trvPlants.SelectedNode.Text = form.PlantSpecies.ToString();

                    if (spec.SpeciesID != curSpeciesID)
                    {
                        trvPlants.SelectedNode.Remove();

                        var famNode = trvPlants.Nodes[0].Nodes
                            .Cast<TreeNode>()
                            .FirstOrDefault(node => node.Tag is PlantSpecies spec
                            && spec.SpeciesID == form.PlantSpecies.SpeciesID);

                        if (famNode != null)
                        {
                            var specNode = new TreeNode(form.PlantSpecies.ToString()) { Tag = form.PlantSpecies };
                            foreach (var plant in form.PlantSpecies.Plants)
                            {
                                var plantNode = new TreeNode(plant.ToString()) { Tag = plant };
                                specNode.Nodes.Add(plantNode);
                            }
                            specNode.Nodes.Add(specNode);
                            famNode.Expand();
                            specNode.Expand();
                        }
                    }
                }
            }
        }

        private void deleteSpeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvPlants.SelectedNode?.Tag is PlantSpecies spec)
            {
                context.PlantSpecies.Remove(spec);
                context.SaveChanges();
                trvPlants.SelectedNode.Remove();
            }
        }

        private void addPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PlantForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                context.Plants.Add(form.Plant);
                context.SaveChanges();

                var specNode = trvPlants.Nodes[0].Nodes
                    .Cast<TreeNode>()
                    .SelectMany(fNode => fNode.Nodes.Cast<TreeNode>())
                    .FirstOrDefault(node => node.Tag is PlantSpecies spec && spec.SpeciesID == form.Plant.SpeciesID);

                if (specNode != null)
                {
                    var plantNode = new TreeNode(form.Plant.ToString()) { Tag = form.Plant };
                    specNode.Nodes.Add(plantNode);
                    specNode.Expand();
                }
            }
        }

        private void editPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvPlants.SelectedNode?.Tag is Plant plant)
            {
                int? originalSpeciesID = plant.SpeciesID;

                var form = new PlantForm(plant);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    context.SaveChanges();
                    trvPlants.SelectedNode.Text = form.Plant.ToString();

                    if (plant.SpeciesID != originalSpeciesID)
                    {
                        trvPlants.SelectedNode.Remove();

                        var specNode = trvPlants.Nodes[0].Nodes
                            .Cast<TreeNode>()
                            .SelectMany(fNode => fNode.Nodes.Cast<TreeNode>())
                            .FirstOrDefault(node => node.Tag is PlantSpecies spec
                            && spec.SpeciesID == form.Plant.SpeciesID);

                        if (specNode != null)
                        {
                            var plantNode = new TreeNode(form.Plant.PlantName) { Tag = form.Plant };
                            specNode.Nodes.Add(plantNode);
                            specNode.Expand();
                        }
                    }
                }
            }
        }

        private void deletePlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvPlants.SelectedNode?.Tag is Plant plant)
            {
                context.Plants.Remove(plant);
                context.SaveChanges();
                trvPlants.SelectedNode.Remove();
            }
        }

        private void trvPlants_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is TreeNode node && (node.Tag is PlantSpecies || node.Tag is Plant))
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void trvPlants_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void trvPlants_DragDrop(object sender, DragEventArgs e)
        {
            var targetNode = trvPlants.GetNodeAt(trvPlants.PointToClient(new Point(e.X, e.Y)));
            var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            if (draggedNode == null || targetNode == null) return;

            if (draggedNode.Tag is PlantSpecies spec && targetNode.Tag is PlantFamily family)
            {
                spec.PlantFamily = family;
                context.SaveChanges();

                draggedNode.Remove();
                var clonedNode = (TreeNode)draggedNode.Clone();
                targetNode.Nodes.Add(clonedNode);
                targetNode.Expand();
            }
            else if (draggedNode.Tag is Plant plant && targetNode.Tag is PlantSpecies sp)
            {
                plant.PlantSpecies = sp;
                context.SaveChanges();

                draggedNode.Remove();
                var clonedNode = (TreeNode)draggedNode.Clone();
                targetNode.Nodes.Add(clonedNode);
                targetNode.Expand();
            }
        }

        private void UpdateNode(TreeNode node)
        {
            if (node.Tag is PlantFamily fam)
            {
                node.Text = fam.FamilyName;
                node.Nodes.Clear();

                foreach (var spec in fam.PlantSpecies)
                {
                    var specChildNode = new TreeNode(spec.ToString()) { Tag = spec };

                    foreach (var plant in spec.Plants)
                    {
                        var plantChildNode = new TreeNode(plant.ToString()) { Tag = plant };
                        node.Nodes.Add(plantChildNode);
                    }

                    node.Nodes.Add(specChildNode);
                }
            }
            else if (node.Tag is PlantSpecies spec)
            {
                node.Text = spec.SpeciesName;
                node.Nodes.Clear();

                foreach (var plant in spec.Plants)
                {
                    var plantChildNode = new TreeNode(plant.ToString()) { Tag = plant };
                    node.Nodes.Add(plantChildNode);
                }
            }
            else if (node.Tag is Plant plant)
            {
                node.Text = plant.ToString();
            }
        }

        private void trvPlants_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag is PlantFamily family)
            {
                e.Node.Nodes.Clear();
                var species = context.PlantSpecies.Where(ps => ps.FamilyID == family.FamilyID).ToList();
                foreach (var s in species)
                {
                    var speciesNode = new TreeNode(s.SpeciesName) { Tag = s };
                    if (s.Plants.Any())
                    {
                        speciesNode.Nodes.Add(new TreeNode("Loading..."));
                    }
                    e.Node.Nodes.Add(speciesNode);
                }
            }
            else if (e.Node.Tag is PlantSpecies species)
            {
                e.Node.Nodes.Clear();
                var plants = context.Plants.Where(p => p.SpeciesID == species.SpeciesID).ToList();
                foreach (var p in plants)
                {
                    var plantNode = new TreeNode(p.PlantName) { Tag = p };
                    e.Node.Nodes.Add(plantNode);
                }
            }
        }
    }
}
