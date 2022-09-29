using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }



        }

        public int Sum(int[] numbers)
        {
            var total = 0;
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;


        }

        public int SumEvens(int[] numbers)
        {
            var sumOfEvens = 0;
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvens += numbers[i];
                } 
            }
            return sumOfEvens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var sumOdd = 0;
            if (numbers == null || !numbers.Any())
            {
                return false;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                sumOdd += numbers[i];
            }
            if (sumOdd % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number >= 0)
            {

                return number / 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
