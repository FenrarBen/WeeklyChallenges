using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var value in vals)
            {
                if (value == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }

            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;

            if (password == null || password.Length < 3)
            {
                return false;
            }

            foreach (char ch in password)
            {
                if (Char.IsUpper(ch))
                {
                    upper = true;
                }
                if (Char.IsLower(ch))
                {
                    lower = true;
                }
                if (Char.IsDigit(ch))
                {
                    number = true;
                }
            }

            if (upper && lower && number)
            {
                return true;
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = words.Length-1; i >=0; i--)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
