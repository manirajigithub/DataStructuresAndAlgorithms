using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortDemo
{
    public class InsertionSortDemo
    {
        public void CheckSorting()
        {
            int[] arr = { 23, 9, 85, 12 };

            int n = 4, i, j, val, flag;

            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                        flag = 1;
                }
            }
            Console.WriteLine("Sorted Array :");
            foreach (int a in arr)
            {
                Console.WriteLine(a + " ");
            }
        }


    }
}