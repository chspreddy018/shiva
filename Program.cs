using System;
using SplashKitSDK;

namespace hellouser
{
    public class Program
    {
        public static void Main()
        {
            string? name;
            string? inputText;
            int heightinCM;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("my name is "+name);

            Console.Write("Enter your height in cms");
            inputText=Console.ReadLine();
            heightinCM=Convert.ToInt32(inputText);
            double heightInMeters=heightinCM/100.00;
            Console.WriteLine($"your height in meters is {heightInMeters}");

            Console.Write("enter your weight in kg");
            inputText=Console.ReadLine();
            double weightInKG=Convert.ToDouble(inputText);
            Console.WriteLine($"your weight is {weightInKG} kg");

            double bmi=weightInKG/Math.Pow(heightInMeters,2);
            Console.WriteLine($"your bmi is {bmi}");
        }
    }
}
