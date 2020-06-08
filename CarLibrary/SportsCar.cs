using System;

namespace CarLibrary
{
    public class SportsCar : Car
    {
        public SportsCar() {}
        public SportsCar(string name, short max, short curr): base(name, max, curr) { }
        public override void TurboBoost()
        {
            Console.WriteLine("Ramming speed: Faster is better...");
        }
    }
}
