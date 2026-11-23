#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>What a raster band's pixels amount to, taken in one pass: how many pixels hold a value and their sum, mean, standard deviation, least and greatest, the record PostGIS's ST_SummaryStats states. Raster.summaryStats answers one and the summaryStats aggregate gathers one over rasters; MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BandStats : Value
    {
        internal BandStats(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText();

        public string AsText()
            => Meos.BandstatsOut(this.Ptr);

        public BandStats? Copy()
            => MEOSFactory.WrapBandStats(Meos.BandstatsCopy(this.Ptr));

        public long Count()
            => Meos.BandstatsCount(this.Ptr);

        public double? Max()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.BandstatsMax(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double? Mean()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.BandstatsMean(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double? Min()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.BandstatsMin(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double? Stddev()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.BandstatsStddev(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double? Sum()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.BandstatsSum(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public static BandStats? FromText(string str)
            => MEOSFactory.WrapBandStats(Meos.BandstatsIn(str));

    }
}
