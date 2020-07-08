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
            int doctorAppointment = 10;
            int waitingHour = (people * doctorAppointment)/60 ;
            int waitingMinute = (people * doctorAppointment) % 60;
            Console.WriteLine(waitingHour+" часа "+waitingMinute+" минут");
        }
    }
}
