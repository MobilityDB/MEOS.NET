#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Non-numeric, non-spatial temporal types (step/discrete interpolation only). A real MEOS grouping (talpha_type) with no user-facing class name in PyMEOS — see corrections.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TAlpha : Temporal
    {
        internal TAlpha(IntPtr ptr) : base(ptr) { }

        public bool Adjacent(TAlpha temp2)
            => Meos.AdjacentTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool After(TAlpha temp2)
            => Meos.AfterTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysOverlaps(TsTzSpan s)
            => Meos.AlwaysOverlapsTemporalTstzspan(this.Ptr, s.Ptr);

        public bool Before(TAlpha temp2)
            => Meos.BeforeTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Contained(TAlpha temp2)
            => Meos.ContainedTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Contains(TAlpha temp2)
            => Meos.ContainsTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverOverlaps(TsTzSpan s)
            => Meos.EverOverlapsTemporalTstzspan(this.Ptr, s.Ptr);

        public bool Overafter(TAlpha temp2)
            => Meos.OverafterTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Overbefore(TAlpha temp2)
            => Meos.OverbeforeTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Overlaps(TAlpha temp2)
            => Meos.OverlapsTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Same(TAlpha temp2)
            => Meos.SameTemporalTemporal(this.Ptr, temp2.Ptr);

    }
}
