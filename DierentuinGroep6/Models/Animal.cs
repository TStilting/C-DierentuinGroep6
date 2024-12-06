using System.Drawing;

namespace DierentuinGroep6.Models
{
    public class Animal
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Species { get; set; }
        private string Category { get; set; }
        private Size Size { get; set; }
        private DietaryClass DietaryClass { get; set; }
        private ActivityPattern ActivityPattern { get; set; }
        private List<string> Prey { get; set; }
        private string Enclosure { get; set; }
        private double SpaceRequirement { get; set; }
        private SecurityLevel SecurityRequirement { get; set; } 


        public Animal() { 
        
        }
    }

    public enum Size
    {
        Microscopic,
        VerySmall,
        Small,
        Medium,
        Large,
        VeryLarge
    }

    public enum DietaryClass
    {
        Carnivore,
        Herbivore,
        Omnivore,
        Insectivore,
        Piscivore
    }

    public enum ActivityPattern
    {
        Diurnal,
        Nocturnal,
        Cathemeral
    }
}
