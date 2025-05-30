namespace prøveeksamen_repository
{
    public class Windows
    {
        private int id;
        private string model;
        private char energyClass;
        private int price;

        public int Id { get; set; }

        public string Model
        {
            get => model;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Model), "Model must not be null.");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Model must be at least 2 characters.");
                }
                model = value;
            }
        }

        public char EnergyClass
        {
            get => energyClass;
            set
            {
                if (value != 'A' && value != 'B' && value != 'C')
                {
                    throw new ArgumentException("EnergyClass must be 'A', 'B', or 'C'.");
                }
                energyClass = value;
            }
        }

        public int Price
        {
            get => price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Price), "Price must be a positive number.");
                }
                price = value;
            }
        }

        public Windows(int id, string model, char energyClass, int price)
        {
            Id = id;
            Model = model;
            EnergyClass = energyClass;
            Price = price;
        }

        public Windows() : this(0, "blank", 'A', 1) { }

        public override string ToString()
        {
            return $"Window: Id = {Id}, Model = {Model}, Energy Class = {EnergyClass}, Price = {Price}";
        }
    }
}

