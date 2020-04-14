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
                Person person = TestDataGenerator.GenerateRandomPerson();
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.Gender);
            }
            
            

        }
    }
}
