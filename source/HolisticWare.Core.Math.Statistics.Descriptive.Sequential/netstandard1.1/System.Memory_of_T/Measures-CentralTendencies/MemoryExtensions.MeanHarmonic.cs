﻿using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Mean (Average) Harmonic
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Average"/>
    public static partial class MemoryExtensionsMeanHarmonic
    {
        //==============================================================================================================
        public static double MeanHarmonic
                                    (
                                        this Memory<byte> x
                                    )
        {
            int n = x.Length;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                byte x_i = x.Span[i];
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this Memory<ushort> x
                                    )
        {
            int n = x.Length;
            double sum = 0.0;

            for(int i = 0; i < n; i++)
            {
                ushort x_i = x.Span[i];
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this Memory<short> x
                                    )
        {
            int n = x.Length;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                short x_i = x.Span[i];
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this Memory<int> x
                                    )
        {
            int n = x.Length;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                int x_i = x.Span[i];
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this Memory<uint> x
                                    )
        {
            int n = x.Length;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.Span[i];
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this Memory<long> x
                                    )
        {
            int n = x.Length;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                long x_i = x.Span[i];
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this Memory<ulong> x
                                    )
        {
            int n = x.Length;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.Span[i];
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this Memory<float> x
                                    )
        {
            int n = x.Length;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                float x_i = x.Span[i];
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static double MeanHarmonic
                                    (
                                        this Memory<double> x
                                    )
        {
            int n = x.Length;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.Span[i];
                sum += 1.0 / x_i;
            }

            return n / sum;
        }

        public static decimal MeanHarmonic
                                    (
                                        this Memory<decimal> x
                                    )
        {
            int n = x.Length;
            decimal sum = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.Span[i];
                sum += 1.0M / x_i;
            }

            return n / sum;
        }
        //==============================================================================================================

    }
}
