using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {        
            TemperatureSensor sensor = new TemperatureSensor();
            TemperatureReporter reporter = new TemperatureReporter();
            DateTime localDate = DateTime.Now;
            Temperature a = new Temperature(20, localDate);;
            sensor.GetTemperature(); 
        }
    }
}
