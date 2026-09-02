#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pgsql_compat.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr MeosPcPointSerialize(IntPtr pcpt)
            => SafeExecution<IntPtr>(() => Native.MeosPcPointSerialize(pcpt));

        public static IntPtr MeosPcPointDeserialize(IntPtr serpt, IntPtr schema)
            => SafeExecution<IntPtr>(() => Native.MeosPcPointDeserialize(serpt, schema));

        public static ulong MeosPcPatchSerializedSize(IntPtr patch)
            => SafeExecution<ulong>(() => Native.MeosPcPatchSerializedSize(patch));

        public static IntPtr MeosPcPatchSerialize(IntPtr patch_in, IntPtr userdata)
            => SafeExecution<IntPtr>(() => Native.MeosPcPatchSerialize(patch_in, userdata));

        public static IntPtr MeosPcPatchSerializeToUncompressed(IntPtr patch_in)
            => SafeExecution<IntPtr>(() => Native.MeosPcPatchSerializeToUncompressed(patch_in));

        public static IntPtr MeosPcPatchDeserialize(IntPtr serpatch, IntPtr schema)
            => SafeExecution<IntPtr>(() => Native.MeosPcPatchDeserialize(serpatch, schema));

    }
}
