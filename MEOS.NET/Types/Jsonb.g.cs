#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>PostgreSQL jsonb, the base type of TJsonb and JsonbSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Jsonb : Value
    {
        internal Jsonb(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Jsonb? ArrayElement(int element)
            => MEOSFactory.WrapJsonb(Meos.JsonbArrayElement(this.Ptr, element));

        public Text? ArrayElementText(int element)
            => MEOSFactory.WrapText(Meos.JsonbArrayElementText(this.Ptr, element));

        public Jsonb?[] ArrayElements()
            => MEOSFactory.WrapJsonbArray(Meos.JsonbArrayElements(this.Ptr));

        public Text?[] ArrayElementsText()
            => MEOSFactory.WrapTextArray(Meos.JsonbArrayElementsText(this.Ptr));

        public int ArrayLength()
            => Meos.JsonbArrayLength(this.Ptr);

        public Jsonb? Concat(Jsonb jb2)
            => MEOSFactory.WrapJsonb(Meos.JsonbConcat(this.Ptr, jb2.Ptr));

        public bool Contained(Jsonb jb2)
            => Meos.JsonbContained(this.Ptr, jb2.Ptr);

        public Jsonb? Copy()
            => MEOSFactory.WrapJsonb(Meos.JsonbCopy(this.Ptr));

        public Jsonb? Delete(Text key)
            => MEOSFactory.WrapJsonb(Meos.JsonbDelete(this.Ptr, key.Ptr));

        public Jsonb? DeleteIndex(int idx)
            => MEOSFactory.WrapJsonb(Meos.JsonbDeleteIndex(this.Ptr, idx));

        public bool Exists(Text key)
            => Meos.JsonbExists(this.Ptr, key.Ptr);

        public uint Hash()
            => Meos.JsonbHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.JsonbHashExtended(this.Ptr, seed);

        public Jsonb? ObjectField(Text key)
            => MEOSFactory.WrapJsonb(Meos.JsonbObjectField(this.Ptr, key.Ptr));

        public Text? ObjectFieldText(Text key)
            => MEOSFactory.WrapText(Meos.JsonbObjectFieldText(this.Ptr, key.Ptr));

        public Text?[] ObjectKeys()
            => MEOSFactory.WrapTextArray(Meos.JsonbObjectKeys(this.Ptr));

        public string Out()
            => Meos.JsonbOut(this.Ptr);

        public Text? Pretty()
            => MEOSFactory.WrapText(Meos.JsonbPretty(this.Ptr));

        public Jsonb? StripNulls(bool strip_in_arrays)
            => MEOSFactory.WrapJsonb(Meos.JsonbStripNulls(this.Ptr, strip_in_arrays));

        public bool ToBool()
            => Meos.JsonbToBool(this.Ptr);

        public string ToCstring()
            => Meos.JsonbToCstring(this.Ptr);

        public short ToInt16()
            => Meos.JsonbToInt16(this.Ptr);

        public int ToInt32()
            => Meos.JsonbToInt32(this.Ptr);

        public long ToInt64()
            => Meos.JsonbToInt64(this.Ptr);

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.JsonbToSet(this.Ptr));

        public Text? ToText()
            => MEOSFactory.WrapText(Meos.JsonbToText(this.Ptr));

        public static Jsonb? FromText(Text txt, bool unique_keys)
            => MEOSFactory.WrapJsonb(Meos.JsonbFromText(txt.Ptr, unique_keys));

        public static Jsonb? In(string str)
            => MEOSFactory.WrapJsonb(Meos.JsonbIn(str));

        public static Jsonb? Make(Text[] keys_vals)
        {
            IntPtr[] _keys_valsValues = new IntPtr[keys_vals.Length];
            for (int i = 0; i < keys_vals.Length; i++)
            {
                _keys_valsValues[i] = keys_vals[i].Ptr;
            }

            GCHandle _keys_vals = GCHandle.Alloc(_keys_valsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapJsonb(Meos.JsonbMake(_keys_vals.AddrOfPinnedObject(), keys_vals.Length));
            }
            finally
            {
                _keys_vals.Free();
            }
        }

    }
}
