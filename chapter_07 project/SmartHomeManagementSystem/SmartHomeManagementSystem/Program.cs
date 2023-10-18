using SmartHomeManagementSystem;
using System;

class Program
{
    static void Main(string[] args)
    {
        Light livingRoomLight = new Light();
        Thermostat livingRoomThermostat = new Thermostat();
        SecuritySystem securitySystem = new SecuritySystem();

        securitySystem.AlarmTriggered += (sender, e) => Console.WriteLine("Security breach detected!");

        livingRoomLight.TurnOn();
        livingRoomThermostat.TurnOn();
        securitySystem.TurnOn();

        livingRoomLight.AdjustBrightness(80);
        livingRoomThermostat.SetTemperature(74.5);

        securitySystem.TriggerAlarm();

        Console.WriteLine("Living room light is on: " + livingRoomLight.IsOn());
        Console.WriteLine("Living room thermostat is on: " + livingRoomThermostat.IsOn());
        Console.WriteLine("Security system is on: " + securitySystem.IsOn());
    }
}
