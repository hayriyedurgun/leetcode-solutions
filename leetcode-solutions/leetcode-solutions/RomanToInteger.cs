using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_solutions
{
    internal class RomanToInteger
    {
        public int Solution(string s)
        {
            var result = 0;

            var dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            for (int i = s.Length - 2; i <= 0; i--)
            {
                if (s[i] < s[i + 1])
                {
                    result -= s[i];
                }
                else
                {
                    result += s[i];
                }
            }

            return result;
        }

        public int Solution1(string s)
        {
            var result = 0;
            char prev = '\0';

            foreach (var character in s.Reverse())
            {
                switch (character)
                {
                    case 'I':
                        if (prev == 'V' || prev == 'X')
                        {
                            result--;
                        }
                        else
                        {
                            result++;
                        }
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        if (prev == 'L' || prev == 'C')
                        {
                            result -= 10;
                        }
                        else
                        {
                            result += 10;
                        }
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        if (prev == 'M' || prev == 'D')
                        {
                            result -= 100;

                        }
                        else
                        {
                            result += 100;
                        }
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                    default:
                        break;
                }

                prev = character;
            }

            return result;
        }
    }
}
