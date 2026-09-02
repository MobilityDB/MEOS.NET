#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The NpointSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class NpointSet : Set
    {
        internal NpointSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public string Out(int maxdd)
            => Meos.NpointsetOut(this.Ptr, maxdd);

        public Set? Routes()
            => MEOSFactory.WrapSet(Meos.NpointsetRoutes(this.Ptr));

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.NpointsetIn(str));

    }
}
