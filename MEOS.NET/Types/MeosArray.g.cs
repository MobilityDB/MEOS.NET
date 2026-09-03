#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The growable array MEOS builds its own results in. MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class MeosArray : Value
    {
        internal MeosArray(IntPtr ptr) : base(ptr) { }

        public int Count()
            => Meos.MeosArrayCount(this.Ptr);

        public void Destroy()
            => Meos.MeosArrayDestroy(this.Ptr);

        public void DestroyFree()
            => Meos.MeosArrayDestroyFree(this.Ptr);

        public void Reset()
            => Meos.MeosArrayReset(this.Ptr);

        public void ResetFree()
            => Meos.MeosArrayResetFree(this.Ptr);

        public static MeosArray? Create(int elem_size)
            => MEOSFactory.WrapMeosArray(Meos.MeosArrayCreate(elem_size));

    }
}
