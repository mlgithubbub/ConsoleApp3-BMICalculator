using System;

namespace ConsoleApp3_BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Function to request height input and parse from string to integer
            int height = inputHeight();
            //Function to request weight input and parse from string to integer
            int weight = inputWeight();
            //Function to calculate the BMI from height and weight
            double BMI = calculateBMI(height, weight);
            //Function to determine weight category
            DetermineWeightCategory(BMI);
        }

        private static int inputHeight()
        {
            Console.WriteLine("Please input your height in cm:");
            string heightString = Console.ReadLine();
            int height = int.Parse(heightString);
            return height;
        }

        private static int inputWeight()
        {
            Console.WriteLine("Please input your weight in kg:");
            string weightString = Console.ReadLine();
            int weight = int.Parse(weightString);
            return weight;
        }

        private static double calculateBMI(int height, int weight)
        {
            //Divide weight by height to the second power, multiply the result by 10 thousand,
            //and display 2 spaces after the decimal point
            double BMI = Math.Round((weight / Math.Pow(height, 2)) * 10000.00, 2);

            Console.WriteLine($"Your body mass index is: {BMI}.");

            return BMI;
        }

        private static void DetermineWeightCategory(double BMI)
        {
            if (BMI < 16)
            {
                Console.WriteLine("You have: Starkes Untergewicht");
            }
            else if (BMI >= 16 && BMI < 17)
            {
                Console.WriteLine("You have: Mäßiges Untergewicht");
            }
            else if (BMI >= 17 && BMI < 18.5)
            {
                Console.WriteLine("You have: Leichtes Untergewicht");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("You have: Normalgewicht");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("You have: Präadipositas");
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("You have: Adipositas Grad I");
            }
            else if (BMI >= 35 && BMI < 40)
            {
                Console.WriteLine("You have: Adipositas Grad II");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("You have: Adipositas Grad III");
            }
        }
    }
}