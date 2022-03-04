using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_DB_2 //asdiuvhwoeiuyrvhohrv
{
    internal class birthdate
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public birthdate(bool userInput)
        {
            if (userInput)
            {
                day = GetInput("Skriv dag");
                month = GetInput("Skriv måned");
                year = GetInput("Skriv år");
            }

        } 

        private int GetInput(string message)
        {
            Console.WriteLine(message);
            var y = Console.ReadLine();
            int result = 0;
            try
            {
                result = int.Parse(y);
            }
            catch { }

            return result;
        }

        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }

    }
}
