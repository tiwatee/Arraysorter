using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class Sort
    {
        public int[] SortedArray(int[] unsortedList)
        {
            int min = unsortedList[0];
            for (int j = unsortedList.Length; j >= 0; j--)
            {
                for (int i = 1; i < j; i++)
                {
                    int a = unsortedList[i - 1];
                    int b = unsortedList[i];
                    if (a < b)
                    {
                        unsortedList[i] = a;
                        unsortedList[i - 1] = b;
                    }
                }
            }
            return unsortedList;
        }
    }
}
