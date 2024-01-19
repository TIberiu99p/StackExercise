using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    public class Program
    {
        static bool AreBracketsOrdered(string[] exp)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var bracket in exp)
            {
                char currentBracket = bracket[0];

                if (IsOpeningBracket(currentBracket))
                {
                    stack.Push(currentBracket);
                }
                else
                {
                    if (stack.Count == 0 || !AreMatchingBrackets(stack.Pop(), currentBracket))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0; // If the stack is empty, brackets are ordered
        }

        static bool IsOpeningBracket(char bracket)
        {
            return bracket == '(' || bracket == '{' || bracket == '[';
        }

        static bool AreMatchingBrackets(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }

        static void Main()
        {
            string[] exp = new string[] { "(", "{", "[", "]", "}", ")" };
            bool isOrdered = AreBracketsOrdered(exp);

            if (isOrdered)
            {
                Console.WriteLine("Ordered");
            }
            else
            {
                Console.WriteLine("Not Ordered");
            }
            Console.ReadLine();
        }
    }
}
