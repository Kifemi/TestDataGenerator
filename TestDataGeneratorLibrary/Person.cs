using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    

    public class Person
    {
        // Properties
        public enum Sex
        {
            Male,
            Female,
            Random
        }

        private string firstName;
        private string lastName;
        private int age;
        private Sex gender;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Sex Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        // Constructor
        public Person(string firstName, string lastName, int age, Sex gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }

        // Name lists
        public static string[] firstNameMales()
        {
            string[] maleNames = { "Johnny", "Jack", "Brad", "Tom", "Bruce", "Harrison", "Michael", "Clint" };
            return maleNames;
        }

        public static string[] lastNameMales()
        {
            string[] maleLastNames = { "Depp", "Nicholson", "Pitt", "Hanks", "Lee", "Ford", "Jackson", "Eastwood" };
            return maleLastNames;
        }

        public static string[] firstNameFemales()
        {
            string[] femaleFirstNames = { "Anne", "Scarlett", "Angelina", "Cameron", "Jennifer", "Marilyn", "Audrey" };
            return femaleFirstNames;
        }

        public static string[] lastNameFemales()
        {
            string[] femaleLastNames = { "Hathaway", "Johansson", "Jolie", "Diaz", "Aniston", "Monroe", "Hepburn" };
            return femaleLastNames;
        }
    }
}
