namespace DierentuinGroep6.Models
{
    public class Enclosure
    {
        private int id;
        private string name;
        private List<Animal> Animals { get; set; } = new();
        private Climate climate;
        private HabitatType habitatType;
        private SecurityLevel securityLevel;
        private double size; // in square meters

        // Publieke properties voor EF Core
        public int Id
        {
            get => id;
            private set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Size
        {
            get => size;
            set => size = value;
        }

        public Climate Climate
        {
            get => climate;
            set => climate = value;
        }

        public HabitatType HabitatType
        {
            get => habitatType;
            set => habitatType = value;
        }

        public SecurityLevel SecurityLevel
        {
            get => securityLevel;
            set => securityLevel = value;
        }


        public Enclosure(int id, string name, Climate climate, HabitatType habitatType, SecurityLevel securityLevel, double size)
        {
            Id = id;
            Name = name;
            Climate = climate;
            HabitatType = habitatType;
            SecurityLevel = securityLevel;
            Size = size;
        }

        // Lege constructor voor EF Core
        private Enclosure() { }
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
