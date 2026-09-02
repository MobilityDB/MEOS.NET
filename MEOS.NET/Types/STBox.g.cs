#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>Space x time box (bbox of TSpatial).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class STBox : Box
    {
        internal STBox(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public double Area(bool spheroid)
            => Meos.StboxArea(this.Ptr, spheroid);

        public int Cmp(STBox box2)
            => Meos.StboxCmp(this.Ptr, box2.Ptr);

        public STBox? Copy()
            => MEOSFactory.WrapSTBox(Meos.StboxCopy(this.Ptr));

        public bool Eq(STBox box2)
            => Meos.StboxEq(this.Ptr, box2.Ptr);

        public STBox? ExpandSpace(double d)
            => MEOSFactory.WrapSTBox(Meos.StboxExpandSpace(this.Ptr, d));

        public bool Ge(STBox box2)
            => Meos.StboxGe(this.Ptr, box2.Ptr);

        public STBox? GetSpace()
            => MEOSFactory.WrapSTBox(Meos.StboxGetSpace(this.Ptr));

        public bool Gt(STBox box2)
            => Meos.StboxGt(this.Ptr, box2.Ptr);

        public uint Hash()
            => Meos.StboxHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.StboxHashExtended(this.Ptr, seed);

        public bool Hast()
            => Meos.StboxHast(this.Ptr);

        public bool Hasx()
            => Meos.StboxHasx(this.Ptr);

        public bool Hasz()
            => Meos.StboxHasz(this.Ptr);

        public bool Isgeodetic()
            => Meos.StboxIsgeodetic(this.Ptr);

        public bool Le(STBox box2)
            => Meos.StboxLe(this.Ptr, box2.Ptr);

        public bool Lt(STBox box2)
            => Meos.StboxLt(this.Ptr, box2.Ptr);

        public bool Ne(STBox box2)
            => Meos.StboxNe(this.Ptr, box2.Ptr);

        public string Out(int maxdd)
            => Meos.StboxOut(this.Ptr, maxdd);

        public double Perimeter(bool spheroid)
            => Meos.StboxPerimeter(this.Ptr, spheroid);

        public STBox?[] QuadSplit()
            => MEOSFactory.WrapSTBoxArray(Meos.StboxQuadSplit(this.Ptr));

        public STBox? Round(int maxdd)
            => MEOSFactory.WrapSTBox(Meos.StboxRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.StboxSrid(this.Ptr);

        public STBox? SetSRID(int srid)
            => MEOSFactory.WrapSTBox(Meos.StboxSetSrid(this.Ptr, srid));

        public double SpatialDistance(STBox box2)
            => Meos.StboxSpatialDistance(this.Ptr, box2.Ptr);

        public DateTime? Tmax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxTmax(this.Ptr, _result))
                {
                    return null;
                }

                return MEOSConvert.ToDateTime(Marshal.ReadInt64(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public bool? TmaxInc()
        {
            IntPtr _result = Marshal.AllocHGlobal(1);
            try
            {
                if (!Meos.StboxTmaxInc(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.ReadByte(_result) != 0;
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public DateTime? Tmin()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxTmin(this.Ptr, _result))
                {
                    return null;
                }

                return MEOSConvert.ToDateTime(Marshal.ReadInt64(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public bool? TminInc()
        {
            IntPtr _result = Marshal.AllocHGlobal(1);
            try
            {
                if (!Meos.StboxTminInc(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.ReadByte(_result) != 0;
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(Meos.StboxToTstzspan(this.Ptr));

        public STBox? Transform(int srid)
            => MEOSFactory.WrapSTBox(Meos.StboxTransform(this.Ptr, srid));

        public STBox? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapSTBox(Meos.StboxTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

        public double Volume()
            => Meos.StboxVolume(this.Ptr);

        public double? Xmax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxXmax(this.Ptr, _result))
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

        public double? Xmin()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxXmin(this.Ptr, _result))
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

        public double? Ymax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxYmax(this.Ptr, _result))
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

        public double? Ymin()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxYmin(this.Ptr, _result))
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

        public double? Zmax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxZmax(this.Ptr, _result))
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

        public double? Zmin()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxZmin(this.Ptr, _result))
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

        public static STBox? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapSTBox(Meos.StboxFromHexwkb(hexwkb));

        public static STBox? In(string str)
            => MEOSFactory.WrapSTBox(Meos.StboxIn(str));

        public static STBox? Make(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, Span s)
            => MEOSFactory.WrapSTBox(Meos.StboxMake(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s.Ptr));

    }
}
