using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stru_IVT_7_V.Tests.Classes_2_.DataAccessObjects
{
    class Mock_ArrayProcessor:IArrayProcessor
    {
        public int positiveValue { get; set; }
        public int reverseArray { get; set; }
        public int sortAndFilter { get; set; }
        public int sortArray { get; set; }
        public int uniqueArray { get; set; }

        public double[] PositiveValue(double[] a)
        {
            positiveValue++;
            return a;
        }

        public double[] ReverseArray(double[] a)
        {
            reverseArray++;
            return a;
        }

        public double[] SortAndFilter(double[] a)
        {
            PositiveValue(a);
            SortArray(a);
            ReverseArray(a);
            UniqueArray(a);
            sortAndFilter++;
            return a;
        }

        public double[] SortArray(double[] a)
        {
            sortArray++;
            return a;
        }

        public double[] UniqueArray(double[] a)
        {
            uniqueArray++;
            return a;
        }
    }
}
