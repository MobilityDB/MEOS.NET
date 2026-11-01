#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The S2CellSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class S2CellSet : SpatialSet
    {
        internal S2CellSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Set? CompactCells()
            => MEOSFactory.WrapSet(Meos.S2cellsetCompactCells(this.Ptr));

        public Set? CoverCells(int resolution)
            => MEOSFactory.WrapSet(Meos.S2cellsetCoverCells(this.Ptr, resolution));

        public ulong EndValue()
            => Meos.S2cellsetEndValue(this.Ptr);

        public string Out()
            => Meos.S2cellsetOut(this.Ptr);

        public ulong StartValue()
            => Meos.S2cellsetStartValue(this.Ptr);

        public Set? UncompactCells(int resolution)
            => MEOSFactory.WrapSet(Meos.S2cellsetUncompactCells(this.Ptr, resolution));

        public ulong[] Values()
            => Meos.S2cellsetValues(this.Ptr);

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => S2CellSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => S2CellSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.S2cellsetIn(str));

        public static Set? Make(ulong[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.S2cellsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
