﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLE___Exercice_8
{
    class Program
    {
        enum Week
        {
            Lundi = 1,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        static void Main(string[] args)
        {
            Enum.GetValues(typeof(Week));
            foreach (Week day in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine(day.ToString());
            }

            Console.WriteLine(Enum.GetName(typeof(Week), 4));
            Console.ReadKey();
        }
    }
}
