namespace Homework2
{
    public class Engine
    {
        public Engine(int cylinders, int power, float liters)
        {
            Cylinders = cylinders;
            Power = power;
            Liters = liters;
        }

        public int Cylinders { get; }
        public int Power { get; }
        public float Liters { get; }

    }
}
