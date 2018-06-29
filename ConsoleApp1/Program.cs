using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date1 = new DateTime(2018, 6, 17, 11, 30, 0);
            //WriteLine(date1);

            Console.WriteLine("Veuillez saisir une date ou 'exit' pour sortir : ");
            String entree = Console.ReadLine();
            DateTime date1;
            while (entree != "exit")
            {
                date1 = DateTime.Parse(entree);
                WriteLine(date1);

                Message message = new Message(9, 13, 18);
                //Message message = new Message(8, 12, 19);
                Console.WriteLine(message.GetHelloMessage(date1));

                Console.WriteLine("Veuillez saisir une date ou 'exit' pour sortir : ");
                entree = Console.ReadLine();
            }
        }
    }
}

