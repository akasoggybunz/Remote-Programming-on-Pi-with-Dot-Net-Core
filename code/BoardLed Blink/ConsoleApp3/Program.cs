using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Open the green led on Raspberry Pi.
            using BoardLedAdded led = new BoardLedAdded("led0");

            string defaultTrigger = led.Trigger;

            // LED can be controlled only if the trigger is set to none.
            led.Trigger = "none";

            // Do your job.
            for (int i = 0; i < 10; i++)
            {
                // Because the Raspberry Pi LED does not support dimming, brightness values greater than 0 can turn the LED on.
                led.Brightness = 1;
                Thread.Sleep(500);

                led.Brightness = 0;
                Thread.Sleep(500);
            }

            // Give the control of led to the kernel.
            led.Trigger = defaultTrigger;
        }
    }
}
