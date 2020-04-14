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
                randomNumber = 0;
            }

            return randomNumber;
        }

        public static Person.Sex RandomSex()
        {
            int randomNumber = RandomInt(0, 2);

            return((Person.Sex)randomNumber);
        }

        public static Person.Sex GenerateRandomSex(Person.Sex gender)
        {
            if(gender.Equals(Person.Sex.Random))
            {
                gender = RandomSex();
            }

            return gender;
        }

        public static string GenerateRandomFirstName(Person.Sex gender, string firstName = null)
        {
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

            return firstName;
        }

        public static string GenerateRandomLastName(Person.Sex gender, string lastName = null)
        {
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

            return lastName;
        }

        public static int GenerateRandomAge(int? ageOrNull = null)
        {
            int age;

            if (ageOrNull == null)
            {
                age = RandomInt(0, 100);
            }
            else
            {
                age = Convert.ToInt32(ageOrNull);
            }

            return age;
        }
        


        public static Person GenerateRandomPerson(string firstName = null, string lastName = null, int? ageOrNull = null, Person.Sex gender = Person.Sex.Random)
        {
            Person.Sex randomSex = GenerateRandomSex(gender);
            string randomFirstName = GenerateRandomFirstName(randomSex, firstName);
            string randomLastName = GenerateRandomLastName(randomSex, lastName);
            int randomAge = GenerateRandomAge(ageOrNull);

            Person person = new Person(randomFirstName, randomLastName, randomAge, randomSex);
            return person;
        }
    }

}
