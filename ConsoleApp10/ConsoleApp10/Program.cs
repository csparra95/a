using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ConsoleApp10
{

    public class GeneralValidator
    {
        
        bool Success;
        private ResultMessage ValidateString(string str, char[] specialChars, Func<char, bool> fn, bool acceptSpace = true)
        {
            ResultMessage result = new ResultMessage();
            List<char> tempStr = str.ToList();

            if (acceptSpace)
            {
                tempStr.RemoveAll(c => c == ' ');
            }

            if (specialChars != null)
            {
                tempStr.RemoveAll(c => specialChars.Contains(c));
            }

            Success = tempStr.All(c => fn(c));
            
            Console.WriteLine(result);
            Console.ReadKey();
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
