using System;

namespace ECS.Refactor
{

    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }

    public class FakeTempSensor : ITempSensor
    {
        public bool WillReturn { get; set; } = false;
        public int WillReturnTemp { get; set; } = 23;
        public int GetTemp()
        { return 23;}
        public bool RunSelfTest()
        { return WillReturn;}
    }
    internal class TempSensor : ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}