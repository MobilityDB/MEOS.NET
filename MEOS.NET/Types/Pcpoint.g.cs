#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The Pcpoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Pcpoint : Value
    {
        internal Pcpoint(IntPtr ptr) : base(ptr) { }

        public string AsHEXWKB()
            => Meos.PcpointAsHexwkb(this.Ptr);

        public int Cmp(Pcpoint pt2)
            => Meos.PcpointCmp(this.Ptr, pt2.Ptr);

        public Pcpoint? Copy()
            => MEOSFactory.WrapPcpoint(Meos.PcpointCopy(this.Ptr));

        public uint GetPcid()
            => Meos.PcpointGetPcid(this.Ptr);

        public uint Hash()
            => Meos.PcpointHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.PcpointHashExtended(this.Ptr, seed);

        public string HexOut(int maxdd)
            => Meos.PcpointHexOut(this.Ptr, maxdd);

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.PcpointToSet(this.Ptr));

        public static Pcpoint? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapPcpoint(Meos.PcpointFromHexwkb(hexwkb));

        public static Pcpoint? HexIn(string str)
            => MEOSFactory.WrapPcpoint(Meos.PcpointHexIn(str));

    }
}
