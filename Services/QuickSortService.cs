using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using StringSorter.Interfaces;
using System;

namespace StringSorter.Services
{
    public class QuickSortService : ISort
    {
        public string Sort(string input)
        {
            return this.QuickSort(input.ToCharArray(), 0, input.Length - 1);
        }

        public string QuickSort(char[] input, int leftIndex, int rightIndex)
        {
            try
            {
                var i = leftIndex;
                var j = rightIndex;
                var pivot = input[leftIndex];

                while (i <= j)
                {
                    while (input[i] < pivot)
                    {
                        i++;
                    }

                    while (input[j] > pivot)
                    {
                        j--;
                    }

                    if (i <= j)
                    {
                        char temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                        i++;
                        j--;
                    }
                }

                if (leftIndex < j)
                {
                    this.QuickSort(input, leftIndex, j);
                }

                if (i < rightIndex)
                {
                    this.QuickSort(input, i, rightIndex);
                }

                return new string(input);
            }
            catch
            {
                throw new Exception("Something went wrong in QuickSortService.");
            }
        }
    }
}
