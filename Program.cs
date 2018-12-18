using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche" };
            foreach (string day in week)
            {
                Console.WriteLine(day);
            }
            week[4] = "Vendredi";
            foreach (string day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}
