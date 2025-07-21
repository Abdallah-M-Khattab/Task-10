using EFcore.DataAccess;
using EFcore.Models;

namespace EFcore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ApplicationDBcontext();

            Console.WriteLine("Student System Console");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Add new course");
            Console.Write("Your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent(context);
                    break;
                case "2":
                    AddCourse(context);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        static void AddStudent(ApplicationDBcontext context)
        {
            Console.Write("Student name: ");
            string name = Console.ReadLine();

            var student = new Student
            {
                Name = name,
                RegisteredOn = DateTime.Now
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully.");
        }

        static void AddCourse(ApplicationDBcontext context)
        {
            Console.Write("Course name: ");
            string name = Console.ReadLine();

            Console.Write("Start date (yyyy-MM-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("End date (yyyy-MM-dd): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            var course = new Course
            {
                Name = name,
                StartDate = startDate,
                EndDate = endDate,
                Price = price
            };

            context.Courses.Add(course);
            context.SaveChanges();

            Console.WriteLine("Course added successfully.");
        }
    }
}
