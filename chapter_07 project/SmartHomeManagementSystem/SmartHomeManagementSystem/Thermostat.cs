namespace SmartHomeManagementSystem
{
    public class Thermostat : Appliance
    {
        private double temperature;

        public Thermostat()
        {
            temperature = 72.0; // Default temperature in Fahrenheit
        }

        public void SetTemperature(double temp)
        {
            if (IsOn())
            {
                temperature = temp;
                Console.WriteLine($"{GetType().Name} temperature set to {temperature}°F.");
            }
            else
            {
                Console.WriteLine("Cannot set temperature. Thermostat is off.");
            }
        }
    }

}
