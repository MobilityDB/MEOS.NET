#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

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

        public string AsText()
            => this.Out();

        public bool Contains(Text t)
            => Meos.ContainsSetText(this.Ptr, t.Ptr);

        public Text? EndValue()
            => MEOSFactory.WrapText(Meos.TextsetEndValue(this.Ptr));

        public Set? Initcap()
            => MEOSFactory.WrapSet(Meos.TextsetInitcap(this.Ptr));

        public Set? Intersection(Text txt)
            => MEOSFactory.WrapSet(Meos.IntersectionSetText(this.Ptr, txt.Ptr));

        public bool Left(Text txt)
            => Meos.LeftSetText(this.Ptr, txt.Ptr);

        public Set? Lower()
            => MEOSFactory.WrapSet(Meos.TextsetLower(this.Ptr));

        public Set? Minus(Text txt)
            => MEOSFactory.WrapSet(Meos.MinusSetText(this.Ptr, txt.Ptr));

        public string Out()
            => Meos.TextsetOut(this.Ptr);

        public bool Overleft(Text txt)
            => Meos.OverleftSetText(this.Ptr, txt.Ptr);

        public bool Overright(Text txt)
            => Meos.OverrightSetText(this.Ptr, txt.Ptr);

        public bool Right(Text txt)
            => Meos.RightSetText(this.Ptr, txt.Ptr);

        public Text? StartValue()
            => MEOSFactory.WrapText(Meos.TextsetStartValue(this.Ptr));

        public Set? Textcat(Text txt)
            => MEOSFactory.WrapSet(Meos.TextcatTextsetText(this.Ptr, txt.Ptr));

        public Set? ToJsonbset()
            => MEOSFactory.WrapSet(Meos.TextsetToJsonbset(this.Ptr));

        public Set? Union(Text txt)
            => MEOSFactory.WrapSet(Meos.UnionSetText(this.Ptr, txt.Ptr));

        public Set? Upper()
            => MEOSFactory.WrapSet(Meos.TextsetUpper(this.Ptr));

        public Text? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TextsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapText(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Text?[] Values()
            => MEOSFactory.WrapTextArray(Meos.TextsetValues(this.Ptr));

        public static Set? FromText(string str)
            => TextSet.In(str);

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
