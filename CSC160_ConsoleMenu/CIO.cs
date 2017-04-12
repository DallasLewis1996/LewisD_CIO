using System;
using System.Collections.Generic;

namespace CSC160_ConsoleMenu
{
    public static class CIO
    {
        public static int PromptForMenuSelection(IEnumerable<string> options, bool withQuit)
        {
            throw new NotImplementedException();
        }

        public static bool PromptForBool(string message, string trueString, string falseString)
        {
            bool tryAgain = false;
            bool option ;
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
            throw new NotImplementedException();
        }
 

        public static byte PromptForByte(string message, byte min, byte max)
        {
            throw new NotImplementedException();
        }

        public static short PromptForShort(string message, short min, short max)
        {
            throw new NotImplementedException();
        }

        public static int PromptForInt(string message, int min, int max)
        {
            throw new NotImplementedException();
        }

        public static long PromptForLong(string message, long min, long max)
        {
            throw new NotImplementedException();
        }

        public static float PromptForFloat(string message, float min, float max)
        {
            throw new NotImplementedException();
        }

        public static double PromptForDouble(string message, double min, double max)
        {
            throw new NotImplementedException();
        }

        public static decimal PromptForDecimal(string message, decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public static string PromptForInput(string message, bool allowEmpty)
        {
            throw new NotImplementedException();
        }

        public static char PromptForChar(string message, char min, char max)
        {
            throw new NotImplementedException();
        }
    }
}
