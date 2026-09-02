#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TextSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TextSet : Set
    {
        internal TextSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Text? EndValue()
            => MEOSFactory.WrapText(Meos.TextsetEndValue(this.Ptr));

        public Set? Initcap()
            => MEOSFactory.WrapSet(Meos.TextsetInitcap(this.Ptr));

        public Set? Lower()
            => MEOSFactory.WrapSet(Meos.TextsetLower(this.Ptr));

        public string Out()
            => Meos.TextsetOut(this.Ptr);

        public Text? StartValue()
            => MEOSFactory.WrapText(Meos.TextsetStartValue(this.Ptr));

        public Set? Upper()
            => MEOSFactory.WrapSet(Meos.TextsetUpper(this.Ptr));

        public Text?[] Values()
            => MEOSFactory.WrapTextArray(Meos.TextsetValues(this.Ptr));

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.TextsetIn(str));

        public static Set? Make(Text[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.TextsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
