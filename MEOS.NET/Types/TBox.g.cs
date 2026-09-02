#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

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

        public int Cmp(TBox box2)
            => Meos.TboxCmp(this.Ptr, box2.Ptr);

        public TBox? Copy()
            => MEOSFactory.WrapTBox(Meos.TboxCopy(this.Ptr));

        public bool Eq(TBox box2)
            => Meos.TboxEq(this.Ptr, box2.Ptr);

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

        public bool Le(TBox box2)
            => Meos.TboxLe(this.Ptr, box2.Ptr);

        public bool Lt(TBox box2)
            => Meos.TboxLt(this.Ptr, box2.Ptr);

        public bool Ne(TBox box2)
            => Meos.TboxNe(this.Ptr, box2.Ptr);

        public string Out(int maxdd)
            => Meos.TboxOut(this.Ptr, maxdd);

        public TBox? Round(int maxdd)
            => MEOSFactory.WrapTBox(Meos.TboxRound(this.Ptr, maxdd));

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

        public static TBox? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapTBox(Meos.TboxFromHexwkb(hexwkb));

        public static TBox? In(string str)
            => MEOSFactory.WrapTBox(Meos.TboxIn(str));

        public static TBox? Make(Span s, Span p)
            => MEOSFactory.WrapTBox(Meos.TboxMake(s.Ptr, p.Ptr));

    }
}
