﻿using System.Collections.Generic;

namespace Core.Math.Statistics.Descriptive.MatlabOctave.Sequential
{
    public static partial class MatlabOctave
    {
        public static double mean(IEnumerable<byte> x, string option)
        {
            return x.mean(option);
        }

        public static double mean(IEnumerable<byte> x, char option)
        {
            return x.mean(new string(new char[] { option } ));
        }
    }
}