using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edunova_Love_Calculator
{
    public static class Utility
    {
        public static List<string> InsertNames()
        {
            string name1, name2;

            while (true)
            {
                Console.Write("Insert first name: ");
                name1 = Console.ReadLine().Trim();
                if (!name1.Any(char.IsDigit))
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Insert second name: ");
                name2 = Console.ReadLine().Trim();
                if (!name2.Any(char.IsDigit))
                {
                    break;
                }
            }

            List<string> names = new List<string>();
            names.Add(name1);
            names.Add(name2);

            return names;
        }
    }
}
