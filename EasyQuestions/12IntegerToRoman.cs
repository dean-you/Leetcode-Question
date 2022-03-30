using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _12IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var sb = new StringBuilder();
            var thousand = num - num % 1000;
            var hundred = num % 1000 - num % 100;
            var tens = num % 100 - num % 10;
            var ones = num % 10 - num % 1;
            var count = 0;

            if (thousand > 0)
            {
                count = thousand / 1000;
                RepeatLetter(count, sb, 'M');
            }

            if (hundred > 0)
            {
                count = hundred / 100;

                if (1 <= count && count <= 3)
                    RepeatLetter(count, sb, 'C');
                else if (count == 4)
                    sb.Append("CD");
                else if (count == 5)
                    sb.Append("D");
                else if (6 <= count && count <= 8)
                {
                    sb.Append('D');
                    RepeatLetter(count-5, sb, 'C');
                }
                else if (count == 9)
                    sb.Append("CM");
            }

            if (tens > 0)
            {
                count = tens / 10;
                if (1 <= count && count <= 3)
                    RepeatLetter(count, sb, 'X');
                else if (count == 4)
                    sb.Append("XL");
                else if (count == 5)
                    sb.Append("L");
                else if (6 <= count && count <= 8)
                {
                    sb.Append('L');
                    RepeatLetter(count - 5, sb, 'X');
                }
                else if (count == 9)
                    sb.Append("XC");
            }

            if (ones > 0)
            {
                count = ones;
                if (1 <= count && count <= 3)
                    RepeatLetter(count, sb, 'I');
                else if (count == 4)
                    sb.Append("IV");
                else if (count == 5)
                    sb.Append("V");
                else if (6 <= count && count <= 8)
                {
                    sb.Append('V');
                    RepeatLetter(count - 5, sb, 'I');
                }
                else if (count == 9)
                    sb.Append("IX");
            }

            return sb.ToString();
        }

        private static void RepeatLetter(int count, StringBuilder sb, char c)
        {
            for (int i = 0; i < count; i++)
            {
                sb.Append(c);
            }
        }


        private static readonly string[][] table =
        {
            //       0    1     2      3     4    5     6      7       8     9
            new[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" },
            new[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" },
            new[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" },
            new[] { "", "M", "MM", "MMM" },
        };

        public string IntToRoman1(int num)
        {
            var sb = new StringBuilder(15);
            var step = 0;
            while (num > 0)
            {
                var digit = num % 10;
                sb.Insert(0, table[step][digit]);
                num = num / 10;
                step++;
            }

            return sb.ToString();
        }

        public string IntToRoman2(int num)
        {
            var roman = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };

            var sb = new StringBuilder();

            foreach (var item in roman)
            {
                while (num >= item.Key)
                {
                    sb.Append(item.Value);
                    num -= item.Key;
                }
            }

            return sb.ToString();
        }
    }
}
