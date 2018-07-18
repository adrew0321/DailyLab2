using System;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program will calculate the perimeter and area of various classrooms at Grand Circus. */


            //input
            double length = 0;
            double width = 0;
            double height = 0;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator! Press the ENTER Key to continue");
            Console.ReadLine();

            //programming
            bool repeat1 = true;
            while (repeat1)
            {

                bool repeat2 = true;
                while (repeat2)
                {

                    //Length
                    Console.WriteLine("Enter Length: ");
                    try
                    {
                        length = double.Parse(Console.ReadLine());
                        repeat2 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Response! Please insert a number");
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("Invalid Response! Please insert a number");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Critical Error: {e.Message}");

                    }

                }


                bool repeat3 = true;
                while (repeat3)
                {

                    //Width
                    Console.WriteLine("Enter Width: ");
                    try
                    {
                        width = double.Parse(Console.ReadLine());
                        repeat3 = false;

                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("Invalid Response! Please insert a number");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Response!");
                    }
                }

                bool repeat4 = true;
                while (repeat4)
                {
                    //Height
                    Console.WriteLine("Enter Height: ");
                    try
                    {
                        height = double.Parse(Console.ReadLine());
                        repeat4 = false;

                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("Invalid Response! Please insert a number");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Response!");
                    }
                }

                //Output
                Console.WriteLine($"Area: {Area(length, width)}ft.");
                Console.WriteLine($"Perimeter: {Perimeter(length, width)}ft.");
                Console.WriteLine($"Volume: {Volume(length, width, height)}");

                bool repeat5 = true;

                while (repeat5)
                {
                    Console.WriteLine("Continue? (y/n)");
                    string userResponse = Console.ReadLine();

                    if (userResponse == "Y" || userResponse == "y")
                    {
                        repeat1 = true;
                        repeat5 = false;
                    }
                    else if (userResponse == "n" || userResponse == "N")
                    {
                        Console.WriteLine("Ending Program...");
                        repeat1 = false;
                        repeat5 = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Response! Please try again.");
                        repeat5 = true;
                    }

                }



            }

        }

        //Caculates Area
        private static double Area(double length, double width)
        {
            double area = length * width;
            return area;
        }

        //Calculates Perimeter
        private static double Perimeter(double length, double width)
        {
            double perimeter = 2 * (length + width);
            return perimeter;
        }

        //Calculates Volume
        private static double Volume(double length, double width, double height)
        {
            double volume = length * width * height;
            return volume;
        }


    }

}

