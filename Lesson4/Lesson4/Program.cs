using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = Convert.ToInt32(Console.ReadLine());
            int time = 10;
            int waitingHour = (people * time)/60 ;
            int waitingMinute = (people * time) % 60;
            Console.WriteLine(waitingHour+" часа "+waitingMinute+" минут");
        }
    }
}
