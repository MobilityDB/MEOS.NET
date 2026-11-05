#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>PostgreSQL text, the base type of TText and TextSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Text : Value
    {
        internal Text(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public uint Hash(uint collid)
            => Meos.TextHash(this.Ptr, collid);

        public ulong HashExtended(ulong seed, uint collid)
            => Meos.TextHashExtended(this.Ptr, seed, collid);

        public Text? Initcap()
            => MEOSFactory.WrapText(Meos.TextInitcap(this.Ptr));

        public Text? Lower()
            => MEOSFactory.WrapText(Meos.TextLower(this.Ptr));

        public string Out()
            => Meos.TextOut(this.Ptr);

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.TextToSet(this.Ptr));

        public Text? Upper()
            => MEOSFactory.WrapText(Meos.TextUpper(this.Ptr));

        public static Text? In(string str)
            => MEOSFactory.WrapText(Meos.TextIn(str));

    }
}
