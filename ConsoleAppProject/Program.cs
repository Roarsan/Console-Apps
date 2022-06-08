using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Roshan Gauchan 08/03/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("               by Roshan Gauchan                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine("Which app would you like to choose?");
            string input = Console.ReadLine();

            if(input == "1")
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            if(input == "2")
            {
                BMI calculator = new BMI();
                calculator.CalculaterIndex();
            }
            if (input == "3")
            {
                StudentGrades grades = new StudentGrades();
                grades.StudentGradesMenu();
            }
            if (input == "4")
            {
                NewsApp socialApp = new NewsApp();
                socialApp.DisplayMenu();
            }
        }
     
     
    }
}
