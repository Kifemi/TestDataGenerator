using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
        // Picks and returns a random string from the array.
        public static string GetRandomStringFromArray(string[] nameList)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(nameList.Length);
            return nameList[randomIndex];
        }

        // Picks and returns a random integer, which is larger than min and less than max arguments. Prints error message if min is larger than max.
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

        // Picks a random gender. Options are male and female.
        public static Person.Sex RandomSex()
        {
            int randomNumber = RandomInt(0, 2);

            return((Person.Sex)randomNumber);
        }

        // Generates a random gender depending from the given argument. 
        // If the argument is Sex.Random then the options are male and female, otherwise the methods returns the argument without modifying it.
        public static Person.Sex GenerateRandomSex(Person.Sex gender)
        {
            if(gender.Equals(Person.Sex.Random))
            {
                gender = RandomSex();
            }

            return gender;
        }

        // Picks a random name from the given list depending on the gender.
        public static string GetRandomNameFromList(Person.Sex gender, string[] maleNameList, string[] femaleNameList)
        {
            string name = "";

            if (gender.Equals(Person.Sex.Male))
            {
                name = GetRandomStringFromArray(maleNameList);
            }
            else
            {
                name = GetRandomStringFromArray(femaleNameList);
            }

            return name;
        }

        // If optional parameter firstName is given, then the method returns the argument without modifying it.
        // Otherwise it picks and returns a random first name depending on gender argument. If gender is male, then the method uses list of male names and vice versa.
        public static string GenerateRandomFirstName(Person.Sex gender, string firstName = null)
        {
            if (firstName == null)
            {
                firstName = GetRandomNameFromList(gender, Person.firstNameMales(), Person.firstNameFemales());
            }

            return firstName;
        }

        // If optional parameter lastName is given, then the method returns the argument without modifying it.
        // Otherwise it picks and returns a random last name depending on gender argument. If gender is male, then the method uses list of male names and vice versa.
        public static string GenerateRandomLastName(Person.Sex gender, string lastName = null)
        {
            if (lastName == null)
            {
                lastName = GetRandomNameFromList(gender, Person.lastNameMales(), Person.lastNameFemales());
            }

            return lastName;
        }

        // If optional parameter is given, then the method returns the argument without modifying it.
        // Otherwise the method picks and returns a random integer between 0 and 100.
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


        // Creates and returns People object with randomized attributes.
        public static Person GenerateRandomPerson(string firstName = null, string lastName = null, int? ageOrNull = null, Person.Sex gender = Person.Sex.Random)
        {
            Person.Sex randomSex = GenerateRandomSex(gender);
            string randomFirstName = GenerateRandomFirstName(randomSex, firstName);
            string randomLastName = GenerateRandomLastName(randomSex, lastName);
            int randomAge = GenerateRandomAge(ageOrNull);

            Person person = new Person(randomFirstName, randomLastName, randomAge, randomSex);
            return person;
        }

        public static List<Person> GenerateListOfRandomPeople(int amount)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < amount; i++)
            {
                people.Add(GenerateRandomPerson());
            }

            return people;
        }
    }

}
