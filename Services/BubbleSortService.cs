using StringSorter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorter.Services
{
    public class BubbleSortService : ISort
    {
        public string Sort(string input)
        {
            try
            {
                char[] chars = input.ToCharArray();
                int n = chars.Length;
                bool swapped;

                do
                {
                    swapped = false;
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = 0; j < n - i - 1; j++)
                        {
                            if (chars[j] > chars[j + 1])
                            {
                                var tempVar = chars[j];
                                chars[j] = chars[j + 1];
                                chars[j + 1] = tempVar;
                                swapped = true;
                            }
                        }
                    }
                } while (swapped);

                return new string(chars);
            }
            catch
            {
                throw new Exception("Something went wrong in BubbleSortService.");
            }
        }
    }
}
