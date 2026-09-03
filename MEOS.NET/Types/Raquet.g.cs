#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A raster tile. A MeosType no membership predicate admits, as Nsegment is.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Raquet : Value
    {
        internal Raquet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public int Cmp(Raquet rq2)
            => Meos.RaquetCmp(this.Ptr, rq2.Ptr);

        public Raquet? Copy()
            => MEOSFactory.WrapRaquet(Meos.RaquetCopy(this.Ptr));

        public bool Eq(Raquet rq2)
            => Meos.RaquetEq(this.Ptr, rq2.Ptr);

        public bool Ge(Raquet rq2)
            => Meos.RaquetGe(this.Ptr, rq2.Ptr);

        public bool Gt(Raquet rq2)
            => Meos.RaquetGt(this.Ptr, rq2.Ptr);

        public uint Hash()
            => Meos.RaquetHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.RaquetHashExtended(this.Ptr, seed);

        public int Height()
            => Meos.RaquetHeight(this.Ptr);

        public bool Le(Raquet rq2)
            => Meos.RaquetLe(this.Ptr, rq2.Ptr);

        public bool Lt(Raquet rq2)
            => Meos.RaquetLt(this.Ptr, rq2.Ptr);

        public bool Ne(Raquet rq2)
            => Meos.RaquetNe(this.Ptr, rq2.Ptr);

        public double Nodata()
            => Meos.RaquetNodata(this.Ptr);

        public string Out()
            => Meos.RaquetOut(this.Ptr);

        public string Pixtype()
            => Meos.RaquetPixtype(this.Ptr);

        public ulong Quadbin()
            => Meos.RaquetQuadbin(this.Ptr);

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.RaquetToStbox(this.Ptr));

        public int Width()
            => Meos.RaquetWidth(this.Ptr);

        public static Raquet? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapRaquet(Meos.RaquetFromHexwkb(hexwkb));

        public static Raquet? In(string str)
            => MEOSFactory.WrapRaquet(Meos.RaquetIn(str));

        public static Raquet? Read(string path, ulong quadbin)
            => MEOSFactory.WrapRaquet(Meos.RaquetRead(path, quadbin));

    }
}
