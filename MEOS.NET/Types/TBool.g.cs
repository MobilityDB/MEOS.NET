#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TBool class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBool : TAlpha
    {
        internal TBool(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public bool Adjacent(TBool temp2)
            => Meos.AdjacentTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool After(TBool temp2)
            => Meos.AfterTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysEq(bool b)
            => Meos.AlwaysEqTboolBool(this.Ptr, b);

        public int AlwaysEq(TBool temp2)
            => Meos.AlwaysEqTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysNe(bool b)
            => Meos.AlwaysNeTboolBool(this.Ptr, b);

        public int AlwaysNe(TBool temp2)
            => Meos.AlwaysNeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysOverlaps(TBool temp2)
            => Meos.AlwaysOverlapsTemporalTemporal(this.Ptr, temp2.Ptr);

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public Temporal? AtValue(bool b)
            => MEOSFactory.WrapTemporal(Meos.TboolAtValue(this.Ptr, b));

        public bool Before(TBool temp2)
            => Meos.BeforeTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Contained(TBool temp2)
            => Meos.ContainedTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Contains(TBool temp2)
            => Meos.ContainsTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool EndValue()
            => Meos.TboolEndValue(this.Ptr);

        public int EverEq(bool b)
            => Meos.EverEqTboolBool(this.Ptr, b);

        public int EverEq(TBool temp2)
            => Meos.EverEqTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverNe(bool b)
            => Meos.EverNeTboolBool(this.Ptr, b);

        public int EverNe(TBool temp2)
            => Meos.EverNeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverOverlaps(TBool temp2)
            => Meos.EverOverlapsTemporalTemporal(this.Ptr, temp2.Ptr);

        public Temporal? MinusValue(bool b)
            => MEOSFactory.WrapTemporal(Meos.TboolMinusValue(this.Ptr, b));

        public bool Overafter(TBool temp2)
            => Meos.OverafterTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Overbefore(TBool temp2)
            => Meos.OverbeforeTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Overlaps(TBool temp2)
            => Meos.OverlapsTemporalTemporal(this.Ptr, temp2.Ptr);

        public int RalwaysEq(bool b)
            => Meos.AlwaysEqBoolTbool(b, this.Ptr);

        public int RalwaysNe(bool b)
            => Meos.AlwaysNeBoolTbool(b, this.Ptr);

        public int ReverEq(bool b)
            => Meos.EverEqBoolTbool(b, this.Ptr);

        public int ReverNe(bool b)
            => Meos.EverNeBoolTbool(b, this.Ptr);

        public Temporal? Rtand(bool b)
            => MEOSFactory.WrapTemporal(Meos.TandBoolTbool(b, this.Ptr));

        public Temporal? Rteq(bool b)
            => MEOSFactory.WrapTemporal(Meos.TeqBoolTbool(b, this.Ptr));

        public Temporal? Rtne(bool b)
            => MEOSFactory.WrapTemporal(Meos.TneBoolTbool(b, this.Ptr));

        public Temporal? Rtor(bool b)
            => MEOSFactory.WrapTemporal(Meos.TorBoolTbool(b, this.Ptr));

        public bool Same(TBool temp2)
            => Meos.SameTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool StartValue()
            => Meos.TboolStartValue(this.Ptr);

        public Temporal? Tand(bool b)
            => MEOSFactory.WrapTemporal(Meos.TandTboolBool(this.Ptr, b));

        public Temporal? Tand(TBool temp2)
            => MEOSFactory.WrapTemporal(Meos.TandTboolTbool(this.Ptr, temp2.Ptr));

        public Temporal? Teq(bool b)
            => MEOSFactory.WrapTemporal(Meos.TeqTboolBool(this.Ptr, b));

        public Temporal? Teq(TBool temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(bool b)
            => MEOSFactory.WrapTemporal(Meos.TneTboolBool(this.Ptr, b));

        public Temporal? Tne(TBool temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tnot()
            => MEOSFactory.WrapTemporal(Meos.TnotTbool(this.Ptr));

        public Temporal? ToTint()
            => MEOSFactory.WrapTemporal(Meos.TboolToTint(this.Ptr));

        public Temporal? Tor(bool b)
            => MEOSFactory.WrapTemporal(Meos.TorTboolBool(this.Ptr, b));

        public Temporal? Tor(TBool temp2)
            => MEOSFactory.WrapTemporal(Meos.TorTboolTbool(this.Ptr, temp2.Ptr));

        public (SpanSet?[], bool[]) Unnest()
        {
            var _answered = Meos.TboolUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), _answered.Item2);
        }

        public bool Value()
            => Meos.TboolValue(this.Ptr);

        public bool? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(1);
            try
            {
                if (!Meos.TboolValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return Marshal.ReadByte(_value) != 0;
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public bool? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(1);
            try
            {
                if (!Meos.TboolValueN(this.Ptr, n, _result))
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

        public bool[] Values()
            => Meos.TboolValues(this.Ptr);

        public SpanSet? WhenTrue()
            => MEOSFactory.WrapSpanSet(Meos.TboolWhenTrue(this.Ptr));

        public static Temporal? FromBaseTemp(bool b, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TboolFromBaseTemp(b, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TboolFromMfjson(str));

        public static Temporal? FromText(string str)
            => TBool.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TboolIn(str));

    }
}
