using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public static class DoubleExtension // Класс-расширение
    {
        public static bool ApproximateCompareTo(this double f, double d,  double imprecision) ///Приблизительное сравнение
        {
            if (f + imprecision > d & f - imprecision < d)
                return true;
            return false;
        }
    }
}
