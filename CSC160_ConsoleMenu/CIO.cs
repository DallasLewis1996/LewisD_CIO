using System;
using System.Collections.Generic;

namespace CSC160_ConsoleMenu
{
    public static class CIO
    {
        public static int PromptForMenuSelection(IEnumerable<string> options, bool withQuit)
        {
            bool tryAgain = false;
            int choice = 0;
            int i = 1;
            do {
                foreach (string choices in options)
                {
                    Console.WriteLine(i + ". " + choices);
                    i++;
                }
                Console.WriteLine();

                if (withQuit)
                {
                    Console.WriteLine("0. Quit");
                }
                string input = Console.ReadLine();

                try
                {
                    choice = int.Parse(input);
                    
                    if((choice == 0 && !withQuit) || (choice < 0 || choice > i - 1))
                    {
                        tryAgain = true;
                        Console.WriteLine("That input was invalid. Please pick an option between 1 and " + (i-1) + ".");
                        i = 1;
                    }
                    else
                    {
                        tryAgain = false;
                    }
                    
                } catch (FormatException e)
                {
                    Console.WriteLine("That input was invalid. Please pick an option between 1 and " + (i-1) + ".");
                    tryAgain = true;
                    i = 1;
                }
            } while (tryAgain);

            return choice;
        }

        public static bool PromptForBool(string message, string trueString, string falseString)
        {
            bool tryAgain = false;
            bool option;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (input == trueString)
                {
                    tryAgain = false;
                    option = true;
                }
                else if (input == falseString)
                {
                    tryAgain = false;
                    option = false;
                }
                else
                {
                    Console.WriteLine("That was an improper response");
                    tryAgain = true;
                    option = false;

                }
            } while (tryAgain);
            return option;
        }
 

        public static byte PromptForByte(string message, byte min, byte max)
        {
            bool tryAgain = false;
            byte answer = 0;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try
                {
                    answer = byte.Parse(input);
                    if(answer < min || answer > max)
                    {
                        Console.WriteLine("Your byte was outside of the range. Please try a number between " + min + " and " + max);
                        tryAgain = true;
                    }
                    else
                    {
                        tryAgain = false;
                    }
                }
                catch(FormatException e)
                {
                    Console.WriteLine("That was an incorrect response. Please try again.");
                    tryAgain = true;
                }
            } while(tryAgain);
            return answer;
        }

        public static short PromptForShort(string message, short min, short max)
        {
            bool tryAgain = false;
            short answer = 0;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try
                {
                    answer = short.Parse(input);
                    if (answer < min || answer > max)
                    {
                        Console.WriteLine("Your short was outside of the range. Please try a number between " + min + " and " + max);
                        tryAgain = true;
                    }
                    else
                    {
                        tryAgain = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was an incorrect response. Please try again.");
                    tryAgain = true;
                }
            } while (tryAgain);
            return answer;
        }

        public static int PromptForInt(string message, int min, int max)
        {
            bool tryAgain = false;
            int answer = 0;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try
                {
                    answer = int.Parse(input);
                    if (answer < min || answer > max)
                    {
                        Console.WriteLine("Your int was outside of the range. Please try a number between " + min + " and " + max);
                        tryAgain = true;
                    }
                    else
                    {
                        tryAgain = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was an incorrect response. Please try again.");
                    tryAgain = true;
                }
            } while (tryAgain);
            return answer;
        }

        public static long PromptForLong(string message, long min, long max)
        {
            bool tryAgain = false;
            long answer = 0;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try
                {
                    answer = long.Parse(input);
                    if (answer < min || answer > max)
                    {
                        Console.WriteLine("Your long was outside of the range. Please try a number between " + min + " and " + max);
                        tryAgain = true;
                    }
                    else
                    {
                        tryAgain = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was an incorrect response. Please try again.");
                    tryAgain = true;
                }
            } while (tryAgain);
            return answer;
        }

        public static float PromptForFloat(string message, float min, float max)
        {
            bool tryAgain = false;
            float answer = 0;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try
                {
                    answer = float.Parse(input);
                    if (answer < min || answer > max)
                    {
                        Console.WriteLine("Your float was outside of the range. Please try a number between " + min + " and " + max);
                        tryAgain = true;
                    }
                    else
                    {
                        tryAgain = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was an incorrect response. Please try again.");
                    tryAgain = true;
                }
            } while (tryAgain);
            return answer;
        }

        public static double PromptForDouble(string message, double min, double max)
        {
            bool tryAgain = false;
            double answer = 0;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try
                {
                    answer = double.Parse(input);
                    if (answer < min || answer > max)
                    {
                        Console.WriteLine("Your double was outside of the range. Please try a number between " + min + " and " + max);
                        tryAgain = true;
                    }
                    else
                    {
                        tryAgain = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was an incorrect response. Please try again.");
                    tryAgain = true;
                }
            } while (tryAgain);
            return answer;
        }

        public static decimal PromptForDecimal(string message, decimal min, decimal max)
        {
            bool tryAgain = false;
            decimal answer = 0;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try
                {
                    answer = decimal.Parse(input);
                    if (answer < min || answer > max)
                    {
                        Console.WriteLine("Your decimal was outside of the range. Please try a number between " + min + " and " + max);
                        tryAgain = true;
                    }
                    else
                    {
                        tryAgain = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was an incorrect response. Please try again.");
                    tryAgain = true;
                }
            } while (tryAgain);
            return answer;
        }

        public static string PromptForInput(string message, bool allowEmpty)
        {
            bool tryAgain = false;
            string input = "";
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                if (input == "" && !allowEmpty)
                {
                    Console.WriteLine("Empty strings are not allowed. Please try again.");
                    tryAgain = true;
                }
                else
                {
                    tryAgain = false;
                }
            } while (tryAgain);
            return input;
        }

        public static char PromptForChar(string message, char min, char max)
        {
            bool tryAgain = false;
            char cInput = '0';
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                try
                {
                    cInput = char.Parse(input);
                    if(cInput > max || cInput < min)
                    {
                        Console.WriteLine("Your char is outside of the range. Please try a char between " + min + " and " + max + ".");
                        tryAgain = true;
                    }
                    else
                    {
                        tryAgain = false;
                    }

                }
                catch(FormatException e)
                {
                    Console.WriteLine("I'm sorry. That is not a valid response. Please try again.");
                    tryAgain = true;
                }
            } while (tryAgain);
            return cInput;    
        }
    }
}
