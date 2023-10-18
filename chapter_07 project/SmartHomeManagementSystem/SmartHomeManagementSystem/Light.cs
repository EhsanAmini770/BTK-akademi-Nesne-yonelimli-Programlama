namespace SmartHomeManagementSystem
{
    public class Light : Appliance
    {
        private int brightness;

        public Light()
        {
            brightness = 0;
        }

        public void AdjustBrightness(int level)
        {
            if (IsOn())
            {
                if (level >= 0 && level <= 100)
                {
                    brightness = level;
                    Console.WriteLine($"{GetType().Name} brightness set to {brightness}%.");
                }
                else
                {
                    Console.WriteLine("Invalid brightness level. Please choose a value between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Cannot adjust brightness. Light is off.");
            }
        }
    }

}
