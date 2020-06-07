using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary
{
    public class MiniVan : Car
    {
        public MiniVan() { }
        public MiniVan(string name, short max, short curr): base(name, max, curr) { }
        public override void TurboBoost()
        {
            egnState = EngineState.engineDead;
            Console.WriteLine("Time to call AAA: Your car is dead");
        }
    }
}
