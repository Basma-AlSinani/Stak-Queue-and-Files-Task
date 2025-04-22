using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
namespace Stak__Queue_and_Files_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReverseAStringUsingStack();
            EvaluatePostfixExpression();
            //BrowserHistoryNavigation();
        }
        //static void ReverseAStringUsingStack()
        //{
        //    //1. Reverse a String Using Stack
        //    Console.WriteLine("Enter a string:");
        //    string input = Console.ReadLine();
        //    Stack<char> stack = new Stack<char>();//to store charecter

        //    foreach (char c in input)//to enter the charecter into stack by using stack push
        //    {
        //        stack.Push(c);
        //    }
        //    string reversed = "";
        //    while (stack.Count > 0)
        //    {
        //        reversed = reversed + stack.Pop();
        //    }
        //    Console.WriteLine("Reversed string: " + reversed);
        //}

        static void EvaluatePostfixExpression()
        {
            //2.Evaluate Postfix Expression
            Console.WriteLine("Entter Evaluate ");
            string input = Console.ReadLine();
            // Split the input string into individual tokens
            string[] tokens = input.Split();
            // Create a stack to store numerical values for calculations
            Stack<double> stack = new Stack<double>();

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double num))
                {
                    stack.Push(num);
                }
                else
                {
                    double b = stack.Pop();//second 
                    double a = stack.Pop();//first

                    switch (token)
                    {
                        case "+": stack.Push(a + b); break;
                        case "-": stack.Push(a - b); break;
                        case "*": stack.Push(a * b); break;
                        case "/": stack.Push(a / b); break;
                        default:Console.WriteLine("Invaild" + token);
                            return;
                    }
                }
            }
            Console.WriteLine($"Result:{stack.Pop()}");
        }
        static void BrowserHistoryNavigation()
        {
            //3.Browser History Navigation  
            Stack<string> history = new Stack<string>();//stack for browser histoty
            string comand; // Variable to store user input commands
            
            Console.WriteLine("Select Browser Navigation");
            Console.WriteLine("1.Visit Url");
            Console.WriteLine("2.Back");
            Console.WriteLine("3.Exit");
            
            while (true)
            {
              
                


            }
        }

    }
}
