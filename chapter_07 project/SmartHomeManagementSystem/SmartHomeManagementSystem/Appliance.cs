namespace SmartHomeManagementSystem
{
    public class Appliance : IControllable
    {
        private bool isOn;

        public Appliance()
        {
            isOn = false; // By default, appliances are off
        }

        public void TurnOn()
        {
            if (!isOn)
            {
                isOn = true;
                Console.WriteLine($"{GetType().Name} is turned on.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is already on.");
            }
        }

        public void TurnOff()
        {
            if (isOn)
            {
                isOn = false;
                Console.WriteLine($"{GetType().Name} is turned off.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is already off.");
            }
        }

        public bool IsOn()
        {
            return isOn;
        }
    }

}
