#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TJsonb class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TJsonb : TAlpha
    {
        internal TJsonb(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Temporal? ArrayElement(int idx, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbArrayElement(this.Ptr, idx, (int) null_handle));

        public Temporal? ArrayElementText(int idx, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbArrayElementText(this.Ptr, idx, (int) null_handle));

        public Temporal? ArrayLength()
            => MEOSFactory.WrapTemporal(Meos.TjsonbArrayLength(this.Ptr));

        public Temporal? AtValue(Jsonb jsb)
            => MEOSFactory.WrapTemporal(Meos.TjsonbAtValue(this.Ptr, jsb.Ptr));

        public Temporal? Delete(Text key)
            => MEOSFactory.WrapTemporal(Meos.TjsonbDelete(this.Ptr, key.Ptr));

        public Temporal? DeleteArray(Text[] keys)
        {
            IntPtr[] _keysValues = new IntPtr[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                _keysValues[i] = keys[i].Ptr;
            }

            GCHandle _keys = GCHandle.Alloc(_keysValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TjsonbDeleteArray(this.Ptr, _keys.AddrOfPinnedObject(), keys.Length));
            }
            finally
            {
                _keys.Free();
            }
        }

        public Temporal? DeleteIndex(int idx)
            => MEOSFactory.WrapTemporal(Meos.TjsonbDeleteIndex(this.Ptr, idx));

        public Temporal? DeletePath(Text[] path_elems)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TjsonbDeletePath(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public Jsonb? EndValue()
            => MEOSFactory.WrapJsonb(Meos.TjsonbEndValue(this.Ptr));

        public Temporal? Exists(Text key)
            => MEOSFactory.WrapTemporal(Meos.TjsonbExists(this.Ptr, key.Ptr));

        public Temporal? ExistsAll(Text[] keys)
        {
            IntPtr[] _keysValues = new IntPtr[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                _keysValues[i] = keys[i].Ptr;
            }

            GCHandle _keys = GCHandle.Alloc(_keysValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TjsonbExistsAll(this.Ptr, _keys.AddrOfPinnedObject(), keys.Length));
            }
            finally
            {
                _keys.Free();
            }
        }

        public Temporal? ExistsAny(Text[] keys)
        {
            IntPtr[] _keysValues = new IntPtr[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                _keysValues[i] = keys[i].Ptr;
            }

            GCHandle _keys = GCHandle.Alloc(_keysValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TjsonbExistsAny(this.Ptr, _keys.AddrOfPinnedObject(), keys.Length));
            }
            finally
            {
                _keys.Free();
            }
        }

        public Temporal? ExistsArray(Text[] keys, bool any)
        {
            IntPtr[] _keysValues = new IntPtr[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                _keysValues[i] = keys[i].Ptr;
            }

            GCHandle _keys = GCHandle.Alloc(_keysValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TjsonbExistsArray(this.Ptr, _keys.AddrOfPinnedObject(), keys.Length, any));
            }
            finally
            {
                _keys.Free();
            }
        }

        public Temporal? ExtractPath(Text[] path_elems, NullHandleType null_handle)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TjsonbExtractPath(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length, (int) null_handle));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public Temporal? ExtractPathText(Text[] path_elems, NullHandleType null_handle)
        {
            IntPtr[] _path_elemsValues = new IntPtr[path_elems.Length];
            for (int i = 0; i < path_elems.Length; i++)
            {
                _path_elemsValues[i] = path_elems[i].Ptr;
            }

            GCHandle _path_elems = GCHandle.Alloc(_path_elemsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TjsonbExtractPathText(this.Ptr, _path_elems.AddrOfPinnedObject(), path_elems.Length, (int) null_handle));
            }
            finally
            {
                _path_elems.Free();
            }
        }

        public Temporal? Insert(Text[] keys, Jsonb newjb, bool after)
        {
            IntPtr[] _keysValues = new IntPtr[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                _keysValues[i] = keys[i].Ptr;
            }

            GCHandle _keys = GCHandle.Alloc(_keysValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TjsonbInsert(this.Ptr, _keys.AddrOfPinnedObject(), keys.Length, newjb.Ptr, after));
            }
            finally
            {
                _keys.Free();
            }
        }

        public Temporal? MinusValue(Jsonb jsb)
            => MEOSFactory.WrapTemporal(Meos.TjsonbMinusValue(this.Ptr, jsb.Ptr));

        public Temporal? ObjectField(Text key, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbObjectField(this.Ptr, key.Ptr, (int) null_handle));

        public Temporal? ObjectFieldText(Text key, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbObjectFieldText(this.Ptr, key.Ptr, (int) null_handle));

        public string Out()
            => Meos.TjsonbOut(this.Ptr);

        public Temporal? PathExists(JsonPath jp, Jsonb vars, bool silent, bool tz)
            => MEOSFactory.WrapTemporal(Meos.TjsonbPathExists(this.Ptr, jp.Ptr, vars.Ptr, silent, tz));

        public Temporal? PathMatch(JsonPath jp, Jsonb vars, bool silent, bool tz)
            => MEOSFactory.WrapTemporal(Meos.TjsonbPathMatch(this.Ptr, jp.Ptr, vars.Ptr, silent, tz));

        public Temporal? PathQueryArray(JsonPath jp, Jsonb vars, bool silent, bool tz)
            => MEOSFactory.WrapTemporal(Meos.TjsonbPathQueryArray(this.Ptr, jp.Ptr, vars.Ptr, silent, tz));

        public Temporal? PathQueryFirst(JsonPath jp, Jsonb vars, bool silent, bool tz)
            => MEOSFactory.WrapTemporal(Meos.TjsonbPathQueryFirst(this.Ptr, jp.Ptr, vars.Ptr, silent, tz));

        public Temporal? Pretty()
            => MEOSFactory.WrapTemporal(Meos.TjsonbPretty(this.Ptr));

        public Temporal? Set(Text[] keys, Jsonb newjb, bool create, Text handle_null, bool lax)
        {
            IntPtr[] _keysValues = new IntPtr[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                _keysValues[i] = keys[i].Ptr;
            }

            GCHandle _keys = GCHandle.Alloc(_keysValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TjsonbSet(this.Ptr, _keys.AddrOfPinnedObject(), keys.Length, newjb.Ptr, create, handle_null.Ptr, lax));
            }
            finally
            {
                _keys.Free();
            }
        }

        public Jsonb? StartValue()
            => MEOSFactory.WrapJsonb(Meos.TjsonbStartValue(this.Ptr));

        public Temporal? StripNulls(bool strip_in_arrays)
            => MEOSFactory.WrapTemporal(Meos.TjsonbStripNulls(this.Ptr, strip_in_arrays));

        public Temporal? ToTbigint(string key, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTbigint(this.Ptr, key, (int) null_handle));

        public Temporal? ToTbool(string key, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTbool(this.Ptr, key, (int) null_handle));

        public Temporal? ToTfloat(string key, InterpType interp, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTfloat(this.Ptr, key, (int) interp, (int) null_handle));

        public Temporal? ToTgeogpoint(string key, InterpType interp, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTgeogpoint(this.Ptr, key, (int) interp, (int) null_handle));

        public Temporal? ToTgeography(string key, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTgeography(this.Ptr, key, (int) null_handle));

        public Temporal? ToTgeometry(string key, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTgeometry(this.Ptr, key, (int) null_handle));

        public Temporal? ToTgeompoint(string key, InterpType interp, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTgeompoint(this.Ptr, key, (int) interp, (int) null_handle));

        public Temporal? ToTint(string key, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTint(this.Ptr, key, (int) null_handle));

        public Temporal? ToTtext()
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTtext(this.Ptr));

        public Temporal? ToTtextKey(string key, NullHandleType null_handle)
            => MEOSFactory.WrapTemporal(Meos.TjsonbToTtextKey(this.Ptr, key, (int) null_handle));

        public (SpanSet?[], Jsonb?[]) Unnest()
        {
            var _answered = Meos.TjsonbUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapJsonbArray(_answered.Item2));
        }

        public Jsonb? Value()
            => MEOSFactory.WrapJsonb(Meos.TjsonbValue(this.Ptr));

        public Jsonb? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TjsonbValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapJsonb(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Jsonb? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TjsonbValueN(this.Ptr, n, _result))
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
            => MEOSFactory.WrapJsonbArray(Meos.TjsonbValues(this.Ptr));

        public static Temporal? FromBaseTemp(Jsonb jsonb, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TjsonbFromBaseTemp(jsonb.Ptr, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TjsonbFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TjsonbIn(str));

    }
}
