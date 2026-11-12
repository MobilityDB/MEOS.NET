#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>PostgreSQL text, the base type of TText and TextSet.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Text : Value
    {
        internal Text(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => Meos.TextOut(this.Ptr);

        public int AlwaysEq(TText temp)
            => Meos.AlwaysEqTextTtext(this.Ptr, temp.Ptr);

        public int AlwaysGe(TText temp)
            => Meos.AlwaysGeTextTtext(this.Ptr, temp.Ptr);

        public int AlwaysGt(TText temp)
            => Meos.AlwaysGtTextTtext(this.Ptr, temp.Ptr);

        public int AlwaysLe(TText temp)
            => Meos.AlwaysLeTextTtext(this.Ptr, temp.Ptr);

        public int AlwaysLt(TText temp)
            => Meos.AlwaysLtTextTtext(this.Ptr, temp.Ptr);

        public int AlwaysNe(TText temp)
            => Meos.AlwaysNeTextTtext(this.Ptr, temp.Ptr);

        public bool Contained(TextSet s)
            => Meos.ContainedTextSet(this.Ptr, s.Ptr);

        public int EverEq(TText temp)
            => Meos.EverEqTextTtext(this.Ptr, temp.Ptr);

        public int EverGe(TText temp)
            => Meos.EverGeTextTtext(this.Ptr, temp.Ptr);

        public int EverGt(TText temp)
            => Meos.EverGtTextTtext(this.Ptr, temp.Ptr);

        public int EverLe(TText temp)
            => Meos.EverLeTextTtext(this.Ptr, temp.Ptr);

        public int EverLt(TText temp)
            => Meos.EverLtTextTtext(this.Ptr, temp.Ptr);

        public int EverNe(TText temp)
            => Meos.EverNeTextTtext(this.Ptr, temp.Ptr);

        public uint Hash(uint collid)
            => Meos.TextHash(this.Ptr, collid);

        public ulong HashExtended(ulong seed, uint collid)
            => Meos.TextHashExtended(this.Ptr, seed, collid);

        public Text? Initcap()
            => MEOSFactory.WrapText(Meos.TextInitcap(this.Ptr));

        public Set? Intersection(TextSet s)
            => MEOSFactory.WrapSet(Meos.IntersectionTextSet(this.Ptr, s.Ptr));

        public bool Left(TextSet s)
            => Meos.LeftTextSet(this.Ptr, s.Ptr);

        public Text? Lower()
            => MEOSFactory.WrapText(Meos.TextLower(this.Ptr));

        public Set? Minus(TextSet s)
            => MEOSFactory.WrapSet(Meos.MinusTextSet(this.Ptr, s.Ptr));

        public bool Overleft(TextSet s)
            => Meos.OverleftTextSet(this.Ptr, s.Ptr);

        public bool Overright(TextSet s)
            => Meos.OverrightTextSet(this.Ptr, s.Ptr);

        public bool Right(TextSet s)
            => Meos.RightTextSet(this.Ptr, s.Ptr);

        public Temporal? Teq(TText temp)
            => MEOSFactory.WrapTemporal(Meos.TeqTextTtext(this.Ptr, temp.Ptr));

        public Text? Textcat(Text txt2)
            => MEOSFactory.WrapText(Meos.TextcatTextText(this.Ptr, txt2.Ptr));

        public Set? Textcat(TextSet s)
            => MEOSFactory.WrapSet(Meos.TextcatTextTextset(this.Ptr, s.Ptr));

        public Temporal? Textcat(TText temp)
            => MEOSFactory.WrapTemporal(Meos.TextcatTextTtext(this.Ptr, temp.Ptr));

        public Temporal? Tge(TText temp)
            => MEOSFactory.WrapTemporal(Meos.TgeTextTtext(this.Ptr, temp.Ptr));

        public Temporal? Tgt(TText temp)
            => MEOSFactory.WrapTemporal(Meos.TgtTextTtext(this.Ptr, temp.Ptr));

        public Temporal? Tle(TText temp)
            => MEOSFactory.WrapTemporal(Meos.TleTextTtext(this.Ptr, temp.Ptr));

        public Temporal? Tlt(TText temp)
            => MEOSFactory.WrapTemporal(Meos.TltTextTtext(this.Ptr, temp.Ptr));

        public Temporal? Tne(TText temp)
            => MEOSFactory.WrapTemporal(Meos.TneTextTtext(this.Ptr, temp.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.TextToSet(this.Ptr));

        public Set? Union(TextSet s)
            => MEOSFactory.WrapSet(Meos.UnionTextSet(this.Ptr, s.Ptr));

        public Text? Upper()
            => MEOSFactory.WrapText(Meos.TextUpper(this.Ptr));

        public static Text? FromBool(bool b)
            => MEOSFactory.WrapText(Meos.BoolToText(b));

        public static Text? FromCstring(string str)
            => MEOSFactory.WrapText(Meos.CstringToText(str));

    }
}
