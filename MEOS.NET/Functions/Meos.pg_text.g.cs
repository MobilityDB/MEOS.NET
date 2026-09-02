#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_text.h</c> declares.</summary>
    public static partial class Meos
    {
        public static uint CharHash(byte c)
            => SafeExecution<uint>(() => Native.CharHash(c));

        public static ulong CharHashExtended(byte c, ulong seed)
            => SafeExecution<ulong>(() => Native.CharHashExtended(c, seed));

        public static IntPtr IcuUnicodeVersion()
            => SafeExecution<IntPtr>(() => Native.IcuUnicodeVersion());

        public static IntPtr Int32ToBin(int num)
            => SafeExecution<IntPtr>(() => Native.Int32ToBin(num));

        public static IntPtr Int32ToHex(int num)
            => SafeExecution<IntPtr>(() => Native.Int32ToHex(num));

        public static IntPtr Int32ToOct(int num)
            => SafeExecution<IntPtr>(() => Native.Int32ToOct(num));

        public static IntPtr Int64ToBin(long num)
            => SafeExecution<IntPtr>(() => Native.Int64ToBin(num));

        public static IntPtr Int64ToHex(long num)
            => SafeExecution<IntPtr>(() => Native.Int64ToHex(num));

        public static IntPtr Int64ToOct(long num)
            => SafeExecution<IntPtr>(() => Native.Int64ToOct(num));

        public static IntPtr TextCat(IntPtr txt1, IntPtr txt2)
            => SafeExecution<IntPtr>(() => Native.TextCat(txt1, txt2));

        public static IntPtr TextConcat(IntPtr textarr, int count)
            => SafeExecution<IntPtr>(() => Native.TextConcat(textarr, count));

        public static IntPtr TextConcatWs(IntPtr textarr, int count, IntPtr sep)
            => SafeExecution<IntPtr>(() => Native.TextConcatWs(textarr, count, sep));

        public static bool TextEq(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextEq(txt1, txt2));

        public static bool TextGe(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextGe(txt1, txt2));

        public static bool TextGt(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextGt(txt1, txt2));

        public static uint TextHash(IntPtr txt, uint collid)
            => SafeExecution<uint>(() => Native.TextHash(txt, collid));

        public static ulong TextHashExtended(IntPtr txt, ulong seed, uint collid)
            => SafeExecution<ulong>(() => Native.TextHashExtended(txt, seed, collid));

        public static IntPtr TextLarger(IntPtr txt1, IntPtr txt2)
            => SafeExecution<IntPtr>(() => Native.TextLarger(txt1, txt2));

        public static bool TextLe(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextLe(txt1, txt2));

        public static IntPtr TextLeft(IntPtr txt, int n)
            => SafeExecution<IntPtr>(() => Native.TextLeft(txt, n));

        public static int TextLen(IntPtr txt)
            => SafeExecution<int>(() => Native.TextLen(txt));

        public static bool TextLt(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextLt(txt1, txt2));

        public static bool TextNe(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextNe(txt1, txt2));

        public static int TextOctetlen(IntPtr txt)
            => SafeExecution<int>(() => Native.TextOctetlen(txt));

        public static IntPtr TextOverlay(IntPtr txt1, IntPtr txt2, int from, int count)
            => SafeExecution<IntPtr>(() => Native.TextOverlay(txt1, txt2, from, count));

        public static IntPtr TextOverlayNoLen(IntPtr txt1, IntPtr txt2, int from)
            => SafeExecution<IntPtr>(() => Native.TextOverlayNoLen(txt1, txt2, from));

        public static bool TextPatternGe(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextPatternGe(txt1, txt2));

        public static bool TextPatternGt(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextPatternGt(txt1, txt2));

        public static bool TextPatternLe(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextPatternLe(txt1, txt2));

        public static bool TextPatternLt(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextPatternLt(txt1, txt2));

        public static int TextPos(IntPtr txt, IntPtr search)
            => SafeExecution<int>(() => Native.TextPos(txt, search));

        public static IntPtr TextReplace(IntPtr txt, IntPtr from, IntPtr to)
            => SafeExecution<IntPtr>(() => Native.TextReplace(txt, from, to));

        public static IntPtr TextReverse(IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TextReverse(txt));

        public static IntPtr TextRight(IntPtr txt, int n)
            => SafeExecution<IntPtr>(() => Native.TextRight(txt, n));

        public static IntPtr TextSmaller(IntPtr txt1, IntPtr txt2)
            => SafeExecution<IntPtr>(() => Native.TextSmaller(txt1, txt2));

        public static IntPtr TextSplitPart(IntPtr txt, IntPtr sep, int fldnum)
            => SafeExecution<IntPtr>(() => Native.TextSplitPart(txt, sep, fldnum));

        public static bool TextStartsWith(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.TextStartsWith(txt1, txt2));

        public static IntPtr TextSubstr(IntPtr txt, int start, int length)
            => SafeExecution<IntPtr>(() => Native.TextSubstr(txt, start, length));

        public static IntPtr TextSubstrNoLen(IntPtr txt, int start)
            => SafeExecution<IntPtr>(() => Native.TextSubstrNoLen(txt, start));

        public static bool UnicodeAssigned(IntPtr txt)
            => SafeExecution<bool>(() => Native.UnicodeAssigned(txt));

        public static bool UnicodeIsNormalized(IntPtr txt, IntPtr fmt)
            => SafeExecution<bool>(() => Native.UnicodeIsNormalized(txt, fmt));

        public static IntPtr UnicodeNormalizeFunc(IntPtr txt, IntPtr fmt)
            => SafeExecution<IntPtr>(() => Native.UnicodeNormalizeFunc(txt, fmt));

        public static IntPtr UnicodeVersion()
            => SafeExecution<IntPtr>(() => Native.UnicodeVersion());

        public static IntPtr Unistr(IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.Unistr(txt));

    }
}
