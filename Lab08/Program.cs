using System;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will be your driving function that puts everything together
            double num1=1;
            double num2 = 2;
            IsClose(num1, num2);
            
            
            string initalType = "a";
            string convertType = "b";
            string stringNum3 = "c";
            

            double num3 = 3;
            double convertedVariable = 1;

            InchesToCentimeters(num3, initalType, convertType, convertedVariable);

            Console.WriteLine($"Please enter the number in {initalType} to be converted to {convertType}: ");
            Console.WriteLine($"{stringNum3} {initalType} converted to {convertType} is: {convertedVariable}");
        }

        //make a function called IsCLose that takes in two doubles and returns a bool
        static bool IsClose(double num1, double num2)
        {
            Console.WriteLine("Please enter two numbers to see if they are close: ");
            string stringNum1 = Console.ReadLine();
            num1 = double.Parse(stringNum1);
            string stringNum2 = Console.ReadLine();
            num2 = double.Parse(stringNum2);

            if((num1 - num2)  > 1e-4 || (num2 - num1) > 1e-4)
            {
                Console.WriteLine($"{num1} and {num2} are 1e-4 close: false");
                return false;
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are 1e-4 close: true");
                return true;
            }
        }

        //make a function called InchesToCentimeters that takes a double and returns a double
        static double InchesToCentimeters(double num3, string initalType, string convertType, double convertedVariable)
        {
            initalType = "inches";
            convertType = "centimeters";
            convertedVariable = (num3)*(2.54);
            return convertedVariable;
            GetNumberFromUser(num3, initalType, convertType, convertedVariable);

        }
        
        //make a function called YardsToMeters that takes in a double and returns a double
        //make a funciton called MilesToKilometers that takes in a double and returns a double
        //make a function called GetNumberFromUser that takes in a message and returns the value the user inputs
        static double GetNumberFromUser(double num3, string initialType, string convertType, double convertedVariable)
        {
            Console.WriteLine($"{prompt}");
            string stringNum3 = Console.ReadLine();
            num3 = double.Parse(stringNum3);
        } 
        //make a function called DisplayNumberToConsole that takes in a double(the result) AND an output message and writes them out to the console

        static string DisplayNumberToConsole(double num3,)
    }
}
