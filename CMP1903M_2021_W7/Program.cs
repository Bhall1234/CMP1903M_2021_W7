using System;
using System.Collections.Generic;
using System.Linq;

namespace CMP1903M_2021_W7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Detached = 1, semi = 2, terrace = 3, unknown = 4
            List<House> houses = new List<House>();
            houses.Add(new House(1, "1, The Street, Lincoln, Lincolnshire, LN1 0AB", 100000, 4, true, 2 ));
            houses.Add(new House(2, "5, The Street, Lincoln, Lincolnshire, LN1 0AB", 130000, 4, true, 1));

            foreach(House h in houses)
            {
                Console.WriteLine($"Address: {h.Address}");
                Console.WriteLine($"Value: {h.Value}");
                Console.WriteLine($"Type of Property: {h.propertyType}");
                Console.WriteLine();
            }

            var result = from h in houses
                         where h.propertyType == Enums.PType.SemiDetached
                         select h;

            foreach(House h in result)
            {
                Console.WriteLine($"Address: {h.Address}");
                Console.WriteLine($"Value: {h.Value}");
                Console.WriteLine($"Type of Property: {h.propertyType}");
                Console.WriteLine();
            }

        }
    }
}
