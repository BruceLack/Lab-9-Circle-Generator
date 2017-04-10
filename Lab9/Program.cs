using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Circle
    {
        double pi = Math.PI;
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius(double radius)
        {
            return radius;
        }
        public double GetCircumference(double radius)
        {
            double circumference = (2 * pi * radius);
            return circumference;
        }
        public double GetArea(double radius)
        {
            double area = pi * (radius * radius);
            return area;
        }
        public void Write()
        {
            Console.WriteLine("Circumference: " + GetCircumference(radius));
            Console.WriteLine("Area: " + GetArea(radius));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int timesRun = 0;
            Console.WriteLine("Welcome to the Circle Tester!");
            bool run = true;
            while (run == true)
            {
                double radius;
                Console.WriteLine("Please enter a radius.");
                bool valid = double.TryParse(Console.ReadLine(), out radius);
                if (valid == false)
                {
                    Console.WriteLine("I'm sorry, that is not a valid input.");
                }
                else
                {
                    timesRun += 1;
                    Circle myCircle = new Circle(radius);
                    myCircle.Write();
                }
                run = Continue();
            }
            Console.WriteLine("You built " + timesRun + " circles.");
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Continue? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Goodbye");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
              run = Continue();
            }

            return run;
        }
    }
}