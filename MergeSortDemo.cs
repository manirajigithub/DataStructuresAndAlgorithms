using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortDemo
{
    public class MergeSortDemo
    {

        public static string[] Merge_Sort(string[] a, int lo, int hi)
        {
            if (lo < hi)
            {
                int mid = (lo + hi) / 2;
                //first half
                Merge_Sort(a, lo, mid);
                //second half
                Merge_Sort(a, mid + 1, hi);
                //merging both the halves
                merge(a, lo, mid, hi);
            }
            return a;
        }

        internal void CheckMergeSortDemo()
        {
            throw new NotImplementedException();
        }

        public static void merge(string[] a, int lo, int mid, int hi)
        {
            string[] arr = new string[a.Length];
            //Indexes for the arrays
            int First = lo;
            int Sec = mid + 1;
            int Third = lo;
            while (First <= mid && Sec <= hi)
            {
                //First array is less than Sec array then 
                if (a[First].CompareTo(a[Sec]) <= 0)
                {
                    arr[Third] = a[First];
                    First++;
                }
                //First array is greater than Sec array then 
                else
                {
                    arr[Third] = a[Sec];
                    Sec++;
                }
                Third++;
            }
            //If First half Completed then
            if (First > mid)
            {
                while (Sec <= hi)
                {
                    arr[Third] = a[Sec];
                    Sec++;
                    Third++;
                }
            }
            //If Second half Completed then
            if (Sec > hi)
            {
                while (First <= mid)
                {
                    arr[Third] = a[First];
                    First++;
                    Third++;
                }
            }
            //Copy the arrays and make it equal
            for (int A = lo; A <= hi; A++)
            {
                a[A] = arr[A];
            }
        }
    }
}
