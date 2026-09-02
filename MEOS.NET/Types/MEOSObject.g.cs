#nullable enable

namespace MEOS.NET.Types
{
    /// <summary>
    /// A handle on a value MEOS owns.  The pointer is what every generated method
    /// forwards to the C API; the memory behind it belongs to MEOS.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public abstract class MEOSObject
    {
        /// <summary>The MEOS value this object holds, for the functions on
        /// <see cref="MEOS.NET.Functions.Meos"/> that take it.</summary>
        public IntPtr Ptr { get; }

        internal MEOSObject(IntPtr ptr) => this.Ptr = ptr;
    }
}
