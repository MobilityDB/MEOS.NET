#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_json.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr JsonIn(string str)
            => SafeExecution<IntPtr>(() => Native.JsonIn(str));

        public static string JsonOut(IntPtr js)
            => SafeExecution<string>(() => Native.JsonOut(js));

        public static IntPtr JsonbFromText(IntPtr txt, bool unique_keys)
            => SafeExecution<IntPtr>(() => Native.JsonbFromText(txt, unique_keys));

        public static IntPtr JsonbIn(string str)
            => SafeExecution<IntPtr>(() => Native.JsonbIn(str));

        public static string JsonbOut(IntPtr jb)
            => SafeExecution<string>(() => Native.JsonbOut(jb));

        public static IntPtr JsonMake(IntPtr keys_vals, int count)
            => SafeExecution<IntPtr>(() => Native.JsonMake(keys_vals, count));

        public static IntPtr JsonMakeTwoArg(IntPtr keys, IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.JsonMakeTwoArg(keys, values, count));

        public static IntPtr JsonbCopy(IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.JsonbCopy(jb));

        public static IntPtr JsonbMake(IntPtr keys_vals, int count)
            => SafeExecution<IntPtr>(() => Native.JsonbMake(keys_vals, count));

        public static IntPtr JsonbMakeTwoArg(IntPtr keys, IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.JsonbMakeTwoArg(keys, values, count));

        public static bool JsonbToBool(IntPtr jb)
            => SafeExecution<bool>(() => Native.JsonbToBool(jb));

        public static string JsonbToCstring(IntPtr jb)
            => SafeExecution<string>(() => Native.JsonbToCstring(jb));

        public static float JsonbToFloat4(IntPtr jb)
            => SafeExecution<float>(() => Native.JsonbToFloat4(jb));

        public static double JsonbToFloat8(IntPtr jb)
            => SafeExecution<double>(() => Native.JsonbToFloat8(jb));

        public static short JsonbToInt16(IntPtr jb)
            => SafeExecution<short>(() => Native.JsonbToInt16(jb));

        public static int JsonbToInt32(IntPtr jb)
            => SafeExecution<int>(() => Native.JsonbToInt32(jb));

        public static long JsonbToInt64(IntPtr jb)
            => SafeExecution<long>(() => Native.JsonbToInt64(jb));

        public static IntPtr JsonbToNumeric(IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.JsonbToNumeric(jb));

        public static IntPtr JsonbToText(IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.JsonbToText(jb));

        public static IntPtr JsonArrayElement(IntPtr js, int element)
            => SafeExecution<IntPtr>(() => Native.JsonArrayElement(js, element));

        public static IntPtr JsonArrayElementText(IntPtr js, int element)
            => SafeExecution<IntPtr>(() => Native.JsonArrayElementText(js, element));

        public static IntPtr[] JsonArrayElements(IntPtr js)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonArrayElements(js, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] JsonArrayElementsText(IntPtr js)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonArrayElementsText(js, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int JsonArrayLength(IntPtr js)
            => SafeExecution<int>(() => Native.JsonArrayLength(js));

        public static IntPtr[] JsonEach(IntPtr js, IntPtr values)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonEach(js, values, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] JsonEachText(IntPtr js, IntPtr values)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonEachText(js, values, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr JsonExtractPath(IntPtr js, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.JsonExtractPath(js, path_elems, path_len));

        public static IntPtr JsonExtractPathText(IntPtr js, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.JsonExtractPathText(js, path_elems, path_len));

        public static IntPtr JsonObjectField(IntPtr js, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.JsonObjectField(js, key));

        public static IntPtr JsonObjectFieldText(IntPtr js, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.JsonObjectFieldText(js, key));

        public static IntPtr[] JsonObjectKeys(IntPtr js)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonObjectKeys(js, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr JsonTypeof(IntPtr js)
            => SafeExecution<IntPtr>(() => Native.JsonTypeof(js));

        public static IntPtr JsonbArrayElement(IntPtr jb, int element)
            => SafeExecution<IntPtr>(() => Native.JsonbArrayElement(jb, element));

        public static IntPtr JsonbArrayElementText(IntPtr jb, int element)
            => SafeExecution<IntPtr>(() => Native.JsonbArrayElementText(jb, element));

        public static IntPtr[] JsonbArrayElements(IntPtr jb)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbArrayElements(jb, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] JsonbArrayElementsText(IntPtr jb)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbArrayElementsText(jb, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int JsonbArrayLength(IntPtr jb)
            => SafeExecution<int>(() => Native.JsonbArrayLength(jb));

        public static bool JsonbContained(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.JsonbContained(jb1, jb2));

        public static bool JsonbContains(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.JsonbContains(jb1, jb2));

        public static IntPtr[] JsonbEach(IntPtr jb, IntPtr values)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbEach(jb, values, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] JsonbEachText(IntPtr jb, IntPtr values)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbEachText(jb, values, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool JsonbExists(IntPtr jb, IntPtr key)
            => SafeExecution<bool>(() => Native.JsonbExists(jb, key));

        public static bool JsonbExistsArray(IntPtr jb, IntPtr keys_elems, int keys_len, bool any)
            => SafeExecution<bool>(() => Native.JsonbExistsArray(jb, keys_elems, keys_len, any));

        public static IntPtr JsonbExtractPath(IntPtr jb, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.JsonbExtractPath(jb, path_elems, path_len));

        public static IntPtr JsonbExtractPathText(IntPtr jb, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.JsonbExtractPathText(jb, path_elems, path_len));

        public static uint JsonbHash(IntPtr jb)
            => SafeExecution<uint>(() => Native.JsonbHash(jb));

        public static ulong JsonbHashExtended(IntPtr jb, ulong seed)
            => SafeExecution<ulong>(() => Native.JsonbHashExtended(jb, seed));

        public static IntPtr JsonbObjectField(IntPtr jb, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.JsonbObjectField(jb, key));

        public static IntPtr JsonbObjectFieldText(IntPtr jb, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.JsonbObjectFieldText(jb, key));

        public static IntPtr[] JsonbObjectKeys(IntPtr jb)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbObjectKeys(jb, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr JsonStripNulls(IntPtr js, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => Native.JsonStripNulls(js, strip_in_arrays));

        public static IntPtr JsonbConcat(IntPtr jb1, IntPtr jb2)
            => SafeExecution<IntPtr>(() => Native.JsonbConcat(jb1, jb2));

        public static IntPtr JsonbDelete(IntPtr jb, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.JsonbDelete(jb, key));

        public static IntPtr JsonbDeleteArray(IntPtr jb, IntPtr keys_elems, int keys_len)
            => SafeExecution<IntPtr>(() => Native.JsonbDeleteArray(jb, keys_elems, keys_len));

        public static IntPtr JsonbDeleteIndex(IntPtr jb, int idx)
            => SafeExecution<IntPtr>(() => Native.JsonbDeleteIndex(jb, idx));

        public static IntPtr JsonbDeletePath(IntPtr jb, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.JsonbDeletePath(jb, path_elems, path_len));

        public static IntPtr JsonbInsert(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, bool after)
            => SafeExecution<IntPtr>(() => Native.JsonbInsert(jb, path_elems, path_len, newjb, after));

        public static IntPtr JsonbPretty(IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.JsonbPretty(jb));

        public static IntPtr JsonbSet(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, bool create)
            => SafeExecution<IntPtr>(() => Native.JsonbSet(jb, path_elems, path_len, newjb, create));

        public static IntPtr JsonbSetLax(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, bool create, IntPtr handle_null)
            => SafeExecution<IntPtr>(() => Native.JsonbSetLax(jb, path_elems, path_len, newjb, create, handle_null));

        public static IntPtr JsonbStripNulls(IntPtr jb, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => Native.JsonbStripNulls(jb, strip_in_arrays));

        public static int JsonbCmp(IntPtr jb1, IntPtr jb2)
            => SafeExecution<int>(() => Native.JsonbCmp(jb1, jb2));

        public static bool JsonbEq(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.JsonbEq(jb1, jb2));

        public static bool JsonbGe(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.JsonbGe(jb1, jb2));

        public static bool JsonbGt(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.JsonbGt(jb1, jb2));

        public static bool JsonbLe(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.JsonbLe(jb1, jb2));

        public static bool JsonbLt(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.JsonbLt(jb1, jb2));

        public static bool JsonbNe(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.JsonbNe(jb1, jb2));

        public static int JsonbPathExists(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<int>(() => Native.JsonbPathExists(jb, jp, vars, silent, tz));

        public static bool JsonbPathMatch(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<bool>(() => Native.JsonbPathMatch(jb, jp, vars, silent, tz));

        public static IntPtr[] JsonbPathQueryAll(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbPathQueryAll(jb, jp, vars, silent, tz, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr JsonbPathQueryArray(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.JsonbPathQueryArray(jb, jp, vars, silent, tz));

        public static IntPtr JsonbPathQueryFirst(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.JsonbPathQueryFirst(jb, jp, vars, silent, tz));

        public static IntPtr JsonpathIn(string str)
            => SafeExecution<IntPtr>(() => Native.JsonpathIn(str));

        public static IntPtr JsonpathCopy(IntPtr jp)
            => SafeExecution<IntPtr>(() => Native.JsonpathCopy(jp));

        public static string JsonpathOut(IntPtr jp)
            => SafeExecution<string>(() => Native.JsonpathOut(jp));

        public static IntPtr JsonbsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.JsonbsetIn(str));

        public static string JsonbsetOut(IntPtr s, int maxdd)
            => SafeExecution<string>(() => Native.JsonbsetOut(s, maxdd));

        public static IntPtr JsonbsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.JsonbsetMake(values, count));

        public static IntPtr JsonbToSet(IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.JsonbToSet(jb));

        public static IntPtr JsonbsetEndValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.JsonbsetEndValue(s));

        public static IntPtr JsonbsetStartValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.JsonbsetStartValue(s));

        public static bool JsonbsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.JsonbsetValueN(s, n, result));

        public static IntPtr[] JsonbsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr ConcatJsonbsetJsonb(IntPtr s, IntPtr jb, bool invert)
            => SafeExecution<IntPtr>(() => Native.ConcatJsonbsetJsonb(s, jb, invert));

        public static IntPtr JsonbsetArrayLength(IntPtr set)
            => SafeExecution<IntPtr>(() => Native.JsonbsetArrayLength(set));

        public static IntPtr JsonbsetObjectField(IntPtr set, IntPtr key, bool astext, int null_handle)
            => SafeExecution<IntPtr>(() => Native.JsonbsetObjectField(set, key, astext, null_handle));

        public static IntPtr JsonbsetArrayElement(IntPtr set, int idx, bool astext, int null_handle)
            => SafeExecution<IntPtr>(() => Native.JsonbsetArrayElement(set, idx, astext, null_handle));

        public static IntPtr JsonbsetDeleteIndex(IntPtr set, int idx)
            => SafeExecution<IntPtr>(() => Native.JsonbsetDeleteIndex(set, idx));

        public static IntPtr JsonbsetDelete(IntPtr set, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.JsonbsetDelete(set, key));

        public static IntPtr JsonbsetDeleteArray(IntPtr set, IntPtr keys, int count)
            => SafeExecution<IntPtr>(() => Native.JsonbsetDeleteArray(set, keys, count));

        public static bool[] JsonbsetExists(IntPtr set, IntPtr key)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbsetExists(set, key, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                bool[] _out = new bool[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadByte(_p, _i) != 0; }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr JsonbsetExistsArray(IntPtr set, IntPtr keys, int count, bool any, IntPtr rescount)
            => SafeExecution<IntPtr>(() => Native.JsonbsetExistsArray(set, keys, count, any, rescount));

        public static IntPtr JsonbsetSet(IntPtr set, IntPtr keys, int count, IntPtr newjb, bool create, IntPtr null_handle, bool lax)
            => SafeExecution<IntPtr>(() => Native.JsonbsetSet(set, keys, count, newjb, create, null_handle, lax));

        public static IntPtr JsonbsetToAlphanumset(IntPtr set, string key, int settype, int null_handle)
            => SafeExecution<IntPtr>(() => Native.JsonbsetToAlphanumset(set, key, settype, null_handle));

        public static IntPtr JsonbsetToIntset(IntPtr set, string key, int null_handle)
            => SafeExecution<IntPtr>(() => Native.JsonbsetToIntset(set, key, null_handle));

        public static IntPtr JsonbsetToBigintset(IntPtr set, string key, int null_handle)
            => SafeExecution<IntPtr>(() => Native.JsonbsetToBigintset(set, key, null_handle));

        public static IntPtr JsonbsetToFloatset(IntPtr set, string key, int null_handle)
            => SafeExecution<IntPtr>(() => Native.JsonbsetToFloatset(set, key, null_handle));

        public static IntPtr JsonbsetToTextsetKey(IntPtr set, string key, int null_handle)
            => SafeExecution<IntPtr>(() => Native.JsonbsetToTextsetKey(set, key, null_handle));

        public static IntPtr JsonbsetStripNulls(IntPtr set, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => Native.JsonbsetStripNulls(set, strip_in_arrays));

        public static IntPtr JsonbsetPretty(IntPtr set)
            => SafeExecution<IntPtr>(() => Native.JsonbsetPretty(set));

        public static IntPtr JsonbsetDeletePath(IntPtr set, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.JsonbsetDeletePath(set, path_elems, path_len));

        public static IntPtr JsonbsetExtractPath(IntPtr set, IntPtr path_elems, int path_len, bool astext, int null_handle)
            => SafeExecution<IntPtr>(() => Native.JsonbsetExtractPath(set, path_elems, path_len, astext, null_handle));

        public static IntPtr JsonbsetInsert(IntPtr set, IntPtr path_elems, int path_len, IntPtr newjb, bool after)
            => SafeExecution<IntPtr>(() => Native.JsonbsetInsert(set, path_elems, path_len, newjb, after));

        public static bool[] JsonbsetPathExists(IntPtr set, IntPtr jp, IntPtr vars, bool silent, bool tz)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbsetPathExists(set, jp, vars, silent, tz, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                bool[] _out = new bool[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadByte(_p, _i) != 0; }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool[] JsonbsetPathMatch(IntPtr set, IntPtr jp, IntPtr vars, bool silent, bool tz)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.JsonbsetPathMatch(set, jp, vars, silent, tz, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                bool[] _out = new bool[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadByte(_p, _i) != 0; }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr JsonbsetPathQueryArray(IntPtr set, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.JsonbsetPathQueryArray(set, jp, vars, silent, tz));

        public static IntPtr JsonbsetPathQueryFirst(IntPtr set, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.JsonbsetPathQueryFirst(set, jp, vars, silent, tz));

        public static bool ContainedJsonbSet(IntPtr jb, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedJsonbSet(jb, s));

        public static bool ContainsSetJsonb(IntPtr s, IntPtr jb)
            => SafeExecution<bool>(() => Native.ContainsSetJsonb(s, jb));

        public static IntPtr IntersectionJsonbSet(IntPtr jb, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionJsonbSet(jb, s));

        public static IntPtr IntersectionSetJsonb(IntPtr s, IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetJsonb(s, jb));

        public static IntPtr JsonbUnionTransfn(IntPtr state, IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.JsonbUnionTransfn(state, jb));

        public static IntPtr MinusJsonbSet(IntPtr jb, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusJsonbSet(jb, s));

        public static IntPtr MinusSetJsonb(IntPtr s, IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.MinusSetJsonb(s, jb));

        public static IntPtr UnionJsonbSet(IntPtr jb, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionJsonbSet(jb, s));

        public static IntPtr UnionSetJsonb(IntPtr s, IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.UnionSetJsonb(s, jb));

        public static IntPtr TjsonbFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TjsonbFromMfjson(str));

        public static IntPtr TjsonbIn(string str)
            => SafeExecution<IntPtr>(() => Native.TjsonbIn(str));

        public static string TjsonbOut(IntPtr temp)
            => SafeExecution<string>(() => Native.TjsonbOut(temp));

        public static IntPtr TjsonbinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TjsonbinstIn(str));

        public static IntPtr TjsonbseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TjsonbseqIn(str, interp));

        public static IntPtr TjsonbseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TjsonbseqsetIn(str));

        public static IntPtr TjsonbFromBaseTemp(IntPtr jsonb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TjsonbFromBaseTemp(jsonb, temp));

        public static IntPtr TjsonbinstMake(IntPtr jsonb, long t)
            => SafeExecution<IntPtr>(() => Native.TjsonbinstMake(jsonb, t));

        public static IntPtr TjsonbseqFromBaseTstzset(IntPtr jsonb, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TjsonbseqFromBaseTstzset(jsonb, s));

        public static IntPtr TjsonbseqFromBaseTstzspan(IntPtr jsonb, IntPtr sp)
            => SafeExecution<IntPtr>(() => Native.TjsonbseqFromBaseTstzspan(jsonb, sp));

        public static IntPtr TjsonbseqsetFromBaseTstzspanset(IntPtr jsonb, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TjsonbseqsetFromBaseTstzspanset(jsonb, ss));

        public static IntPtr TjsonbToTtext(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TjsonbToTtext(temp));

        public static IntPtr TtextToTjsonb(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextToTjsonb(temp));

        public static IntPtr TjsonbEndValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TjsonbEndValue(temp));

        public static IntPtr TjsonbStartValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TjsonbStartValue(temp));

        public static bool TjsonbValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TjsonbValueAtTimestamptz(temp, t, strict, value));

        public static bool TjsonbValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TjsonbValueN(temp, n, result));

        public static IntPtr[] TjsonbValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TjsonbValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr ConcatTjsonbJsonb(IntPtr temp, IntPtr jb, bool invert)
            => SafeExecution<IntPtr>(() => Native.ConcatTjsonbJsonb(temp, jb, invert));

        public static IntPtr ConcatTjsonbTjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.ConcatTjsonbTjsonb(temp1, temp2));

        public static IntPtr ContainsTjsonbJsonb(IntPtr temp, IntPtr jb, bool invert)
            => SafeExecution<IntPtr>(() => Native.ContainsTjsonbJsonb(temp, jb, invert));

        public static IntPtr ContainsTjsonbTjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.ContainsTjsonbTjsonb(temp1, temp2));

        public static int NullHandleTypeFromString(string str)
            => SafeExecution<int>(() => Native.NullHandleTypeFromString(str));

        public static IntPtr TjsonArrayElement(IntPtr temp, int idx, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonArrayElement(temp, idx, null_handle));

        public static IntPtr TjsonArrayLength(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TjsonArrayLength(temp));

        public static IntPtr TjsonExtractPath(IntPtr temp, IntPtr path_elems, int path_len, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonExtractPath(temp, path_elems, path_len, null_handle));

        public static IntPtr TjsonObjectField(IntPtr temp, IntPtr key, bool astext, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonObjectField(temp, key, astext, null_handle));

        public static IntPtr TjsonStripNulls(IntPtr temp, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => Native.TjsonStripNulls(temp, strip_in_arrays));

        public static IntPtr TjsonbArrayElement(IntPtr temp, int idx, bool astext, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonbArrayElement(temp, idx, astext, null_handle));

        public static IntPtr TjsonbArrayLength(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TjsonbArrayLength(temp));

        public static IntPtr TjsonbDelete(IntPtr temp, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.TjsonbDelete(temp, key));

        public static IntPtr TjsonbDeleteArray(IntPtr temp, IntPtr keys, int count)
            => SafeExecution<IntPtr>(() => Native.TjsonbDeleteArray(temp, keys, count));

        public static IntPtr TjsonbDeleteIndex(IntPtr temp, int idx)
            => SafeExecution<IntPtr>(() => Native.TjsonbDeleteIndex(temp, idx));

        public static IntPtr TjsonbDeletePath(IntPtr temp, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.TjsonbDeletePath(temp, path_elems, path_len));

        public static IntPtr TjsonbExists(IntPtr temp, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.TjsonbExists(temp, key));

        public static IntPtr TjsonbExistsAll(IntPtr temp, IntPtr keys, int count)
            => SafeExecution<IntPtr>(() => Native.TjsonbExistsAll(temp, keys, count));

        public static IntPtr TjsonbExistsAny(IntPtr temp, IntPtr keys, int count)
            => SafeExecution<IntPtr>(() => Native.TjsonbExistsAny(temp, keys, count));

        public static IntPtr TjsonbExistsArray(IntPtr temp, IntPtr keys, int count, bool any)
            => SafeExecution<IntPtr>(() => Native.TjsonbExistsArray(temp, keys, count, any));

        public static IntPtr TjsonbExtractPath(IntPtr temp, IntPtr path_elems, int path_len, bool astext, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonbExtractPath(temp, path_elems, path_len, astext, null_handle));

        public static IntPtr TjsonbInsert(IntPtr temp, IntPtr keys, int count, IntPtr newjb, bool after)
            => SafeExecution<IntPtr>(() => Native.TjsonbInsert(temp, keys, count, newjb, after));

        public static IntPtr TjsonbObjectField(IntPtr temp, IntPtr key, bool astext, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonbObjectField(temp, key, astext, null_handle));

        public static IntPtr TjsonbPathExists(IntPtr temp, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.TjsonbPathExists(temp, jp, vars, silent, tz));

        public static IntPtr TjsonbPathMatch(IntPtr temp, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.TjsonbPathMatch(temp, jp, vars, silent, tz));

        public static IntPtr TjsonbPathQueryArray(IntPtr temp, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.TjsonbPathQueryArray(temp, jp, vars, silent, tz));

        public static IntPtr TjsonbPathQueryFirst(IntPtr temp, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.TjsonbPathQueryFirst(temp, jp, vars, silent, tz));

        public static IntPtr TjsonbPretty(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TjsonbPretty(temp));

        public static IntPtr TjsonbSet(IntPtr temp, IntPtr keys, int count, IntPtr newjb, bool create, IntPtr handle_null, bool lax)
            => SafeExecution<IntPtr>(() => Native.TjsonbSet(temp, keys, count, newjb, create, handle_null, lax));

        public static IntPtr TjsonbStripNulls(IntPtr temp, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => Native.TjsonbStripNulls(temp, strip_in_arrays));

        public static IntPtr TjsonbToTbool(IntPtr temp, string key, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonbToTbool(temp, key, null_handle));

        public static IntPtr TjsonbToTfloat(IntPtr temp, string key, int interp, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonbToTfloat(temp, key, interp, null_handle));

        public static IntPtr TjsonbToTint(IntPtr temp, string key, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonbToTint(temp, key, null_handle));

        public static IntPtr TjsonbToTtextKey(IntPtr temp, string key, int null_handle)
            => SafeExecution<IntPtr>(() => Native.TjsonbToTtextKey(temp, key, null_handle));

        public static IntPtr TjsonbAtValue(IntPtr temp, IntPtr jsb)
            => SafeExecution<IntPtr>(() => Native.TjsonbAtValue(temp, jsb));

        public static IntPtr TjsonbMinusValue(IntPtr temp, IntPtr jsb)
            => SafeExecution<IntPtr>(() => Native.TjsonbMinusValue(temp, jsb));

        public static int AlwaysEqJsonbTjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqJsonbTjsonb(jb, temp));

        public static int AlwaysEqTjsonbJsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<int>(() => Native.AlwaysEqTjsonbJsonb(temp, jb));

        public static int AlwaysEqTjsonbTjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTjsonbTjsonb(temp1, temp2));

        public static int AlwaysNeJsonbTjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeJsonbTjsonb(jb, temp));

        public static int AlwaysNeTjsonbJsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<int>(() => Native.AlwaysNeTjsonbJsonb(temp, jb));

        public static int AlwaysNeTjsonbTjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTjsonbTjsonb(temp1, temp2));

        public static int EverEqJsonbTjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqJsonbTjsonb(jb, temp));

        public static int EverEqTjsonbJsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<int>(() => Native.EverEqTjsonbJsonb(temp, jb));

        public static int EverEqTjsonbTjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTjsonbTjsonb(temp1, temp2));

        public static int EverNeJsonbTjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeJsonbTjsonb(jb, temp));

        public static int EverNeTjsonbJsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<int>(() => Native.EverNeTjsonbJsonb(temp, jb));

        public static int EverNeTjsonbTjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTjsonbTjsonb(temp1, temp2));

        public static IntPtr TeqJsonbTjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqJsonbTjsonb(jb, temp));

        public static IntPtr TeqTjsonbJsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.TeqTjsonbJsonb(temp, jb));

        public static IntPtr TneJsonbTjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneJsonbTjsonb(jb, temp));

        public static IntPtr TneTjsonbJsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.TneTjsonbJsonb(temp, jb));

    }
}
