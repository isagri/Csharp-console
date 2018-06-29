using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Message
    {
        private string message;
        private int hourJour;
        private int hourAprem;
        private int hourSoir;

        public Message(int hourJour=9, int hourAprem=13, int hourSoir=18)
        {
            this.hourJour = hourJour;
            this.hourAprem = hourAprem;
            this.hourSoir = hourSoir;
        }

        public string GetHelloMessage(DateTime date1)
        {
            if (date1.DayOfWeek == DayOfWeek.Saturday ||
                date1.DayOfWeek == DayOfWeek.Sunday ||
                (date1.DayOfWeek == DayOfWeek.Friday && date1.Hour >= 18) ||
                (date1.DayOfWeek == DayOfWeek.Monday && date1.Hour < 9))
            {

                message = "Bon Weekend " + Environment.UserName;
            }
            else
            {
                if (date1.Hour >= hourJour && date1.Hour < hourAprem)
                {
                    message = "Bonjour " + Environment.UserName;
                }
                else if (date1.Hour >= hourAprem && date1.Hour < hourSoir)
                {

                    message = "Bon Après-midi " + Environment.UserName;

                }
                else
                {
                    message = "Bonsoir " + Environment.UserName;
                }
            }
            return this.message;

        }
    }
}

