using System;

namespace BiancaStudentProfileApp
{
    // Student Class (Activity 2 requirement)
    class Student
    {
        // Properties
        public string Name { get; set; }
        public int StudentNumber { get; set; }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("     STUDENT PROFILE");
            Console.WriteLine("=================================");
            Console.WriteLine($"Name           : {Name}");
            Console.WriteLine($"Student Number : {StudentNumber}");
            Console.WriteLine("=================================\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("   WELCOME TO BIANCA'S STUDENT PROFILE");
            Console.WriteLine("   (COMP 019 - My First C# Application)");
            Console.WriteLine("=========================================\n");

            // Create Student object
            Student student = new Student();

            // Get input from user
            Console.Write("Enter Your Full Name          : ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Your Student Number     : ");
            student.StudentNumber = int.Parse(Console.ReadLine());

            // Show result
            student.DisplayInfo();

            Console.WriteLine("✅ Student information saved successfully!");
            Console.WriteLine("\nThank you for using my first C# application! 👋");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}