#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TQuadbin class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TQuadbin : TCellIndex
    {
        internal TQuadbin(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public int AlwaysEq(ulong cell)
            => Meos.AlwaysEqTquadbinQuadbin(this.Ptr, cell);

        public int AlwaysEq(TQuadbin temp2)
            => Meos.AlwaysEqTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public int AlwaysNe(ulong cell)
            => Meos.AlwaysNeTquadbinQuadbin(this.Ptr, cell);

        public int AlwaysNe(TQuadbin temp2)
            => Meos.AlwaysNeTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public Temporal? AtValue(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TquadbinAtValue(this.Ptr, cell));

        public Temporal? CellToQuadkey()
            => MEOSFactory.WrapTemporal(Meos.TquadbinCellToQuadkey(this.Ptr));

        public ulong EndValue()
            => Meos.TquadbinEndValue(this.Ptr);

        public int EverEq(QuadbinSet cells)
            => Meos.EverEqTquadbinQuadbinset(this.Ptr, cells.Ptr);

        public int EverEq(ulong cell)
            => Meos.EverEqTquadbinQuadbin(this.Ptr, cell);

        public int EverEq(TQuadbin temp2)
            => Meos.EverEqTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public int EverNe(ulong cell)
            => Meos.EverNeTquadbinQuadbin(this.Ptr, cell);

        public int EverNe(TQuadbin temp2)
            => Meos.EverNeTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public Temporal? GridDistance(Temporal dest)
            => MEOSFactory.WrapTemporal(Meos.TquadbinGridDistance(this.Ptr, dest.Ptr));

        public Temporal? MinusValue(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TquadbinMinusValue(this.Ptr, cell));

        public string Out()
            => Meos.TquadbinOut(this.Ptr);

        public int RalwaysEq(ulong cell)
            => Meos.AlwaysEqQuadbinTquadbin(cell, this.Ptr);

        public int RalwaysNe(ulong cell)
            => Meos.AlwaysNeQuadbinTquadbin(cell, this.Ptr);

        public int ReverEq(ulong cell)
            => Meos.EverEqQuadbinTquadbin(cell, this.Ptr);

        public int ReverNe(ulong cell)
            => Meos.EverNeQuadbinTquadbin(cell, this.Ptr);

        public Temporal? Rteq(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TeqQuadbinTquadbin(cell, this.Ptr));

        public Temporal? Rtne(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TneQuadbinTquadbin(cell, this.Ptr));

        public ulong StartValue()
            => Meos.TquadbinStartValue(this.Ptr);

        public Temporal? Teq(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TeqTquadbinQuadbin(this.Ptr, cell));

        public Temporal? Tne(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TneTquadbinQuadbin(this.Ptr, cell));

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.TquadbinToTbigint(this.Ptr));

        public (SpanSet?[], ulong[]) Unnest()
        {
            var _answered = Meos.TquadbinUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), _answered.Item2);
        }

        public ulong Value()
            => Meos.TquadbinValue(this.Ptr);

        public ulong[] Values()
            => Meos.TquadbinValues(this.Ptr);

        public static Temporal? FromBaseTemp(ulong value, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TquadbinFromBaseTemp(value, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TQuadbin.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TquadbinFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TQuadbin.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TquadbinIn(str));

        public static Temporal? Make(ulong value, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TquadbinMake(value, MEOSConvert.ToTimestampTz(t)));

    }
}
