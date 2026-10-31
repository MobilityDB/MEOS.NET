#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

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

        public bool Eq(Pcpoint pt2)
            => Meos.PcpointEq(this.Ptr, pt2.Ptr);

        public bool Ge(Pcpoint pt2)
            => Meos.PcpointGe(this.Ptr, pt2.Ptr);

        public double? GetDim(string name)
        {
            IntPtr _out = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.PcpointGetDim(this.Ptr, name, _out))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_out);
            }
        }

        public uint GetPcid()
            => Meos.PcpointGetPcid(this.Ptr);

        public double? GetX()
        {
            IntPtr _out = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.PcpointGetX(this.Ptr, _out))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_out);
            }
        }

        public double? GetY()
        {
            IntPtr _out = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.PcpointGetY(this.Ptr, _out))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_out);
            }
        }

        public double? GetZ()
        {
            IntPtr _out = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.PcpointGetZ(this.Ptr, _out))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_out);
            }
        }

        public bool Gt(Pcpoint pt2)
            => Meos.PcpointGt(this.Ptr, pt2.Ptr);

        public uint Hash()
            => Meos.PcpointHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.PcpointHashExtended(this.Ptr, seed);

        public string HexOut(int maxdd)
            => Meos.PcpointHexOut(this.Ptr, maxdd);

        public bool Le(Pcpoint pt2)
            => Meos.PcpointLe(this.Ptr, pt2.Ptr);

        public bool Lt(Pcpoint pt2)
            => Meos.PcpointLt(this.Ptr, pt2.Ptr);

        public int MemSize()
            => Meos.PcpointMemSize(this.Ptr);

        public bool Ne(Pcpoint pt2)
            => Meos.PcpointNe(this.Ptr, pt2.Ptr);

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.PcpointToSet(this.Ptr));

        public TPCBox? ToTpcbox()
            => MEOSFactory.WrapTPCBox(Meos.PcpointToTpcbox(this.Ptr));

        public static Pcpoint? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapPcpoint(Meos.PcpointFromHexwkb(hexwkb));

        public static Pcpoint? HexIn(string str)
            => MEOSFactory.WrapPcpoint(Meos.PcpointHexIn(str));

        public static Pcpoint? Make(uint pcid, double[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapPcpoint(Meos.PcpointMake(pcid, _values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
