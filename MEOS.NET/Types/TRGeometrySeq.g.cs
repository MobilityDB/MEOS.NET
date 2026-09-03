#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>A TRGeometry of subtype TSequence.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TRGeometrySeq : TRGeometry
    {
        internal TRGeometrySeq(IntPtr ptr) : base(ptr) { }

        public static Temporal? Make(Geo geom, Temporal[] instants, bool lower_inc, bool upper_inc, InterpType interp, bool normalize)
        {
            IntPtr[] _instantsValues = new IntPtr[instants.Length];
            for (int i = 0; i < instants.Length; i++)
            {
                _instantsValues[i] = instants[i].Ptr;
            }

            GCHandle _instants = GCHandle.Alloc(_instantsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TrgeometryseqMake(geom.Ptr, _instants.AddrOfPinnedObject(), instants.Length, lower_inc, upper_inc, (int) interp, normalize));
            }
            finally
            {
                _instants.Free();
            }
        }

    }
}
