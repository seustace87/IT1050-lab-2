
//displaying the sum of two numbers input from the keyboard

using System;

public class Addition
{
    // main method being executed by c# application
    public static void Main(string[] args)
    {
        Console.WriteLine("{0}/n{1}", "Hello World! from Sean Eustace");
        Console.WriteLine("{0}/t{1}", "Hello World! from Sean Eustace");
        int number1;//declare first number to add
        int number2;//declare second number to add
        int sum; //declare sum of both numbers

        Console.Write("Enter first integer");//promt user
                                             //read first number from user
        number1 = Convert.ToInt32(Console.ReadLine()); //declare first number to add

        Console.Write("Enter second integer");//promt user
                                              //read second number
        number2 = Convert.ToInt32(Console.ReadLine()); //declare second number to add

        sum = number1 + number2; //add numbers

        Console.WriteLine("Sum is {0}", sum); //display sum

    }
}
