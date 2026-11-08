#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The PCPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PCPoint : Value
    {
        internal PCPoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.HexOut(15);

        public int AlwaysEq(TPCPoint temp)
            => Meos.AlwaysEqPcpointTpcpoint(this.Ptr, temp.Ptr);

        public int AlwaysNe(TPCPoint temp)
            => Meos.AlwaysNePcpointTpcpoint(this.Ptr, temp.Ptr);

        public string AsHexWKB()
            => Meos.PcpointAsHexwkb(this.Ptr);

        public string AsText(int maxdd)
            => this.HexOut(maxdd);

        public int Cmp(PCPoint pt2)
            => Meos.PcpointCmp(this.Ptr, pt2.Ptr);

        public bool Contained(PCPointSet s)
            => Meos.ContainedPcpointSet(this.Ptr, s.Ptr);

        public PCPoint? Copy()
            => MEOSFactory.WrapPCPoint(Meos.PcpointCopy(this.Ptr));

        public bool Eq(PCPoint pt2)
            => Meos.PcpointEq(this.Ptr, pt2.Ptr);

        public int EverEq(TPCPoint temp)
            => Meos.EverEqPcpointTpcpoint(this.Ptr, temp.Ptr);

        public int EverNe(TPCPoint temp)
            => Meos.EverNePcpointTpcpoint(this.Ptr, temp.Ptr);

        public bool Ge(PCPoint pt2)
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

        public bool Gt(PCPoint pt2)
            => Meos.PcpointGt(this.Ptr, pt2.Ptr);

        public uint Hash()
            => Meos.PcpointHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.PcpointHashExtended(this.Ptr, seed);

        public string HexOut(int maxdd)
            => Meos.PcpointHexOut(this.Ptr, maxdd);

        public Set? Intersection(PCPointSet s)
            => MEOSFactory.WrapSet(Meos.IntersectionPcpointSet(this.Ptr, s.Ptr));

        public bool Le(PCPoint pt2)
            => Meos.PcpointLe(this.Ptr, pt2.Ptr);

        public bool Lt(PCPoint pt2)
            => Meos.PcpointLt(this.Ptr, pt2.Ptr);

        public int MemSize()
            => Meos.PcpointMemSize(this.Ptr);

        public Set? Minus(PCPointSet s)
            => MEOSFactory.WrapSet(Meos.MinusPcpointSet(this.Ptr, s.Ptr));

        public bool Ne(PCPoint pt2)
            => Meos.PcpointNe(this.Ptr, pt2.Ptr);

        public Temporal? Teq(TPCPoint temp)
            => MEOSFactory.WrapTemporal(Meos.TeqPcpointTpcpoint(this.Ptr, temp.Ptr));

        public Temporal? Tne(TPCPoint temp)
            => MEOSFactory.WrapTemporal(Meos.TnePcpointTpcpoint(this.Ptr, temp.Ptr));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.PcpointToSet(this.Ptr));

        public TPCBox? ToTpcbox()
            => MEOSFactory.WrapTPCBox(Meos.PcpointToTpcbox(this.Ptr));

        public Set? Union(PCPointSet s)
            => MEOSFactory.WrapSet(Meos.UnionPcpointSet(this.Ptr, s.Ptr));

        public static PCPoint? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapPCPoint(Meos.PcpointFromHexwkb(hexwkb));

        public static PCPoint? FromText(string str)
            => PCPoint.HexIn(str);

        public static PCPoint? HexIn(string str)
            => MEOSFactory.WrapPCPoint(Meos.PcpointHexIn(str));

        public static PCPoint? Make(uint pcid, double[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapPCPoint(Meos.PcpointMake(pcid, _values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
