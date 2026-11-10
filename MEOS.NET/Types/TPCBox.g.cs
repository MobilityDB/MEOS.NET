#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Point-cloud x time box (bbox of TPCPoint and TPCPatch).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPCBox : Box
    {
        internal TPCBox(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Above(TPCBox box2)
            => Meos.AboveTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Above(TSpatial temp)
            => Meos.AboveTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Above(TPCPatch temp)
            => Meos.AboveTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Above(TPCPoint temp)
            => Meos.AboveTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Adjacent(TPCBox box2)
            => Meos.AdjacentTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Adjacent(TSpatial temp)
            => Meos.AdjacentTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Adjacent(TPCPatch temp)
            => Meos.AdjacentTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Adjacent(TPCPoint temp)
            => Meos.AdjacentTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool After(TPCBox box2)
            => Meos.AfterTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool After(TSpatial temp)
            => Meos.AfterTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool After(TPCPatch temp)
            => Meos.AfterTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool After(TPCPoint temp)
            => Meos.AfterTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public byte[]? AsEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.TpcboxAsEwkb(this.Ptr, variant, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public string AsEWKT(int maxdd)
            => this.Out(maxdd);

        public string AsHexEWKB(byte variant)
            => Meos.TpcboxAsHexewkb(this.Ptr, variant);

        public string AsHexWKB(byte variant)
            => Meos.TpcboxAsHexwkb(this.Ptr, variant);

        public string AsText(int maxdd)
            => Meos.TpcboxAsText(this.Ptr, maxdd);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.TpcboxAsWkb(this.Ptr, variant, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public bool Back(TPCBox box2)
            => Meos.BackTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Back(TSpatial temp)
            => Meos.BackTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Back(TPCPatch temp)
            => Meos.BackTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Back(TPCPoint temp)
            => Meos.BackTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Before(TPCBox box2)
            => Meos.BeforeTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Before(TSpatial temp)
            => Meos.BeforeTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Before(TPCPatch temp)
            => Meos.BeforeTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Before(TPCPoint temp)
            => Meos.BeforeTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Below(TPCBox box2)
            => Meos.BelowTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Below(TSpatial temp)
            => Meos.BelowTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Below(TPCPatch temp)
            => Meos.BelowTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Below(TPCPoint temp)
            => Meos.BelowTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public int Cmp(TPCBox box2)
            => Meos.TpcboxCmp(this.Ptr, box2.Ptr);

        public bool Contained(TPCBox box2)
            => Meos.ContainedTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Contained(TSpatial temp)
            => Meos.ContainedTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Contained(TPCPatch temp)
            => Meos.ContainedTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Contained(TPCPoint temp)
            => Meos.ContainedTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Contains(TPCBox box2)
            => Meos.ContainsTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Contains(TSpatial temp)
            => Meos.ContainsTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Contains(TPCPatch temp)
            => Meos.ContainsTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Contains(TPCPoint temp)
            => Meos.ContainsTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public TPCBox? Copy()
            => MEOSFactory.WrapTPCBox(Meos.TpcboxCopy(this.Ptr));

        public bool Eq(TPCBox box2)
            => Meos.TpcboxEq(this.Ptr, box2.Ptr);

        public bool Front(TPCBox box2)
            => Meos.FrontTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Front(TSpatial temp)
            => Meos.FrontTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Front(TPCPatch temp)
            => Meos.FrontTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Front(TPCPoint temp)
            => Meos.FrontTpcboxTpointcloud(this.Ptr, temp.Ptr);

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

        public TPCBox? Intersection(TPCBox box2)
            => MEOSFactory.WrapTPCBox(Meos.IntersectionTpcboxTpcbox(this.Ptr, box2.Ptr));

        public bool Le(TPCBox box2)
            => Meos.TpcboxLe(this.Ptr, box2.Ptr);

        public bool Left(TPCBox box2)
            => Meos.LeftTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Left(TSpatial temp)
            => Meos.LeftTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Left(TPCPatch temp)
            => Meos.LeftTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Left(TPCPoint temp)
            => Meos.LeftTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Lt(TPCBox box2)
            => Meos.TpcboxLt(this.Ptr, box2.Ptr);

        public double Nad(TPCBox box2)
            => Meos.NadTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Ne(TPCBox box2)
            => Meos.TpcboxNe(this.Ptr, box2.Ptr);

        public string Out(int maxdd)
            => Meos.TpcboxOut(this.Ptr, maxdd);

        public bool Overabove(TPCBox box2)
            => Meos.OveraboveTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Overabove(TSpatial temp)
            => Meos.OveraboveTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overabove(TPCPatch temp)
            => Meos.OveraboveTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overabove(TPCPoint temp)
            => Meos.OveraboveTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overafter(TPCBox box2)
            => Meos.OverafterTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Overafter(TSpatial temp)
            => Meos.OverafterTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overafter(TPCPatch temp)
            => Meos.OverafterTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overafter(TPCPoint temp)
            => Meos.OverafterTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overback(TPCBox box2)
            => Meos.OverbackTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Overback(TSpatial temp)
            => Meos.OverbackTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overback(TPCPatch temp)
            => Meos.OverbackTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overback(TPCPoint temp)
            => Meos.OverbackTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overbefore(TPCBox box2)
            => Meos.OverbeforeTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Overbefore(TSpatial temp)
            => Meos.OverbeforeTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overbefore(TPCPatch temp)
            => Meos.OverbeforeTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overbefore(TPCPoint temp)
            => Meos.OverbeforeTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overbelow(TPCBox box2)
            => Meos.OverbelowTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Overbelow(TSpatial temp)
            => Meos.OverbelowTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overbelow(TPCPatch temp)
            => Meos.OverbelowTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overbelow(TPCPoint temp)
            => Meos.OverbelowTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overfront(TPCBox box2)
            => Meos.OverfrontTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Overfront(TSpatial temp)
            => Meos.OverfrontTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overfront(TPCPatch temp)
            => Meos.OverfrontTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overfront(TPCPoint temp)
            => Meos.OverfrontTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overlaps(TPCBox box2)
            => Meos.OverlapsTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Overlaps(TSpatial temp)
            => Meos.OverlapsTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overlaps(TPCPatch temp)
            => Meos.OverlapsTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overlaps(TPCPoint temp)
            => Meos.OverlapsTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overleft(TPCBox box2)
            => Meos.OverleftTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Overleft(TSpatial temp)
            => Meos.OverleftTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overleft(TPCPatch temp)
            => Meos.OverleftTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overleft(TPCPoint temp)
            => Meos.OverleftTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overright(TPCBox box2)
            => Meos.OverrightTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Overright(TSpatial temp)
            => Meos.OverrightTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overright(TPCPatch temp)
            => Meos.OverrightTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Overright(TPCPoint temp)
            => Meos.OverrightTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public uint Pcid()
            => Meos.TpcboxPcid(this.Ptr);

        public bool Right(TPCBox box2)
            => Meos.RightTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Right(TSpatial temp)
            => Meos.RightTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Right(TPCPatch temp)
            => Meos.RightTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Right(TPCPoint temp)
            => Meos.RightTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public TPCBox? Round(int maxdd)
            => MEOSFactory.WrapTPCBox(Meos.TpcboxRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.TpcboxSrid(this.Ptr);

        public bool Same(TPCBox box2)
            => Meos.SameTpcboxTpcbox(this.Ptr, box2.Ptr);

        public bool Same(TSpatial temp)
            => Meos.SameTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Same(TPCPatch temp)
            => Meos.SameTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public bool Same(TPCPoint temp)
            => Meos.SameTpcboxTpointcloud(this.Ptr, temp.Ptr);

        public TPCBox? SetSRID(int srid)
            => MEOSFactory.WrapTPCBox(Meos.TpcboxSetSrid(this.Ptr, srid));

        public byte[]? Sortkey()
        {
            IntPtr _size = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.TpcboxSortkey(this.Ptr, _size);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size);
            }
        }

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

        public TPCBox? Union(TPCBox box2, bool strict)
            => MEOSFactory.WrapTPCBox(Meos.UnionTpcboxTpcbox(this.Ptr, box2.Ptr, strict));

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

        public static TPCBox? FromEWKB(byte[] wkb)
            => TPCBox.FromWKB(wkb);

        public static TPCBox? FromEWKT(string str)
            => TPCBox.In(str);

        public static TPCBox? FromHexEWKB(string hexwkb)
            => TPCBox.FromHexWKB(hexwkb);

        public static TPCBox? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapTPCBox(Meos.TpcboxFromHexwkb(hexwkb));

        public static TPCBox? FromText(string str)
            => TPCBox.In(str);

        public static TPCBox? FromTpointcloud(Temporal temp)
            => MEOSFactory.WrapTPCBox(Meos.TpointcloudToTpcbox(temp.Ptr));

        public static TPCBox? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTPCBox(Meos.TpcboxFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static TPCBox? In(string str)
            => MEOSFactory.WrapTPCBox(Meos.TpcboxIn(str));

        public static TPCBox? Make(bool hasx, bool hasz, bool geodetic, uint pcid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, Span period)
            => MEOSFactory.WrapTPCBox(Meos.TpcboxMake(hasx, hasz, geodetic, pcid, xmin, xmax, ymin, ymax, zmin, zmax, period.Ptr));

    }
}
