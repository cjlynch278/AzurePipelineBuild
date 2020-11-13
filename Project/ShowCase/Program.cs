using System;
using UtilityLibraries;
using PeopleLibrary;

namespace ShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(12, "Tom", "Sawyer", 67);
            student.printName();
            student.displayGrade();
            if(student.grade.divisibleByTwo())
                Console.Write("This grade is divisible by two");
            else
                Console.Write("This grade is not divisible by two");
            
        }
    }
}
