using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stru_IVT_7_V.Tests.Classes_2_
{
    class ArrayProcessor
    {
        public double[] SortAndFilter(double[] array)
        {
            double[] newArray = array;
            newArray = PositiveValue(newArray);
            newArray = SortArray(newArray);
            newArray = ReverseArray(newArray);
            newArray = UniqueArray(newArray);
            return newArray;
        }

        public double[] PositiveValue(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Math.Abs(a[i]);
            }
            return a;
        }

        public double[] SortArray(double[] a)
        {
            Array.Sort(a);
            return a;
        }

        public double[] ReverseArray(double[] a)
        {
            Array.Reverse(a);
            return a;
        }

        public double[] UniqueArray(double[] a)
        {
            a = a.Distinct().ToArray();
            return a;
        }
    }
}
