#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Numeric x time box (bbox of TNumber).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBox : Box
    {
        internal TBox(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public bool Adjacent(TBox box2)
            => Meos.AdjacentTboxTbox(this.Ptr, box2.Ptr);

        public bool Adjacent(Span s)
            => Meos.AdjacentTboxNumspan(this.Ptr, s.Ptr);

        public bool Adjacent(TsTzSpan s)
            => Meos.AdjacentTboxTstzspan(this.Ptr, s.Ptr);

        public bool Adjacent(TNumber temp)
            => Meos.AdjacentTboxTnumber(this.Ptr, temp.Ptr);

        public bool Adjacent(BigIntSpan s)
            => Meos.AdjacentTboxNumspan(this.Ptr, s.Ptr);

        public bool Adjacent(FloatSpan s)
            => Meos.AdjacentTboxNumspan(this.Ptr, s.Ptr);

        public bool Adjacent(IntSpan s)
            => Meos.AdjacentTboxNumspan(this.Ptr, s.Ptr);

        public bool Adjacent(TBigint temp)
            => Meos.AdjacentTboxTnumber(this.Ptr, temp.Ptr);

        public bool Adjacent(TFloat temp)
            => Meos.AdjacentTboxTnumber(this.Ptr, temp.Ptr);

        public bool Adjacent(TInt temp)
            => Meos.AdjacentTboxTnumber(this.Ptr, temp.Ptr);

        public bool After(TBox box2)
            => Meos.AfterTboxTbox(this.Ptr, box2.Ptr);

        public bool After(TsTzSpan s)
            => Meos.AfterTboxTstzspan(this.Ptr, s.Ptr);

        public bool After(TNumber temp)
            => Meos.AfterTboxTnumber(this.Ptr, temp.Ptr);

        public bool After(TBigint temp)
            => Meos.AfterTboxTnumber(this.Ptr, temp.Ptr);

        public bool After(TFloat temp)
            => Meos.AfterTboxTnumber(this.Ptr, temp.Ptr);

        public bool After(TInt temp)
            => Meos.AfterTboxTnumber(this.Ptr, temp.Ptr);

        public string AsHexWKB(byte variant)
            => Meos.TboxAsHexwkb(this.Ptr, variant);

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.TboxAsWkb(this.Ptr, variant, _size_out);
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

        public bool Before(TBox box2)
            => Meos.BeforeTboxTbox(this.Ptr, box2.Ptr);

        public bool Before(TsTzSpan s)
            => Meos.BeforeTboxTstzspan(this.Ptr, s.Ptr);

        public bool Before(TNumber temp)
            => Meos.BeforeTboxTnumber(this.Ptr, temp.Ptr);

        public bool Before(TBigint temp)
            => Meos.BeforeTboxTnumber(this.Ptr, temp.Ptr);

        public bool Before(TFloat temp)
            => Meos.BeforeTboxTnumber(this.Ptr, temp.Ptr);

        public bool Before(TInt temp)
            => Meos.BeforeTboxTnumber(this.Ptr, temp.Ptr);

        public int Cmp(TBox box2)
            => Meos.TboxCmp(this.Ptr, box2.Ptr);

        public bool Contained(TBox box2)
            => Meos.ContainedTboxTbox(this.Ptr, box2.Ptr);

        public bool Contained(Span s)
            => Meos.ContainedTboxNumspan(this.Ptr, s.Ptr);

        public bool Contained(TsTzSpan s)
            => Meos.ContainedTboxTstzspan(this.Ptr, s.Ptr);

        public bool Contained(TNumber temp)
            => Meos.ContainedTboxTnumber(this.Ptr, temp.Ptr);

        public bool Contained(BigIntSpan s)
            => Meos.ContainedTboxNumspan(this.Ptr, s.Ptr);

        public bool Contained(FloatSpan s)
            => Meos.ContainedTboxNumspan(this.Ptr, s.Ptr);

        public bool Contained(IntSpan s)
            => Meos.ContainedTboxNumspan(this.Ptr, s.Ptr);

        public bool Contained(TBigint temp)
            => Meos.ContainedTboxTnumber(this.Ptr, temp.Ptr);

        public bool Contained(TFloat temp)
            => Meos.ContainedTboxTnumber(this.Ptr, temp.Ptr);

        public bool Contained(TInt temp)
            => Meos.ContainedTboxTnumber(this.Ptr, temp.Ptr);

        public bool Contains(TBox box2)
            => Meos.ContainsTboxTbox(this.Ptr, box2.Ptr);

        public bool Contains(Span s)
            => Meos.ContainsTboxNumspan(this.Ptr, s.Ptr);

        public bool Contains(TsTzSpan s)
            => Meos.ContainsTboxTstzspan(this.Ptr, s.Ptr);

        public bool Contains(TNumber temp)
            => Meos.ContainsTboxTnumber(this.Ptr, temp.Ptr);

        public bool Contains(BigIntSpan s)
            => Meos.ContainsTboxNumspan(this.Ptr, s.Ptr);

        public bool Contains(FloatSpan s)
            => Meos.ContainsTboxNumspan(this.Ptr, s.Ptr);

        public bool Contains(IntSpan s)
            => Meos.ContainsTboxNumspan(this.Ptr, s.Ptr);

        public bool Contains(TBigint temp)
            => Meos.ContainsTboxTnumber(this.Ptr, temp.Ptr);

        public bool Contains(TFloat temp)
            => Meos.ContainsTboxTnumber(this.Ptr, temp.Ptr);

        public bool Contains(TInt temp)
            => Meos.ContainsTboxTnumber(this.Ptr, temp.Ptr);

        public TBox? Copy()
            => MEOSFactory.WrapTBox(Meos.TboxCopy(this.Ptr));

        public bool Eq(TBox box2)
            => Meos.TboxEq(this.Ptr, box2.Ptr);

        public TBox? ExpandTime(Interval interv)
        {
            IntPtr _interv = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(interv, _interv, false);
                return MEOSFactory.WrapTBox(Meos.TboxExpandTime(this.Ptr, _interv));
            }
            finally
            {
                Marshal.FreeHGlobal(_interv);
            }
        }

        public bool Ge(TBox box2)
            => Meos.TboxGe(this.Ptr, box2.Ptr);

        public bool Gt(TBox box2)
            => Meos.TboxGt(this.Ptr, box2.Ptr);

        public uint Hash()
            => Meos.TboxHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.TboxHashExtended(this.Ptr, seed);

        public bool Hast()
            => Meos.TboxHast(this.Ptr);

        public bool Hasx()
            => Meos.TboxHasx(this.Ptr);

        public TBox? Intersection(TBox box2)
            => MEOSFactory.WrapTBox(Meos.IntersectionTboxTbox(this.Ptr, box2.Ptr));

        public bool Le(TBox box2)
            => Meos.TboxLe(this.Ptr, box2.Ptr);

        public bool Left(TBox box2)
            => Meos.LeftTboxTbox(this.Ptr, box2.Ptr);

        public bool Left(Span s)
            => Meos.LeftTboxNumspan(this.Ptr, s.Ptr);

        public bool Left(TNumber temp)
            => Meos.LeftTboxTnumber(this.Ptr, temp.Ptr);

        public bool Left(BigIntSpan s)
            => Meos.LeftTboxNumspan(this.Ptr, s.Ptr);

        public bool Left(FloatSpan s)
            => Meos.LeftTboxNumspan(this.Ptr, s.Ptr);

        public bool Left(IntSpan s)
            => Meos.LeftTboxNumspan(this.Ptr, s.Ptr);

        public bool Left(TBigint temp)
            => Meos.LeftTboxTnumber(this.Ptr, temp.Ptr);

        public bool Left(TFloat temp)
            => Meos.LeftTboxTnumber(this.Ptr, temp.Ptr);

        public bool Left(TInt temp)
            => Meos.LeftTboxTnumber(this.Ptr, temp.Ptr);

        public bool Lt(TBox box2)
            => Meos.TboxLt(this.Ptr, box2.Ptr);

        public bool Ne(TBox box2)
            => Meos.TboxNe(this.Ptr, box2.Ptr);

        public string Out(int maxdd)
            => Meos.TboxOut(this.Ptr, maxdd);

        public bool Overafter(TBox box2)
            => Meos.OverafterTboxTbox(this.Ptr, box2.Ptr);

        public bool Overafter(TsTzSpan s)
            => Meos.OverafterTboxTstzspan(this.Ptr, s.Ptr);

        public bool Overafter(TNumber temp)
            => Meos.OverafterTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overafter(TBigint temp)
            => Meos.OverafterTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overafter(TFloat temp)
            => Meos.OverafterTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overafter(TInt temp)
            => Meos.OverafterTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overbefore(TBox box2)
            => Meos.OverbeforeTboxTbox(this.Ptr, box2.Ptr);

        public bool Overbefore(TsTzSpan s)
            => Meos.OverbeforeTboxTstzspan(this.Ptr, s.Ptr);

        public bool Overbefore(TNumber temp)
            => Meos.OverbeforeTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overbefore(TBigint temp)
            => Meos.OverbeforeTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overbefore(TFloat temp)
            => Meos.OverbeforeTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overbefore(TInt temp)
            => Meos.OverbeforeTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overlaps(TBox box2)
            => Meos.OverlapsTboxTbox(this.Ptr, box2.Ptr);

        public bool Overlaps(Span s)
            => Meos.OverlapsTboxNumspan(this.Ptr, s.Ptr);

        public bool Overlaps(TsTzSpan s)
            => Meos.OverlapsTboxTstzspan(this.Ptr, s.Ptr);

        public bool Overlaps(TNumber temp)
            => Meos.OverlapsTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overlaps(BigIntSpan s)
            => Meos.OverlapsTboxNumspan(this.Ptr, s.Ptr);

        public bool Overlaps(FloatSpan s)
            => Meos.OverlapsTboxNumspan(this.Ptr, s.Ptr);

        public bool Overlaps(IntSpan s)
            => Meos.OverlapsTboxNumspan(this.Ptr, s.Ptr);

        public bool Overlaps(TBigint temp)
            => Meos.OverlapsTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overlaps(TFloat temp)
            => Meos.OverlapsTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overlaps(TInt temp)
            => Meos.OverlapsTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overleft(TBox box2)
            => Meos.OverleftTboxTbox(this.Ptr, box2.Ptr);

        public bool Overleft(Span s)
            => Meos.OverleftTboxNumspan(this.Ptr, s.Ptr);

        public bool Overleft(TNumber temp)
            => Meos.OverleftTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overleft(BigIntSpan s)
            => Meos.OverleftTboxNumspan(this.Ptr, s.Ptr);

        public bool Overleft(FloatSpan s)
            => Meos.OverleftTboxNumspan(this.Ptr, s.Ptr);

        public bool Overleft(IntSpan s)
            => Meos.OverleftTboxNumspan(this.Ptr, s.Ptr);

        public bool Overleft(TBigint temp)
            => Meos.OverleftTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overleft(TFloat temp)
            => Meos.OverleftTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overleft(TInt temp)
            => Meos.OverleftTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overright(TBox box2)
            => Meos.OverrightTboxTbox(this.Ptr, box2.Ptr);

        public bool Overright(Span s)
            => Meos.OverrightTboxNumspan(this.Ptr, s.Ptr);

        public bool Overright(TNumber temp)
            => Meos.OverrightTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overright(BigIntSpan s)
            => Meos.OverrightTboxNumspan(this.Ptr, s.Ptr);

        public bool Overright(FloatSpan s)
            => Meos.OverrightTboxNumspan(this.Ptr, s.Ptr);

        public bool Overright(IntSpan s)
            => Meos.OverrightTboxNumspan(this.Ptr, s.Ptr);

        public bool Overright(TBigint temp)
            => Meos.OverrightTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overright(TFloat temp)
            => Meos.OverrightTboxTnumber(this.Ptr, temp.Ptr);

        public bool Overright(TInt temp)
            => Meos.OverrightTboxTnumber(this.Ptr, temp.Ptr);

        public bool Right(TBox box2)
            => Meos.RightTboxTbox(this.Ptr, box2.Ptr);

        public bool Right(Span s)
            => Meos.RightTboxNumspan(this.Ptr, s.Ptr);

        public bool Right(TNumber temp)
            => Meos.RightTboxTnumber(this.Ptr, temp.Ptr);

        public bool Right(BigIntSpan s)
            => Meos.RightTboxNumspan(this.Ptr, s.Ptr);

        public bool Right(FloatSpan s)
            => Meos.RightTboxNumspan(this.Ptr, s.Ptr);

        public bool Right(IntSpan s)
            => Meos.RightTboxNumspan(this.Ptr, s.Ptr);

        public bool Right(TBigint temp)
            => Meos.RightTboxTnumber(this.Ptr, temp.Ptr);

        public bool Right(TFloat temp)
            => Meos.RightTboxTnumber(this.Ptr, temp.Ptr);

        public bool Right(TInt temp)
            => Meos.RightTboxTnumber(this.Ptr, temp.Ptr);

        public TBox? Round(int maxdd)
            => MEOSFactory.WrapTBox(Meos.TboxRound(this.Ptr, maxdd));

        public bool Same(TBox box2)
            => Meos.SameTboxTbox(this.Ptr, box2.Ptr);

        public bool Same(Span s)
            => Meos.SameTboxNumspan(this.Ptr, s.Ptr);

        public bool Same(TsTzSpan s)
            => Meos.SameTboxTstzspan(this.Ptr, s.Ptr);

        public bool Same(TNumber temp)
            => Meos.SameTboxTnumber(this.Ptr, temp.Ptr);

        public bool Same(BigIntSpan s)
            => Meos.SameTboxNumspan(this.Ptr, s.Ptr);

        public bool Same(FloatSpan s)
            => Meos.SameTboxNumspan(this.Ptr, s.Ptr);

        public bool Same(IntSpan s)
            => Meos.SameTboxNumspan(this.Ptr, s.Ptr);

        public bool Same(TBigint temp)
            => Meos.SameTboxTnumber(this.Ptr, temp.Ptr);

        public bool Same(TFloat temp)
            => Meos.SameTboxTnumber(this.Ptr, temp.Ptr);

        public bool Same(TInt temp)
            => Meos.SameTboxTnumber(this.Ptr, temp.Ptr);

        public TBox? ScaleTime(Interval duration)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBox(Meos.TboxScaleTime(this.Ptr, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public TBox? ShiftScaleTime(Interval shift, Interval duration)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBox(Meos.TboxShiftScaleTime(this.Ptr, _shift, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
                Marshal.FreeHGlobal(_duration);
            }
        }

        public TBox? ShiftTime(Interval shift)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                return MEOSFactory.WrapTBox(Meos.TboxShiftTime(this.Ptr, _shift));
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
                IntPtr _bytes = Meos.TboxSortkey(this.Ptr, _size);
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

        public TBox?[] TimeTiles(Interval duration, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TboxTimeTiles(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), border_inc));
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
                if (!Meos.TboxTmax(this.Ptr, _result))
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
                if (!Meos.TboxTmaxInc(this.Ptr, _result))
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
                if (!Meos.TboxTmin(this.Ptr, _result))
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
                if (!Meos.TboxTminInc(this.Ptr, _result))
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

        public Span? ToBigintspan()
            => MEOSFactory.WrapSpan(Meos.TboxToBigintspan(this.Ptr));

        public Span? ToFloatspan()
            => MEOSFactory.WrapSpan(Meos.TboxToFloatspan(this.Ptr));

        public Span? ToIntspan()
            => MEOSFactory.WrapSpan(Meos.TboxToIntspan(this.Ptr));

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(Meos.TboxToTstzspan(this.Ptr));

        public TBox? Union(TBox box2, bool strict)
            => MEOSFactory.WrapTBox(Meos.UnionTboxTbox(this.Ptr, box2.Ptr, strict));

        public double? Xmax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TboxXmax(this.Ptr, _result))
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

        public bool? XmaxInc()
        {
            IntPtr _result = Marshal.AllocHGlobal(1);
            try
            {
                if (!Meos.TboxXmaxInc(this.Ptr, _result))
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

        public double? Xmin()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TboxXmin(this.Ptr, _result))
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

        public bool? XminInc()
        {
            IntPtr _result = Marshal.AllocHGlobal(1);
            try
            {
                if (!Meos.TboxXminInc(this.Ptr, _result))
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

        public static TBox? FromBigint(long i)
            => MEOSFactory.WrapTBox(Meos.BigintToTbox(i));

        public static TBox? FromBigintTimestamptz(long i, DateTime t)
            => MEOSFactory.WrapTBox(Meos.BigintTimestamptzToTbox(i, MEOSConvert.ToTimestampTz(t)));

        public static TBox? FromBigintTstzspan(long i, Span s)
            => MEOSFactory.WrapTBox(Meos.BigintTstzspanToTbox(i, s.Ptr));

        public static TBox? FromFloat(double d)
            => MEOSFactory.WrapTBox(Meos.FloatToTbox(d));

        public static TBox? FromFloatTimestamptz(double d, DateTime t)
            => MEOSFactory.WrapTBox(Meos.FloatTimestamptzToTbox(d, MEOSConvert.ToTimestampTz(t)));

        public static TBox? FromFloatTstzspan(double d, Span s)
            => MEOSFactory.WrapTBox(Meos.FloatTstzspanToTbox(d, s.Ptr));

        public static TBox? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapTBox(Meos.TboxFromHexwkb(hexwkb));

        public static TBox? FromInt(int i)
            => MEOSFactory.WrapTBox(Meos.IntToTbox(i));

        public static TBox? FromIntTimestamptz(int i, DateTime t)
            => MEOSFactory.WrapTBox(Meos.IntTimestamptzToTbox(i, MEOSConvert.ToTimestampTz(t)));

        public static TBox? FromIntTstzspan(int i, Span s)
            => MEOSFactory.WrapTBox(Meos.IntTstzspanToTbox(i, s.Ptr));

        public static TBox? FromNumspanTimestamptz(Span span, DateTime t)
            => MEOSFactory.WrapTBox(Meos.NumspanTimestamptzToTbox(span.Ptr, MEOSConvert.ToTimestampTz(t)));

        public static TBox? FromNumspanTstzspan(Span s, Span p)
            => MEOSFactory.WrapTBox(Meos.NumspanTstzspanToTbox(s.Ptr, p.Ptr));

        public static TBox? FromText(string str)
            => TBox.In(str);

        public static TBox? FromTimestamptz(DateTime t)
            => MEOSFactory.WrapTBox(Meos.TimestamptzToTbox(MEOSConvert.ToTimestampTz(t)));

        public static TBox? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTBox(Meos.TboxFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static TBox? GetTimeTile(DateTime t, Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBox(Meos.TboxGetTimeTile(MEOSConvert.ToTimestampTz(t), _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public static TBox? GetValueTile(double value, double vsize, double vorigin)
            => MEOSFactory.WrapTBox(Meos.TboxGetValueTile(value, vsize, vorigin));

        public static TBox? GetValueTimeTile(double value, DateTime t, double vsize, Interval duration, double vorigin, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBox(Meos.TboxGetValueTimeTile(value, MEOSConvert.ToTimestampTz(t), vsize, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public static TBox? In(string str)
            => MEOSFactory.WrapTBox(Meos.TboxIn(str));

        public static TBox? Make(Span s, Span p)
            => MEOSFactory.WrapTBox(Meos.TboxMake(s.Ptr, p.Ptr));

    }
}
