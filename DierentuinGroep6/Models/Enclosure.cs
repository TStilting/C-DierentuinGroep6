namespace DierentuinGroep6.Models
{
    public class Enclosure
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private List<Animal> Animals { get; set; } = new();
        private Climate Climate { get; set; }
        private HabitatType HabitatType { get; set; }
        private SecurityLevel SecurityLevel { get; set; }
        private double Size { get; set; } // in square meters

        public Enclosure(int id, string name, Climate climate, HabitatType habitatType, SecurityLevel securityLevel, double size)
        {
            Id = id;
            Name = name;
            Climate = climate;
            HabitatType = habitatType;
            SecurityLevel = securityLevel;
            Size = size;
        }
    }

    public enum Climate
    {
        Tropical,
        Temperate,
        Arctic
    }
    [Flags]
    public enum HabitatType
    {
        Forest = 1,
        Aquatic = 2,
        Desert = 4,
        Grassland = 8
    }
    public enum SecurityLevel
    {
        Low,
        Medium,
        High
    }
}
