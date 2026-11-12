#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A path into a jsonb value. A MeosType no membership predicate admits, as NSegment and RaQuet are; the nine signatures naming it are what need it.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class JsonPath : Value
    {
        internal JsonPath(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText();

        public string AsText()
            => Meos.JsonpathOut(this.Ptr);

        public JsonPath? Copy()
            => MEOSFactory.WrapJsonPath(Meos.JsonpathCopy(this.Ptr));

        public int MemSize()
            => Meos.JsonpathMemSize(this.Ptr);

        public static JsonPath? FromText(string str)
            => MEOSFactory.WrapJsonPath(Meos.JsonpathIn(str));

    }
}
