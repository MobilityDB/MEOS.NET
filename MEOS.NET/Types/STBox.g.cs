#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

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

        public bool Above(STBox box2)
            => Meos.AboveStboxStbox(this.Ptr, box2.Ptr);

        public bool Above(TSpatial temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(STBox box2)
            => Meos.AdjacentStboxStbox(this.Ptr, box2.Ptr);

        public bool Adjacent(TSpatial temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(STBox box2)
            => Meos.AfterStboxStbox(this.Ptr, box2.Ptr);

        public bool After(TSpatial temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public double Area(bool spheroid)
            => Meos.StboxArea(this.Ptr, spheroid);

        public byte[]? AsEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.StboxAsEwkb(this.Ptr, variant, _size_out);
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

        public string AsHexEWKB(byte variant)
            => Meos.StboxAsHexewkb(this.Ptr, variant);

        public string AsHexWKB(byte variant)
            => Meos.StboxAsHexwkb(this.Ptr, variant);

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.StboxAsWkb(this.Ptr, variant, _size_out);
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

        public bool Back(STBox box2)
            => Meos.BackStboxStbox(this.Ptr, box2.Ptr);

        public bool Back(TSpatial temp)
            => Meos.BackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(STBox box2)
            => Meos.BeforeStboxStbox(this.Ptr, box2.Ptr);

        public bool Before(TSpatial temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(STBox box2)
            => Meos.BelowStboxStbox(this.Ptr, box2.Ptr);

        public bool Below(TSpatial temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public int Cmp(STBox box2)
            => Meos.StboxCmp(this.Ptr, box2.Ptr);

        public bool Contained(STBox box2)
            => Meos.ContainedStboxStbox(this.Ptr, box2.Ptr);

        public bool Contained(TSpatial temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(STBox box2)
            => Meos.ContainsStboxStbox(this.Ptr, box2.Ptr);

        public bool Contains(TSpatial temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public STBox? Copy()
            => MEOSFactory.WrapSTBox(Meos.StboxCopy(this.Ptr));

        public bool Eq(STBox box2)
            => Meos.StboxEq(this.Ptr, box2.Ptr);

        public STBox? ExpandSpace(double d)
            => MEOSFactory.WrapSTBox(Meos.StboxExpandSpace(this.Ptr, d));

        public STBox? ExpandTime(Interval interv)
        {
            IntPtr _interv = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(interv, _interv, false);
                return MEOSFactory.WrapSTBox(Meos.StboxExpandTime(this.Ptr, _interv));
            }
            finally
            {
                Marshal.FreeHGlobal(_interv);
            }
        }

        public bool Front(STBox box2)
            => Meos.FrontStboxStbox(this.Ptr, box2.Ptr);

        public bool Front(TSpatial temp)
            => Meos.FrontStboxTspatial(this.Ptr, temp.Ptr);

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

        public STBox? Intersection(STBox box2)
            => MEOSFactory.WrapSTBox(Meos.IntersectionStboxStbox(this.Ptr, box2.Ptr));

        public bool Isgeodetic()
            => Meos.StboxIsgeodetic(this.Ptr);

        public bool Le(STBox box2)
            => Meos.StboxLe(this.Ptr, box2.Ptr);

        public bool Left(STBox box2)
            => Meos.LeftStboxStbox(this.Ptr, box2.Ptr);

        public bool Left(TSpatial temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Lt(STBox box2)
            => Meos.StboxLt(this.Ptr, box2.Ptr);

        public double Nad(Geo gs, bool spheroid)
            => Meos.NadStboxGeo(this.Ptr, gs.Ptr, spheroid);

        public double Nad(STBox box2, bool spheroid)
            => Meos.NadStboxStbox(this.Ptr, box2.Ptr, spheroid);

        public double Nad(Temporal temp)
            => Meos.NadStboxTrgeometry(this.Ptr, temp.Ptr);

        public bool Ne(STBox box2)
            => Meos.StboxNe(this.Ptr, box2.Ptr);

        public string Out(int maxdd)
            => Meos.StboxOut(this.Ptr, maxdd);

        public bool Overabove(STBox box2)
            => Meos.OveraboveStboxStbox(this.Ptr, box2.Ptr);

        public bool Overabove(TSpatial temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(STBox box2)
            => Meos.OverafterStboxStbox(this.Ptr, box2.Ptr);

        public bool Overafter(TSpatial temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overback(STBox box2)
            => Meos.OverbackStboxStbox(this.Ptr, box2.Ptr);

        public bool Overback(TSpatial temp)
            => Meos.OverbackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(STBox box2)
            => Meos.OverbeforeStboxStbox(this.Ptr, box2.Ptr);

        public bool Overbefore(TSpatial temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(STBox box2)
            => Meos.OverbelowStboxStbox(this.Ptr, box2.Ptr);

        public bool Overbelow(TSpatial temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overfront(STBox box2)
            => Meos.OverfrontStboxStbox(this.Ptr, box2.Ptr);

        public bool Overfront(TSpatial temp)
            => Meos.OverfrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(STBox box2)
            => Meos.OverlapsStboxStbox(this.Ptr, box2.Ptr);

        public bool Overlaps(TSpatial temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(STBox box2)
            => Meos.OverleftStboxStbox(this.Ptr, box2.Ptr);

        public bool Overleft(TSpatial temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(STBox box2)
            => Meos.OverrightStboxStbox(this.Ptr, box2.Ptr);

        public bool Overright(TSpatial temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public double Perimeter(bool spheroid)
            => Meos.StboxPerimeter(this.Ptr, spheroid);

        public STBox?[] QuadSplit()
            => MEOSFactory.WrapSTBoxArray(Meos.StboxQuadSplit(this.Ptr));

        public bool Right(STBox box2)
            => Meos.RightStboxStbox(this.Ptr, box2.Ptr);

        public bool Right(TSpatial temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public STBox? Round(int maxdd)
            => MEOSFactory.WrapSTBox(Meos.StboxRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.StboxSrid(this.Ptr);

        public bool Same(STBox box2)
            => Meos.SameStboxStbox(this.Ptr, box2.Ptr);

        public bool Same(TSpatial temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public STBox? ScaleTime(Interval duration)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBox(Meos.StboxScaleTime(this.Ptr, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public STBox? SetSRID(int srid)
            => MEOSFactory.WrapSTBox(Meos.StboxSetSrid(this.Ptr, srid));

        public STBox? ShiftScaleTime(Interval shift, Interval duration)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBox(Meos.StboxShiftScaleTime(this.Ptr, _shift, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
                Marshal.FreeHGlobal(_duration);
            }
        }

        public STBox? ShiftTime(Interval shift)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                return MEOSFactory.WrapSTBox(Meos.StboxShiftTime(this.Ptr, _shift));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
            }
        }

        public byte[]? Sortkey()
        {
            IntPtr _size = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.StboxSortkey(this.Ptr, _size);
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

        public STBox?[] SpaceTiles(double xsize, double ysize, double zsize, Geo sorigin, bool border_inc)
            => MEOSFactory.WrapSTBoxArray(Meos.StboxSpaceTiles(this.Ptr, xsize, ysize, zsize, sorigin.Ptr, border_inc));

        public STBox?[] SpaceTimeTiles(double xsize, double ysize, double zsize, Interval duration, Geo sorigin, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBoxArray(Meos.StboxSpaceTimeTiles(this.Ptr, xsize, ysize, zsize, _duration, sorigin.Ptr, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public double SpatialDistance(STBox box2)
            => Meos.StboxSpatialDistance(this.Ptr, box2.Ptr);

        public STBox?[] TimeTiles(Interval duration, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBoxArray(Meos.StboxTimeTiles(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

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

        public BOX3D? ToBox3d()
            => MEOSConvert.ToStruct<BOX3D>(Meos.StboxToBox3d(this.Ptr));

        public GBOX? ToGbox()
            => MEOSConvert.ToStruct<GBOX>(Meos.StboxToGbox(this.Ptr));

        public Geo? ToGeo()
            => MEOSFactory.WrapGeo(Meos.StboxToGeo(this.Ptr));

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(Meos.StboxToTstzspan(this.Ptr));

        public STBox? Transform(int srid)
            => MEOSFactory.WrapSTBox(Meos.StboxTransform(this.Ptr, srid));

        public STBox? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapSTBox(Meos.StboxTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

        public STBox? Union(STBox box2, bool strict)
            => MEOSFactory.WrapSTBox(Meos.UnionStboxStbox(this.Ptr, box2.Ptr, strict));

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

        public static STBox? FromBox3d(BOX3D box)
        {
            IntPtr _box = Marshal.AllocHGlobal(Marshal.SizeOf<BOX3D>());
            try
            {
                Marshal.StructureToPtr(box, _box, false);
                return MEOSFactory.WrapSTBox(Meos.Box3dToStbox(_box));
            }
            finally
            {
                Marshal.FreeHGlobal(_box);
            }
        }

        public static STBox? FromEWKB(byte[] wkb)
            => STBox.FromWKB(wkb);

        public static STBox? FromGbox(GBOX box)
        {
            IntPtr _box = Marshal.AllocHGlobal(Marshal.SizeOf<GBOX>());
            try
            {
                Marshal.StructureToPtr(box, _box, false);
                return MEOSFactory.WrapSTBox(Meos.GboxToStbox(_box));
            }
            finally
            {
                Marshal.FreeHGlobal(_box);
            }
        }

        public static STBox? FromH3index(ulong cell)
            => MEOSFactory.WrapSTBox(Meos.H3indexToStbox(cell));

        public static STBox? FromH3indexTimestamptz(ulong cell, DateTime t)
            => MEOSFactory.WrapSTBox(Meos.H3indexTimestamptzToStbox(cell, MEOSConvert.ToTimestampTz(t)));

        public static STBox? FromH3indexTstzspan(ulong cell, Span s)
            => MEOSFactory.WrapSTBox(Meos.H3indexTstzspanToStbox(cell, s.Ptr));

        public static STBox? FromHexEWKB(string hexwkb)
            => STBox.FromHexWKB(hexwkb);

        public static STBox? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapSTBox(Meos.StboxFromHexwkb(hexwkb));

        public static STBox? FromQuadbin(ulong cell)
            => MEOSFactory.WrapSTBox(Meos.QuadbinToStbox(cell));

        public static STBox? FromQuadbinTimestamptz(ulong cell, DateTime t)
            => MEOSFactory.WrapSTBox(Meos.QuadbinTimestamptzToStbox(cell, MEOSConvert.ToTimestampTz(t)));

        public static STBox? FromQuadbinTstzspan(ulong cell, Span s)
            => MEOSFactory.WrapSTBox(Meos.QuadbinTstzspanToStbox(cell, s.Ptr));

        public static STBox? FromS2cell(ulong cell)
            => MEOSFactory.WrapSTBox(Meos.S2cellToStbox(cell));

        public static STBox? FromS2cellTimestamptz(ulong cell, DateTime t)
            => MEOSFactory.WrapSTBox(Meos.S2cellTimestamptzToStbox(cell, MEOSConvert.ToTimestampTz(t)));

        public static STBox? FromS2cellTstzspan(ulong cell, Span s)
            => MEOSFactory.WrapSTBox(Meos.S2cellTstzspanToStbox(cell, s.Ptr));

        public static STBox? FromText(string str)
            => STBox.In(str);

        public static STBox? FromTimestamptz(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.TimestamptzToStbox(MEOSConvert.ToTimestampTz(t)));

        public static STBox? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSTBox(Meos.StboxFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static STBox? GetSpaceTile(Geo point, double xsize, double ysize, double zsize, Geo sorigin)
            => MEOSFactory.WrapSTBox(Meos.StboxGetSpaceTile(point.Ptr, xsize, ysize, zsize, sorigin.Ptr));

        public static STBox? GetSpaceTimeTile(Geo point, DateTime t, double xsize, double ysize, double zsize, Interval duration, Geo sorigin, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBox(Meos.StboxGetSpaceTimeTile(point.Ptr, MEOSConvert.ToTimestampTz(t), xsize, ysize, zsize, _duration, sorigin.Ptr, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public static STBox? GetTimeTile(DateTime t, Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBox(Meos.StboxGetTimeTile(MEOSConvert.ToTimestampTz(t), _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public static STBox? In(string str)
            => MEOSFactory.WrapSTBox(Meos.StboxIn(str));

        public static STBox? Make(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, Span s)
            => MEOSFactory.WrapSTBox(Meos.StboxMake(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s.Ptr));

    }
}
