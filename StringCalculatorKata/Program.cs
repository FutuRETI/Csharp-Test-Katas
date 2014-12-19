using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 1. Create a simple String calculator with a method int Add(string numbers).
 * The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0).
 * For example "" or "1" or "1,2"
 * - Start with the simplest test case of an empty string and move to 1 and two numbers
 * - Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
 * - Remember to refactor after each passing test
 * 
 * 2. Allow the Add method to handle an unknown amount of numbers
 * 
 * 3. Allow the Add method to handle new lines between numbers (instead of commas).
 * - the following input is ok: "1\n2,3" (will equal 6)
 * - the following input is NOT ok: "1,\n" (not need to prove it - just clarifying)
 * 
 * 4. Support different delimiters. To change a delimiter, the beginning of the string will contain a separate line that
 * looks like this: [delimiter]\n[numbers...], for example ;\n1;2 should return three where the default delimiter is ; .
 * - the first line is optional. all existing scenarios should still be supported
 * 
 * 5. Calling Add with a negative number will throw an exception "negatives not allowed" - and the negative that was passed.
 * - if there are multiple negatives, show all of them in the exception message
 */
namespace StringCalculatorKata
{
    public class Program
    {
        public int Add(string numbers)
        {
            int result = 0;
           
            if (numbers != null && numbers != "")
            {
                char[] splitters = {',', '\n'};
                string[] vals = numbers.Split(splitters);
                
                foreach (string val in vals)
                {
                    if (val == "")
                    {
                        throw new ProgramException("Wrong input passed.");
                    }

                    int curval = int.Parse(val);
                    if (curval < 0)
                    {
                        throw new ProgramException("Negatives not allowed.");
                    }
                    result += curval;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a numeric argument.");
            string input = System.Console.ReadLine();
            int result = new Program().Add(input);
            System.Console.WriteLine("The result is: " + result + ".");
        }
    }
}
