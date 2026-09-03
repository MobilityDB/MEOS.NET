#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TSequenceSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TSequenceSet : Temporal
    {
        internal TSequenceSet(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(Temporal[] sequences, bool normalize)
        {
            IntPtr[] _sequencesValues = new IntPtr[sequences.Length];
            for (int i = 0; i < sequences.Length; i++)
            {
                _sequencesValues[i] = sequences[i].Ptr;
            }

            GCHandle _sequences = GCHandle.Alloc(_sequencesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TsequencesetMake(_sequences.AddrOfPinnedObject(), sequences.Length, normalize));
            }
            finally
            {
                _sequences.Free();
            }
        }

        public static Temporal? MakeGaps(Temporal[] instants, InterpType interp, Interval maxt, double maxdist)
        {
            IntPtr _maxt = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            IntPtr[] _instantsValues = new IntPtr[instants.Length];
            for (int i = 0; i < instants.Length; i++)
            {
                _instantsValues[i] = instants[i].Ptr;
            }

            GCHandle _instants = GCHandle.Alloc(_instantsValues, GCHandleType.Pinned);
            try
            {
                Marshal.StructureToPtr(maxt, _maxt, false);
                return MEOSFactory.WrapTemporal(Meos.TsequencesetMakeGaps(_instants.AddrOfPinnedObject(), instants.Length, (int) interp, _maxt, maxdist));
            }
            finally
            {
                Marshal.FreeHGlobal(_maxt);
                _instants.Free();
            }
        }

    }
}
