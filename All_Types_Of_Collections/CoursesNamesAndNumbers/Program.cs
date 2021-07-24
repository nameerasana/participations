using System;

namespace CoursesNamesAndNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first course subject (e.g. MIS, MATH, ACCT):");
            string courseSubject1 = Console.ReadLine().ToUpper();


            Console.Write("Please enter your second course subject (e.g. MIS, MATH, ACCT):");
            string courseSubject2 = Console.ReadLine().ToUpper();

            Console.Write("Please enter your third course subject (e.g. MIS, MATH, ACCT):");
            string courseSubject3 = Console.ReadLine().ToUpper();

            string[] subjectsArray = { courseSubject1, courseSubject2, courseSubject3 };


            Console.Write("Please enter your first course number (e.g. 3101, 3202, 2113):");
            int courseNumber1;
            courseNumber1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Please enter your second course number (e.g. 3101, 3202, 2113):");
            int courseNumber2;
            courseNumber2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your third course number (e.g. 3101, 3202, 2113):");
            int courseNumber3;
            courseNumber3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe classes you picked are {courseSubject1}{courseNumber1}, {courseSubject2}{courseNumber2}, {courseSubject3}{courseNumber3}"); ;
        }
    }
}
