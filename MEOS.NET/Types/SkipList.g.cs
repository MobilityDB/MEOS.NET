#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The state of a temporal aggregate, the value every transition and combine function of a temporal aggregate takes and answers and taggstate_serialize and taggstate_deserialize write and read. MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class SkipList : Value
    {
        internal SkipList(IntPtr ptr) : base(ptr) { }

        public byte[]? Serialize()
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.TaggstateSerialize(this.Ptr, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public static SkipList? Deserialize(byte[] bytes)
        {
            GCHandle _bytes = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSkipList(Meos.TaggstateDeserialize(_bytes.AddrOfPinnedObject(), (ulong) bytes.Length));
            }
            finally
            {
                _bytes.Free();
            }
        }

    }
}
