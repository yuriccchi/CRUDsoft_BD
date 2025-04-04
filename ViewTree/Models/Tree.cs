using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ViewTree.Models
{
    public class PlantFamily
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FamilyID { get; set; }
        public string FamilyName { get; set; }

        public ICollection<PlantSpecies> PlantSpecies { get; set; } = new List<PlantSpecies>();

        public override string ToString()
        {
            return FamilyName;
        }
    }

    public class PlantSpecies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpeciesID { get; set; }
        public string SpeciesName { get; set; }
        public int FamilyID { get; set; }

        public virtual PlantFamily PlantFamily { get; set; }
        public ICollection<Plant> Plants { get; set; } = new List<Plant>();

        public override string ToString()
        {
            return SpeciesName;
        }
    }

    public class Plant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public int SpeciesID { get; set; }

        public virtual PlantSpecies PlantSpecies { get; set; }

        public override string ToString()
        {
            return PlantName;
        }
    }
}
