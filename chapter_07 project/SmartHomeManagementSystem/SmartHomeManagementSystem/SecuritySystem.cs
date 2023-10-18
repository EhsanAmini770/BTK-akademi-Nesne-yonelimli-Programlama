namespace SmartHomeManagementSystem
{
    public class SecuritySystem : Appliance
    {
        public event EventHandler AlarmTriggered;

        public void TriggerAlarm()
        {
            if (IsOn())
            {
                Console.WriteLine("Security alarm is triggered!");
                AlarmTriggered?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Cannot trigger the alarm. Security system is off.");
            }
        }
    }

}
