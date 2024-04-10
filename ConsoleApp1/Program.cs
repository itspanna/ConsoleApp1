using System;
using System.IO;
using System.Linq;
using ConsoleApp1.Models;
using ConsoleApp1.Data;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                // Lekérjük az adatokat az adatbázisból
                var entities = context..ToList();

                Console.WriteLine("Az adattáblában szereplő adatok:");
                foreach (var entity in entities)
                {
                    Console.WriteLine(entity.ToString()); 
                }
            }
        }
    }
}

