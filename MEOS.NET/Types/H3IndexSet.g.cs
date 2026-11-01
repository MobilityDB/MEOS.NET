#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The H3IndexSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class H3IndexSet : SpatialSet
    {
        internal H3IndexSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Set? CoverCells(int resolution)
            => MEOSFactory.WrapSet(Meos.H3indexsetCoverCells(this.Ptr, resolution));

        public ulong EndValue()
            => Meos.H3indexsetEndValue(this.Ptr);

        public Set? GridDisk(int k)
            => MEOSFactory.WrapSet(Meos.H3indexsetGridDisk(this.Ptr, k));

        public string Out()
            => Meos.H3indexsetOut(this.Ptr);

        public ulong StartValue()
            => Meos.H3indexsetStartValue(this.Ptr);

        public ulong[] Values()
            => Meos.H3indexsetValues(this.Ptr);

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => H3IndexSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => H3IndexSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.H3indexsetIn(str));

        public static Set? Make(ulong[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.H3indexsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
