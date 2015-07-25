using System;
using System.Windows.Forms;

namespace Asynchronous_Timer
{
    class Program
    {

        private static int count = 1;

        public static void Main()
        {
            Console.WriteLine("Enter the number of times for the repeated action:");
            int ticks = 100000;//int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the interval between repetitions(in milliseconds):");
            double interval = 1;//double.Parse(Console.ReadLine());
            Console.WriteLine("Press the 'Esc' key if you want to stop the program!");

            Action act = Print;
            AsyncTimer timer = new AsyncTimer(act, ticks, interval);
            timer.Run();

            int i = 1;
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.WriteLine("I'm an unstopable Main method {0}", i++);
            }
        }

        private static void Print()
        {
            Console.WriteLine((string.Format("->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Count: {0}<<<<<<<<<<<<<<<<<<<<<<<<", count++)));
        }
    }

}
