using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_24_ClassFields_exercises_in_c_sharp
{
    internal class Program
    {
        class Person
        {
            private string firstName;
            private string lastName;
            private int age;
            private int birthYear;
            private string nationality;

            public Person(string firstName, string lastName, int age, int birthYear, string nationality)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.birthYear = birthYear;
                this.nationality = nationality;

            }
            public void SetFirstName(string firstName)
            {
                this.firstName = !string.IsNullOrEmpty(firstName) ? firstName : "Invalid First Name";

            }
            public void SetLastName(string lastName)
            {
                this.lastName = !string.IsNullOrEmpty(lastName) ? lastName : "Invalid Last Name";

            }

            public void SetAge(int age)
            {
                this.age = age >= 0 && age <= 150 ? age : -1;
            }

            public void SetBirthYear(int birthYear)
            {
                this.birthYear = birthYear >= 0 && birthYear <= 150 ? birthYear : -1;
            }

            public void SetNationality(string nationality)
            {
                this.nationality = !string.IsNullOrEmpty(nationality) ? nationality : "Invalid nationality";

            }

            public int GetAge()
            {
                return age;
            }

            public int GetBirthYear()
            {
                return birthYear;
            }

            public string GetFirstName()
            {
                return firstName;
            }

            public string GetLastName()
            {
                return lastName;
            }

            public string GetNationality()
            {
                return nationality;
            }
            public string Details()
            {
                return $"Name: {firstName}, Last name: {lastName}, Age: {age}, Birth Year: {birthYear}, Nationality: {nationality}";
            }

        }
        static void Main(string[] args)
        {
            Person person = new Person("Tim", "Rivera", 30, 1995, "American");
            Console.WriteLine(person.Details());
        }
    }
}