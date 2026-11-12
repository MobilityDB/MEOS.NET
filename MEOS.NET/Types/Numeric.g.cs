#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>PostgreSQL's arbitrary-precision number, the value jsonb_to_numeric and the extract functions of the time types answer and numeric_in and numeric_out read and write. MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Numeric : Value
    {
        internal Numeric(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText();

        public string AsText()
            => Meos.NumericOut(this.Ptr);

        public static Numeric? FromText(string str, int typmod)
            => MEOSFactory.WrapNumeric(Meos.NumericIn(str, typmod));

    }
}
