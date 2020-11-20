using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
                else
                {
                    result -= numbers[i];
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int length = str1.Length;
            if (str2.Length < length)
            {
                length = str2.Length;
            }
            if (str3.Length < length)
            {
                length = str3.Length;
            }
            if (str4.Length < length)
            {
                length = str4.Length;
            }
            return length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int number = number1;
            if (number2 < number) 
            {
                number = number2;
            }
            if (number3 < number)
            {
                number = number3;
            }
            if (number4 < number)
            {
                number = number4;
            }
            return number;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;

            if (sideLength1 + sideLength2 > sideLength3)
            {
                check1 = true;
            }
            if (sideLength1 + sideLength3 > sideLength2)
            {
                check2 = true;
            }
            if (sideLength2 + sideLength3 > sideLength1)
            {
                check3 = true;
            }

            if (check1 && check2 && check3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            int i = 0;
            double j = 0.0;
            bool result = int.TryParse(input, out i);
            if (!result)
            {
                result = double.TryParse(input, out j);
            }
            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    count++;
                }
            }
            if (count > objs.Length / 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            double total = 0;
            double count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count += 1;
                    total += numbers[i];
                }
            }
            if (total == 0)
            {
                return 0;
            }

            return total / count;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int factorial = 1;
            for (int i = number; i > 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
