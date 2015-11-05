using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JavaToCS
{
    class Input
    {
        public int GetNumber(string message, int min, int max)
        {
            int tempInt = 0;
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine(message);
                string temp = Console.ReadLine();
                if (!string.IsNullOrEmpty(temp) && Regex.IsMatch(temp, "^[0-9]*$"))
                {
                    tempInt = int.Parse(temp);
                    if ((tempInt >= min) && (tempInt <= max))
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("The number is out of range!");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input! Please enter a number.");
                }
            }
            return tempInt;
        }

        public string GetText(string message)
        {
            Console.WriteLine(message);
            string text = Console.ReadLine();
            return text;
        }
    }
}
