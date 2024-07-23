using StringSorter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorter.Services
{
    public class MergeSortService : ISort
    {
        public string Sort(string input)
        {
            return new string(this.MergeSort(input.ToCharArray().ToList()).ToArray());
        }

        private List<char> MergeSort(List<char> input)
        {
            try
            {
                int n = input.Count;

                if (n <= 1)
                {
                    return input;
                }

                List<char> left = new List<char>();
                List<char> right = new List<char>();
                int middle = n / 2;

                for (int i = 0; i < middle; i++) // Put other half to left
                {
                    left.Add(input[i]);
                }
                for (int i = middle; i < n; i++) // Put other half to right
                {
                    right.Add(input[i]);
                }

                left = this.MergeSort(left);
                right = this.MergeSort(right);

                return this.Merge(left, right);
            }
            catch
            {
                throw new Exception("Something went wrong in MergeSortService.");
            }
        }

        private List<char> Merge(List<char> left, List<char> right)
        {
            List<char> result = new List<char>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First()) 
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
    }
}
