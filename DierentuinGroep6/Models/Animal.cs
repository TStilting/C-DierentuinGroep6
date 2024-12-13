using System.Drawing;

namespace DierentuinGroep6.Models
{
    public class Animal
    {
        private int Id { get; set; }
        private String Name { get; set; }
        private String Species { get; set; }
        private Category Category { get; set; }
        private Size Size { get; set; }
        private DietaryClass DietaryClass { get; set; }
        private ActivityPattern ActivityPattern { get; set; }
        private List<String> Prey { get; set; }
        private String Enclosure { get; set; }
        private double SpaceRequirement { get; set; }
        private SecurityLevel SecurityRequirement { get; set; }

        // Houdt bij welke acties zijn uitgevoerd
        private List<string> performedActions = new();


        public Animal() { 
        
        }

        public bool IsAwake(DateTime currentTime)
        {
            int hour = currentTime.Hour;

            return ActivityPattern switch
            {
                ActivityPattern.Diurnal => hour >= 6 && hour < 18,   // Is wakker overdag (als de zon op is)
                ActivityPattern.Nocturnal => hour >= 18 || hour < 6, // Is wakker 's nachts (als de zon onder is)
                ActivityPattern.Cathemeral => true,                 // Altijd wakker
                _ => false                                          // Onbekend, is aan het slapen
            };
        }

        public String CheckDietaryClass()
        {
            return DietaryClass switch
            {
                DietaryClass.Carnivore => Name + " eats meat. Preferred prey: " + Prey + ".",
                DietaryClass.Herbivore => Name + " eats plants, leaves, and fruits.",
                DietaryClass.Omnivore => Name + " eats both plants and meat.",
                DietaryClass.Insectivore => Name + " feeds on insects.",
                DietaryClass.Piscivore => Name + " feeds on fish.",
                _ => Name + " has an unknown diet."
            };
        }

        public String FeedingTime()
        {
            String action = Name + " was fed.";
            AddAction(action); // Voeg actie toe aan de lijst
            return action;
        }

        // Functie voor bijhouden wat al is ondernomen voor het dier
        public void AddAction(String action)
        {
            performedActions.Add(action);
        }

        // Toont de lijst die alle uitgevoerde acties bevat
        public List<String> GetPerformedActions()
        {
            return new List<String>(performedActions);
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
