namespace Robots
{
    class Robot
    {
        public int Size { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Robot(int size, string name, string type)
        {
            Size = size;
            Name = name;
            Type = type;
        }
    }
}