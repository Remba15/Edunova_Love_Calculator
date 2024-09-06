using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Edunova_Love_Calculator
{
    public class LoveCalculator
    {
        private List<string> names;

        public LoveCalculator()
        {
            names = new List<string>();
            calculate();
        }

        private void calculate()
        {
            names = Utility.InsertNames();

            string count = CountLetters(names);

            Console.WriteLine(LovePercentage(count));

        }

        private string LovePercentage(string count)
        {
            if (BigInteger.Parse(count) >= 0 && BigInteger.Parse(count) <= 100)
            {
                return count;
            }
            else
            {
                return LovePercentage(PercentageReduction(count));
            }
        }

        private string PercentageReduction(string count)
        {
            StringBuilder reduced = new StringBuilder();
            for (int i = 0; i < (count.Length / 2); i++)
            {
                reduced.Append((count[i] - '0') + (count[count.Length - 1 - i] - '0'));
            }
            if(count.Length % 2 != 0)
            {
                reduced.Append(count[count.Length / 2]);
            }
            return reduced.ToString();
        }

        private string CountLetters(List<string> names)
        {
            StringBuilder joinedNames = new StringBuilder();
            StringBuilder sum = new StringBuilder();
            foreach (string name in names)
            {
                joinedNames.Append(name.ToUpper());
            }

            for (int i = 0; i < joinedNames.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < joinedNames.Length; j++)
                {
                    if (joinedNames[i] == joinedNames[j])
                    {
                        count++;
                    }
                }
                sum.Append(count.ToString());
            }
            return sum.ToString();
        }
    }
}
