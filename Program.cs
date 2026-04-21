using System;

// Delegate declaration (outside class or inside Program)
public delegate int MathOperation(int a, int b);

// Class containing methods
public class DelegateDemo
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        MathOperation operation = DelegateDemo.Add;
        Console.WriteLine("Delegate ref is created and currently it is pointing to Add()");

        int result = operation(10, 5);
        Console.WriteLine("Since Delegate is pointing to Add() so the result of Addition is " + result);

        // Subtract
        operation = DelegateDemo.Subtract;
        Console.WriteLine("Now the delegate ref is changed and currently it is pointing to Subtract()");

        result = operation(10, 5);
        Console.WriteLine("Since Delegate is pointing to Subtract() so the result of Subtraction is " + result);

        // Multiply
        operation = DelegateDemo.Multiply;
        Console.WriteLine("Now the delegate ref is changed and currently it is pointing to Multiply()");

        result = operation(10, 5);
        Console.WriteLine("Since Delegate is pointing to Multiply() so the result of Multiplication is " + result);

        Console.ReadLine();
    }
}