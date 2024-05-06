using MEOS.NET.Types.General;

namespace MEOS.NET.Types.Temporal
{
    public abstract class Temporal<T> : MEOSObject
    {
        internal Temporal(IntPtr ptr) : base(ptr)
        { }
    }
}
