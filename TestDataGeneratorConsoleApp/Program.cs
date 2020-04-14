using System;
using TestDataGeneratorLibrary;

namespace TestDataGeneratorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Person person1 = TestDataGenerator.GenerateRandomPerson(null, null, null, Person.Sex.Random);
                Console.WriteLine(person1.FirstName);
                Console.WriteLine(person1.LastName);
                Console.WriteLine(person1.Age);
                Console.WriteLine(person1.Gender);
                Console.WriteLine("\n");
            }
            

        }
    }
}
