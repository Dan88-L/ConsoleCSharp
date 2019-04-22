using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.GroupBy
{

    class Class1
    {

        static void Ma(string[] args)
        {

            // Create a list of pets.
            List<Pet> petsList =
                new List<Pet>{ new Pet { Name="Barley", Age=8.3 },
                       new Pet { Name="Boots", Age=4.9 },
                       new Pet { Name="Whiskers", Age=1.5 },
                       new Pet { Name="Daisy", Age=4.3 } };


            // Group Pet.Age values by the Math.Floor of the age.
            // Then project an anonymous type from each group
            // that consists of the key, the count of the group's
            // elements, and the minimum and maximum age in the group.

            var query = petsList.GroupBy(
                pet => Math.Floor(pet.Age),
                pet => pet.Age,
                (baseAge, ages) => new
                {
                    Key = baseAge,
                    Count = ages.Count(),
                    Min = ages.Min(),
                     Max = ages.Max()
                });

            // Iterate over each anonymous type.
            foreach (var result in query)
            {
                Console.WriteLine("\nAge group: " + result.Key);
                Console.WriteLine("Number of pets in this age group: " + result.Count);
                Console.WriteLine("Minimum age: " + result.Min);
                Console.WriteLine("Maximum age: " + result.Max);
            }

            Console.ReadLine();
        }
    }


    class Pet
    {
        public string Name { get; set; }
        public double Age { get; set; }
    }
}

