#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>Point-cloud x time box (bbox of TPcpoint and TPcpatch).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPCBox : Box
    {
        internal TPCBox(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public int Cmp(TPCBox box2)
            => Meos.TpcboxCmp(this.Ptr, box2.Ptr);

        public TPCBox? Copy()
            => MEOSFactory.WrapTPCBox(Meos.TpcboxCopy(this.Ptr));

        public bool Eq(TPCBox box2)
            => Meos.TpcboxEq(this.Ptr, box2.Ptr);

        public bool Ge(TPCBox box2)
            => Meos.TpcboxGe(this.Ptr, box2.Ptr);

        public bool Geodetic()
            => Meos.TpcboxGeodetic(this.Ptr);

        public bool Gt(TPCBox box2)
            => Meos.TpcboxGt(this.Ptr, box2.Ptr);

        public bool Hast()
            => Meos.TpcboxHast(this.Ptr);

        public bool Hasx()
            => Meos.TpcboxHasx(this.Ptr);

        public bool Hasz()
            => Meos.TpcboxHasz(this.Ptr);

        public bool Le(TPCBox box2)
            => Meos.TpcboxLe(this.Ptr, box2.Ptr);

        public bool Lt(TPCBox box2)
            => Meos.TpcboxLt(this.Ptr, box2.Ptr);

        public bool Ne(TPCBox box2)
            => Meos.TpcboxNe(this.Ptr, box2.Ptr);

        public string Out(int maxdd)
            => Meos.TpcboxOut(this.Ptr, maxdd);

        public uint Pcid()
            => Meos.TpcboxPcid(this.Ptr);

        public TPCBox? Round(int maxdd)
            => MEOSFactory.WrapTPCBox(Meos.TpcboxRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.TpcboxSrid(this.Ptr);

        public TPCBox? SetSRID(int srid)
            => MEOSFactory.WrapTPCBox(Meos.TpcboxSetSrid(this.Ptr, srid));

        public DateTime? Tmax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcboxTmax(this.Ptr, _result))
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
                if (!Meos.TpcboxTmaxInc(this.Ptr, _result))
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
                if (!Meos.TpcboxTmin(this.Ptr, _result))
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
                if (!Meos.TpcboxTminInc(this.Ptr, _result))
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

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TpcboxToStbox(this.Ptr));

        public double? Xmax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcboxXmax(this.Ptr, _result))
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
                if (!Meos.TpcboxXmin(this.Ptr, _result))
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
                if (!Meos.TpcboxYmax(this.Ptr, _result))
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
                if (!Meos.TpcboxYmin(this.Ptr, _result))
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
                if (!Meos.TpcboxZmax(this.Ptr, _result))
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
                if (!Meos.TpcboxZmin(this.Ptr, _result))
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

        public static TPCBox? In(string str)
            => MEOSFactory.WrapTPCBox(Meos.TpcboxIn(str));

        public static TPCBox? Make(bool hasx, bool hasz, bool hast, bool geodetic, int srid, uint pcid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, Span period)
            => MEOSFactory.WrapTPCBox(Meos.TpcboxMake(hasx, hasz, hast, geodetic, srid, pcid, xmin, xmax, ymin, ymax, zmin, zmax, period.Ptr));

    }
}
