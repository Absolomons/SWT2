namespace ECS.Refactor
{

    public interface IHeater
    {
        void TurnOn();
        void TurnOff();
        bool RunSelfTest();
    }

    public class FakeHeater : IHeater
    {
        public bool WillReturn {get; set;} = false;

        public void TurnOn()
        {}
        public void TurnOff()
        {}
        public bool RunSelfTest()
        { return WillReturn; }

    }
    public class Heater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}