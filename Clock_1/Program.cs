using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour_ = Convert.ToInt32(Console.ReadLine());
            int minutes_ = Convert.ToInt32(Console.ReadLine());
            int seconds_ = Convert.ToInt32(Console.ReadLine());

            Clock clock = new Clock (hour_, minutes_, seconds_);

            //Clock clock=new Clock() { hour=hour_, minutes=minute_, seconds=seconds_};
            
            //clock.hour = Convert.ToInt32(Console.ReadLine());
            //clock.minutes = Convert.ToInt32(Console.ReadLine());
            //clock.seconds = Convert.ToInt32(Console.ReadLine());
            int totalSecond = clock.ToSecond () ;
            Console.WriteLine(totalSecond);
            Console.ReadKey();
        }
        

    }

}
