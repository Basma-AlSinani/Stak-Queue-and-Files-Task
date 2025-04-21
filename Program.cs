using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
namespace Stak__Queue_and_Files_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void ReverseAStringUsingStack() {
            //1. Reverse a String Using Stack
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();//to store charecter

            foreach (char c in input)//to enter the charecter into stack by using stack push
            {
                stack.Push(c);
            }
            string reversed = "";
            while (stack.Count > 0)
            {
                reversed = reversed + stack.Pop();
            }
            Console.WriteLine("Reversed string: " + reversed);
        }

        static void EvaluatePostfixExpression() { 
            //2.Evaluate Postfix Expression
            Console.WriteLine("Entter Evaluate ");
            string input = Console.ReadLine();
            string[] x = input.Split();
        }
    }
}
