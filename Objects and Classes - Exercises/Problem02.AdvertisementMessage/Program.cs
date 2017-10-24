﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] phares = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string [] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int PhraseIndex = rnd.Next(0, phares.Length);
                int EventIndex = rnd.Next(0, events.Length);
                int AuthorIndex = rnd.Next(0, authors.Length);
                int CityIndex = rnd.Next(0, cities.Length);


                Console.WriteLine(phares[PhraseIndex] + " " + events[EventIndex] + " " + authors[AuthorIndex] + " - " + cities[CityIndex]);
            }
        }
    }
}
