namespace DierentuinGroep6.Models
{
    public class Zoo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; } // Bijvoorbeeld stad of land
        public List<Enclosure> Enclosures { get; set; } = new(); // Verblijven in de dierentuin
        public List<Category> Categories { get; set; } = new(); // Diercategorieën

        public Zoo(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
        }
    }
}
