#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TRGeometry of subtype TSequenceSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TRGeometrySeqSet : TRGeometry
    {
        internal TRGeometrySeqSet(IntPtr ptr) : base(ptr) { }

        public Temporal? Make(Temporal[] sequences, bool normalize)
        {
            IntPtr[] _sequencesValues = new IntPtr[sequences.Length];
            for (int i = 0; i < sequences.Length; i++)
            {
                _sequencesValues[i] = sequences[i].Ptr;
            }

            GCHandle _sequences = GCHandle.Alloc(_sequencesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TrgeometryseqsetMake(this.Ptr, _sequences.AddrOfPinnedObject(), sequences.Length, normalize));
            }
            finally
            {
                _sequences.Free();
            }
        }

    }
}
