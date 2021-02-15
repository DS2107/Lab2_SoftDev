using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stru_IVT_7_V.Tests.Classes_2_.DataAccessObjects
{
   public interface IArrayProcessor
    {
        double[] SortAndFilter(double[] a);
        double[] PositiveValue(double[] a);
        double[] SortArray(double[] a);
        double[] ReverseArray(double[] a);
        double[] UniqueArray(double[] a);
    }
}
