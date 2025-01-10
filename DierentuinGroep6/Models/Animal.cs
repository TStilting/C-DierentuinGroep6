using System.Drawing;

namespace DierentuinGroep6.Models
{
    public class Animal
    {
        private int id;
        private string name;
        private string species;
        private string prey;
        private double spaceRequirement;
        private Size size;
        private DietaryClass dietaryClass;
        private ActivityPattern activityPattern;
        private SecurityLevel securityRequirement;

        // Houdt bij welke acties zijn uitgevoerd
        private List<string> performedActions = new();

        // Publieke properties voor EF Core
        public int Id
        {
            get => id;
            private set => id = value; // Alleen EF Core mag deze instellen
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Species
        {
            get => species;
            set => species = value;
        }

        public string Prey
        {
            get => prey;
            set => prey = value;
        }

        public double SpaceRequirement
        {
            get => spaceRequirement;
            set => spaceRequirement = value;
        }

        public Size Size
        {
            get => size;
            set => size = value;
        }

        public DietaryClass DietaryClass
        {
            get => dietaryClass;
            set => dietaryClass = value;
        }

        public ActivityPattern ActivityPattern
        {
            get => activityPattern;
            set => activityPattern = value;
        }

        public SecurityLevel SecurityRequirement
        {
            get => securityRequirement;
            set => securityRequirement = value;
        }

        // Lege constructor voor EF Core
        public Animal() { }



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
