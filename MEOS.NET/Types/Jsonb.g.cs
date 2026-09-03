#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

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

        public Jsonb? DeleteArray(Text[] keys_elems)
        {
            IntPtr[] _keys_elemsValues = new IntPtr[keys_elems.Length];
            for (int i = 0; i < keys_elems.Length; i++)
            {
                _keys_elemsValues[i] = keys_elems[i].Ptr;
            }

            GCHandle _keys_elems = GCHandle.Alloc(_keys_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapJsonb(Meos.JsonbDeleteArray(this.Ptr, _keys_elems.AddrOfPinnedObject(), keys_elems.Length));
            }
            finally
            {
                _keys_elems.Free();
            }
        }

        public Jsonb? DeleteIndex(int idx)
            => MEOSFactory.WrapJsonb(Meos.JsonbDeleteIndex(this.Ptr, idx));

        public Jsonb? DeletePath(Text[] path_elems)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapJsonb(Meos.JsonbDeletePath(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public bool Exists(Text key)
            => Meos.JsonbExists(this.Ptr, key.Ptr);

        public bool ExistsArray(Text[] keys_elems, bool any)
        {
            IntPtr[] _keys_elemsValues = new IntPtr[keys_elems.Length];
            for (int i = 0; i < keys_elems.Length; i++)
            {
                _keys_elemsValues[i] = keys_elems[i].Ptr;
            }

            GCHandle _keys_elems = GCHandle.Alloc(_keys_elemsValues, GCHandleType.Pinned);
            try
            {
                return Meos.JsonbExistsArray(this.Ptr, _keys_elems.AddrOfPinnedObject(), keys_elems.Length, any);
            }
            finally
            {
                _keys_elems.Free();
            }
        }

        public Jsonb? ExtractPath(Text[] path_elems)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapJsonb(Meos.JsonbExtractPath(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public Text? ExtractPathText(Text[] path_elems)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapText(Meos.JsonbExtractPathText(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public uint Hash()
            => Meos.JsonbHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.JsonbHashExtended(this.Ptr, seed);

        public Jsonb? Insert(Text[] path_elems, Jsonb newjb, bool after)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapJsonb(Meos.JsonbInsert(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length, newjb.Ptr, after));
            }
            finally
            {
                _path_elems.Free();
            }
        }

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

        public Jsonb? Set(Text[] path_elems, Jsonb newjb, bool create)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapJsonb(Meos.JsonbSet(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length, newjb.Ptr, create));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public Jsonb? SetLax(Text[] path_elems, Jsonb newjb, bool create, Text handle_null)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapJsonb(Meos.JsonbSetLax(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length, newjb.Ptr, create, handle_null.Ptr));
            }
            finally
            {
                _path_elems.Free();
            }
        }

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
