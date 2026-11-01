#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The QuadbinSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class QuadbinSet : SpatialSet
    {
        internal QuadbinSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Set? CompactCells()
            => MEOSFactory.WrapSet(Meos.QuadbinsetCompactCells(this.Ptr));

        public Set? CoverCells(int resolution)
            => MEOSFactory.WrapSet(Meos.QuadbinsetCoverCells(this.Ptr, resolution));

        public ulong EndValue()
            => Meos.QuadbinsetEndValue(this.Ptr);

        public Set? GridDisk(int k)
            => MEOSFactory.WrapSet(Meos.QuadbinsetGridDisk(this.Ptr, k));

        public string Out()
            => Meos.QuadbinsetOut(this.Ptr);

        public ulong StartValue()
            => Meos.QuadbinsetStartValue(this.Ptr);

        public Set? UncompactCells(int resolution)
            => MEOSFactory.WrapSet(Meos.QuadbinsetUncompactCells(this.Ptr, resolution));

        public ulong[] Values()
            => Meos.QuadbinsetValues(this.Ptr);

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => QuadbinSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => QuadbinSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.QuadbinsetIn(str));

        public static Set? Make(ulong[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.QuadbinsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
