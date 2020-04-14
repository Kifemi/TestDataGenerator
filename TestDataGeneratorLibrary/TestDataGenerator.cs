using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
        public static string GetRandomStringFromArray(string[] nameList)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(nameList.Length);
            return nameList[randomIndex];
        }

        public static int RandomInt(int min, int max)
        {
            Random rand = new Random();
            int randomNumber = 0;

            if(min <= max)
            {
                randomNumber = rand.Next(min, max);
            }
            else
            {
                Console.WriteLine("Arvon min pitää olla arvoa max pienempi");
            }

            return randomNumber;
        }

        public static Person.Sex RandomSex()
        {
            //string str = "";
            int randomNumber = RandomInt(0, 2);
            //if (Enum.IsDefined(typeof(Person.Sex), randomNumber))
            //{
            //    return ((Person.Sex) randomNumber);
            //}
            //else
            //{
            //    str = "Invalid value";
            //}

            return((Person.Sex)randomNumber);
        }

        public static Person GenerateRandomPerson()
        {
            string firstName = GetRandomStringFromArray(Person.firstNameMales());
            string lastName = GetRandomStringFromArray(Person.lastNameMales());
            int age = RandomInt(0, 100);
            Person.Sex gender = RandomSex();

            Person person = new Person(firstName, lastName, age, gender);
            return person;
        }
    }

}
