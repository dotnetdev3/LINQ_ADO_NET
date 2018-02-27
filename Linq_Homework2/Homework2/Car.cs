namespace Homework2
{
    public class Car
    {
        public Car(string model,string producer,  int highSpeed, string bodyType, Engine engine)
        {
            Model = model;
            Producer = producer;
            HighSpeed = highSpeed;
            BodyType = bodyType;
            CarEngine = engine;
        }
        public string Producer { get; }
        public string Model { get; }
        public int HighSpeed { get; }
        public string BodyType { get; }

        public Engine CarEngine { get; }
    }
}
