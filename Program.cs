﻿using System;

namespace Luckysevens
{
    class Program
    {
        static void Main(string[] args)
        {
         int totalnumberofsevens = 0;
         Random rng = new Random();

         int die1;
         int die2;
          
         for (int i = 1; i <= 100; i++)
            {
                die1 = rng.Next(1, 7);
                die2 = rng.Next(1,7);

                if(die1 + die2 == 7)
                 totalnumberofsevens++;
            }
        Console.WriteLine("Out of 100 rolls, you rolled {0} Sevens", totalnumberofsevens);
        Console.ReadLine();
        }
    } 
}
