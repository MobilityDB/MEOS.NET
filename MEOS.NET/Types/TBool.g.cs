#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TBool class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBool : TAlpha
    {
        internal TBool(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Temporal? AtValue(bool b)
            => MEOSFactory.WrapTemporal(Meos.TboolAtValue(this.Ptr, b));

        public bool EndValue()
            => Meos.TboolEndValue(this.Ptr);

        public Temporal? MinusValue(bool b)
            => MEOSFactory.WrapTemporal(Meos.TboolMinusValue(this.Ptr, b));

        public string Out()
            => Meos.TboolOut(this.Ptr);

        public bool StartValue()
            => Meos.TboolStartValue(this.Ptr);

        public Temporal? ToTint()
            => MEOSFactory.WrapTemporal(Meos.TboolToTint(this.Ptr));

        public SpanSet? WhenTrue()
            => MEOSFactory.WrapSpanSet(Meos.TboolWhenTrue(this.Ptr));

        public static Temporal? FromBaseTemp(bool b, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TboolFromBaseTemp(b, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TboolFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TboolIn(str));

    }
}
