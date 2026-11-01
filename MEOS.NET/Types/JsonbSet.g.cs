#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The JsonbSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class JsonbSet : Set
    {
        internal JsonbSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Set? ArrayElement(int idx, NullHandleType null_handle)
            => MEOSFactory.WrapSet(Meos.JsonbsetArrayElement(this.Ptr, idx, (int) null_handle));

        public Set? ArrayElementText(int idx, NullHandleType null_handle)
            => MEOSFactory.WrapSet(Meos.JsonbsetArrayElementText(this.Ptr, idx, (int) null_handle));

        public Set? ArrayLength()
            => MEOSFactory.WrapSet(Meos.JsonbsetArrayLength(this.Ptr));

        public string AsText()
            => this.Out();

        public Set? Delete(Text key)
            => MEOSFactory.WrapSet(Meos.JsonbsetDelete(this.Ptr, key.Ptr));

        public Set? DeleteArray(Text[] keys)
        {
            IntPtr[] _keysValues = new IntPtr[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                _keysValues[i] = keys[i].Ptr;
            }

            GCHandle _keys = GCHandle.Alloc(_keysValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.JsonbsetDeleteArray(this.Ptr, _keys.AddrOfPinnedObject(), keys.Length));
            }
            finally
            {
                _keys.Free();
            }
        }

        public Set? DeleteIndex(int idx)
            => MEOSFactory.WrapSet(Meos.JsonbsetDeleteIndex(this.Ptr, idx));

        public Set? DeletePath(Text[] path_elems)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.JsonbsetDeletePath(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public Jsonb? EndValue()
            => MEOSFactory.WrapJsonb(Meos.JsonbsetEndValue(this.Ptr));

        public bool[] Exists(Text key)
            => Meos.JsonbsetExists(this.Ptr, key.Ptr);

        public Set? ExtractPath(Text[] path_elems, NullHandleType null_handle)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.JsonbsetExtractPath(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length, (int) null_handle));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public Set? ExtractPathText(Text[] path_elems, NullHandleType null_handle)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.JsonbsetExtractPathText(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length, (int) null_handle));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public Set? Insert(Text[] path_elems, Jsonb newjb, bool after)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.JsonbsetInsert(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length, newjb.Ptr, after));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public Set? ObjectField(Text key, NullHandleType null_handle)
            => MEOSFactory.WrapSet(Meos.JsonbsetObjectField(this.Ptr, key.Ptr, (int) null_handle));

        public Set? ObjectFieldText(Text key, NullHandleType null_handle)
            => MEOSFactory.WrapSet(Meos.JsonbsetObjectFieldText(this.Ptr, key.Ptr, (int) null_handle));

        public string Out()
            => Meos.JsonbsetOut(this.Ptr);

        public bool[] PathExists(JsonPath jp, Jsonb vars, bool silent, bool tz)
            => Meos.JsonbsetPathExists(this.Ptr, jp.Ptr, vars.Ptr, silent, tz);

        public bool[] PathMatch(JsonPath jp, Jsonb vars, bool silent, bool tz)
            => Meos.JsonbsetPathMatch(this.Ptr, jp.Ptr, vars.Ptr, silent, tz);

        public Set? PathQueryArray(JsonPath jp, Jsonb vars, bool silent, bool tz)
            => MEOSFactory.WrapSet(Meos.JsonbsetPathQueryArray(this.Ptr, jp.Ptr, vars.Ptr, silent, tz));

        public Set? PathQueryFirst(JsonPath jp, Jsonb vars, bool silent, bool tz)
            => MEOSFactory.WrapSet(Meos.JsonbsetPathQueryFirst(this.Ptr, jp.Ptr, vars.Ptr, silent, tz));

        public Set? Pretty()
            => MEOSFactory.WrapSet(Meos.JsonbsetPretty(this.Ptr));

        public Set? Set(Text[] keys, Jsonb newjb, bool create, Text null_handle, bool lax)
        {
            IntPtr[] _keysValues = new IntPtr[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                _keysValues[i] = keys[i].Ptr;
            }

            GCHandle _keys = GCHandle.Alloc(_keysValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.JsonbsetSet(this.Ptr, _keys.AddrOfPinnedObject(), keys.Length, newjb.Ptr, create, null_handle.Ptr, lax));
            }
            finally
            {
                _keys.Free();
            }
        }

        public Jsonb? StartValue()
            => MEOSFactory.WrapJsonb(Meos.JsonbsetStartValue(this.Ptr));

        public Set? StripNulls(bool strip_in_arrays)
            => MEOSFactory.WrapSet(Meos.JsonbsetStripNulls(this.Ptr, strip_in_arrays));

        public Set? ToAlphanumset(string key, MeosType settype, NullHandleType null_handle)
            => MEOSFactory.WrapSet(Meos.JsonbsetToAlphanumset(this.Ptr, key, (int) settype, (int) null_handle));

        public Set? ToBigintset(string key, NullHandleType null_handle)
            => MEOSFactory.WrapSet(Meos.JsonbsetToBigintset(this.Ptr, key, (int) null_handle));

        public Set? ToFloatset(string key, NullHandleType null_handle)
            => MEOSFactory.WrapSet(Meos.JsonbsetToFloatset(this.Ptr, key, (int) null_handle));

        public Set? ToIntset(string key, NullHandleType null_handle)
            => MEOSFactory.WrapSet(Meos.JsonbsetToIntset(this.Ptr, key, (int) null_handle));

        public Set? ToTextset()
            => MEOSFactory.WrapSet(Meos.JsonbsetToTextset(this.Ptr));

        public Set? ToTextsetKey(string key, NullHandleType null_handle)
            => MEOSFactory.WrapSet(Meos.JsonbsetToTextsetKey(this.Ptr, key, (int) null_handle));

        public Jsonb? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.JsonbsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapJsonb(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Jsonb?[] Values()
            => MEOSFactory.WrapJsonbArray(Meos.JsonbsetValues(this.Ptr));

        public static Set? FromText(string str)
            => JsonbSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.JsonbsetIn(str));

        public static Set? Make(Jsonb[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.JsonbsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
