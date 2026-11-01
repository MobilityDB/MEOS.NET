#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A TS2Cell of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TS2CellSeqSet : TS2Cell
    {
        internal TS2CellSeqSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? FromBaseTstzspanset(ulong value, SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellseqsetFromBaseTstzspanset(value, ss.Ptr));

        public static Temporal? Make(Temporal[] sequences)
        {
            IntPtr[] _sequencesValues = new IntPtr[sequences.Length];
            for (int i = 0; i < sequences.Length; i++)
            {
                _sequencesValues[i] = sequences[i].Ptr;
            }

            GCHandle _sequences = GCHandle.Alloc(_sequencesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.Ts2cellseqsetMake(_sequences.AddrOfPinnedObject(), sequences.Length));
            }
            finally
            {
                _sequences.Free();
            }
        }

    }
}
