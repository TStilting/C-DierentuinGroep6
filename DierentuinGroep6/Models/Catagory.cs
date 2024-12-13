namespace DierentuinGroep6.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } // Bijvoorbeeld "Mammals"
        public string Description { get; set; } // Optioneel, extra info over de categorie
        public List<Animal> Animals { get; set; } = new(); // Lijst van dieren in deze categorie

        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }

}
