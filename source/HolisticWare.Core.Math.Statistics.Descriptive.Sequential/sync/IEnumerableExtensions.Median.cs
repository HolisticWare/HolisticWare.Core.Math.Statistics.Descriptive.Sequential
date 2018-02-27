﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class IEnumerableExtensionsMedian
    {
        //==============================================================================================================
        public static double Median(this IEnumerable<byte> x)
        {
            int n = x.Count();
            IOrderedEnumerable<byte> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<short> x)
        {
            int n = x.Count();
            IOrderedEnumerable<short> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<ushort> x)
        {
            int n = x.Count();
            IOrderedEnumerable<ushort> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<int> x)
        {
            int n = x.Count();
            IOrderedEnumerable<int> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<uint> x)
        {
            int n = x.Count();
            IOrderedEnumerable<uint> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<long> x)
        {
            int n = x.Count();
            IOrderedEnumerable<long> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<ulong> x)
        {
            int n = x.Count();
            IOrderedEnumerable<ulong> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<float> x)
        {
            int n = x.Count();
            IOrderedEnumerable<float> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<double> x)
        {
            int n = x.Count();
            IOrderedEnumerable<double> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }

        public static decimal Median(this IEnumerable<decimal> x)
        {
            int n = x.Count();
            IOrderedEnumerable<decimal> x_ordered = x.OrderBy(x_i => x_i);
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x_ordered.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5M * (x_ordered.ElementAt(n2) + x_ordered.ElementAt(n2 + 1));
        }
        //==============================================================================================================

    }
}
