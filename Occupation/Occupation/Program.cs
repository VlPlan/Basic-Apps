using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace Occupation
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Xander", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Malakai", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter),
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist),
                new Person("Erin", "Rocha", 37, Job.Developer),
                new Person("Freddy", "Gordon", 26, Job.Sculptor),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
            };



            // 1. Find and print all persons working as 'Developers' and are younger than 30
            // 2. Find and print all persons names starting with 'E' where Name is longer than 4 characters
            // 3. Find and print all persons lastnames starting with 'R', ordered by Age - ASCENDING ORDER


            foreach (var person in people)
            {
                if (person.Occupation == Job.Developer && person.Age < 30)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}, aged {person.Age} is {person.Occupation} by profession.");
                }

            }
            Console.ReadLine();



            foreach (var person1 in people)
            {

                if (person1.FirstName.StartsWith("E") && person1.FirstName.Length > 4)
                {
                    Console.WriteLine($"{person1.FirstName} starts with E and name is longer than 4 characters.");
                }

            }

            Console.ReadLine();


            foreach (Person person3 in people)
            {
                people.Sort(delegate (Person x, Person y)
                {
                    return x.Age.CompareTo(y.Age);
                });

                if (person3.LastName.StartsWith("R"))

                {


                    Console.WriteLine($"{person3.LastName} starts with R and age is {person3.Age}");

                }

            }
            Console.ReadLine();
        }
    }
    }

