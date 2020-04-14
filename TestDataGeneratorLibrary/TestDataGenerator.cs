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
            int randomNumber = RandomInt(0, 2);

            return((Person.Sex)randomNumber);
        }

        public static Person GenerateRandomPerson(string firstName = null, string lastName = null, int? ageOrNull = null, Person.Sex gender = Person.Sex.Random)
        {

            if (gender.Equals(Person.Sex.Random))
            {
                gender = RandomSex();
            }

            int age;
            

            if (firstName == null)
            {
                if (gender.Equals(Person.Sex.Male))
                {
                    firstName = GetRandomStringFromArray(Person.firstNameMales());
                }
                else
                {
                    firstName = GetRandomStringFromArray(Person.firstNameFemales());
                }
            }

            if (lastName == null)
            {
                if (gender.Equals(Person.Sex.Male))
                {
                    lastName = GetRandomStringFromArray(Person.lastNameMales());
                }
                else
                {
                    lastName = GetRandomStringFromArray(Person.lastNameFemales());
                }
            }
            
            if(ageOrNull == null)
            {
                age = RandomInt(0, 100);
            }
            else
            {
                age = Convert.ToInt32(ageOrNull);
            }
            
            

            Person person = new Person(firstName, lastName, age, gender);
            return person;
        }
    }

}
