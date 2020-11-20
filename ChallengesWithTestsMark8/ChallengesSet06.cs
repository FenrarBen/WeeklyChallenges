using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            foreach (var thisWord in words)
            {
                if (thisWord == word)
                {
                    return true;
                }

                if (ignoreCase)
                {
                    if (thisWord != null)
                    {
                        if (thisWord.ToLower() == word.ToLower())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = num / 2; i > 2; i--)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                bool unique = true;
                for (int j = str.Length - 1; j >= 0; j--)
                {
                    if (str[i] == str[j])
                    {
                        if (i != j)
                        {
                            unique = false;
                        }
                    }
                }
                if (unique)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;
                while (i + 1 < numbers.Length && numbers[i] == numbers[i+1])
                {
                    count++;
                    i++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n < 1 || elements == null)
            {
                return new double[0];
            }
            double[] numbers = new double[elements.Count / n];
            int index = 0;
            for (int i = n - 1; i < elements.Count; i += n)
            {
                numbers[index] = elements[i];
                index++;
            }
            return numbers;
        }
    }
}
