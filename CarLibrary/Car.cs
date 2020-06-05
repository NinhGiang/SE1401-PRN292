using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{

    public enum EngineState
    { engineAlive, engineDead }


    public abstract class Car
    {
        protected string petName;
        protected short currSpeed;
        protected short maxSpeed;
        protected EngineState egnState = EngineState.engineAlive;

        public abstract void TurboBoost();

        public Car() { }

        public Car(string name, short max, short curr)
        {
            petName = name; maxSpeed = max; currSpeed = curr;
        }

        public string PetName
        {
            get { return petName; }
            set { petName = value; }
        }

        public short CurrSpeed
        {
            get { return currSpeed; }
            set { currSpeed = value; }
        }

        public short MaxSpeed
        { get { return maxSpeed; } }
        public EngineState EngineState
        { get { return egnState; } }
    }

}
