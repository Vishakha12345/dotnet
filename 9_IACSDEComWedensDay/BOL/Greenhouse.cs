namespace BOL
{
    public class Produce
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    }

    public class TFLFarm
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Greenhouse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public TFLFarm Property { get; set; }
    }
}
