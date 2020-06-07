using System;

namespace CarLibrary
{
    public enum EngineState
    {
        engineAlive,
        engineDead
    }
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
        public string PetName { get; set; }
        public string CurrSpeed { get; set; }
        public short MaxSpeed { get; }
        public EngineState EngineState { get; }

    }
}
