using System;

namespace PeopleLibrary
{
    public abstract class Person
    {
        public int age { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        
        public Person()
        {
            age = 0;
            firstName = "John";
            lastName = "Doe";
        }
        public Person(int a, string f, string l)
        {
            age = a;
            firstName = f;
            lastName = l;
        }

        public void printName()
        {
            Console.WriteLine("Hello my name is {0} {1}" , firstName, lastName);
        }
    }
    
    public class Student : Person
    {
        public int grade { get; set; }

        
        public Student(int a, string f, string l, int g)
        {
            this.age = a;
            this.firstName = f;
            this.lastName = l;
            grade = g;
        }

        public void displayGrade()
        {
            Console.WriteLine("{0} {1} Grade: {2}" , this.firstName, this.lastName, this.grade);
        }
    }
}
