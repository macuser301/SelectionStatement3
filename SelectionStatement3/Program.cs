using System;

namespace SelectionStatement3
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 4;
            switch (day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;


                    
            }
                   
            

         

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number.");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("Too low !");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too High ");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Correct"!);
            }

            Console.WriteLine("What's your favorite subject math or english?");
            var response = Console.ReadLine();
            switch (response)
            {
                case "math":
                    Console.WriteLine("Math is cool"!);
                    break;
                case "english":
                    Console.WriteLine("That's cool but I cant read!");
                    break;
                default:
                    Console.WriteLine("Never heard of that one!");
                    break;

            }

            if (response == "math")
            {
                Console.WriteLine("But, Math is for fools!");
            }
            else if (response == "english")
            {

                Console.WriteLine("I hate learning English!");
            }
            else
            {
                Console.WriteLine("That's an unusual topic!");
            }

            Console.WriteLine(myBmi(600, 5.667));

            double radius2, area;
            Console.WriteLine("Enter the radius of the circle");
            radius2 = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius2 * radius2;
            Console.WriteLine("Area of the Circle with radius {0} is {1}", radius2, area);
            Console.WriteLine("Please type any key to find the area of your second circle.");
            Console.ReadKey();



            Console.WriteLine("Please enter radius of your circle.");
            var userInput2 = Console.ReadLine();
            var radius = double.Parse(userInput2);
            Console.WriteLine(CalculateArea(radius));







        }
        public static double CalculateArea(double radius)
        {



            var area = Math.PI * Math.Pow(radius, 2);



            return area;
        }
        public static string myBmi(double weight, double height)
        {



            var myBmi = weight / (height * height);
            if (myBmi <= 18.5)
            {
                return "Underweight";
            }
            if (myBmi <= 25.0)
            {
                return "Normal";
            }
            if (myBmi <= 30.0)
            {
                return "Overweight";

            }
            else
            {
                return "Obese";

            }




           
            




        }
                
    }     
}
