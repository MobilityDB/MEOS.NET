#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The PoseSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PoseSet : Set
    {
        internal PoseSet(IntPtr ptr) : base(ptr) { }

        public string Out(int maxdd)
            => Meos.PosesetOut(this.Ptr, maxdd);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.PosesetIn(str));

    }
}
