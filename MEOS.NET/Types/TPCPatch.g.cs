#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TPCPatch class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPCPatch : TSpatial
    {
        internal TPCPatch(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public int AlwaysEq(PCPatch pa)
            => Meos.AlwaysEqTpcpatchPcpatch(this.Ptr, pa.Ptr);

        public int AlwaysEq(TPCPatch temp2)
            => Meos.AlwaysEqTpcpatchTpcpatch(this.Ptr, temp2.Ptr);

        public int AlwaysNe(PCPatch pa)
            => Meos.AlwaysNeTpcpatchPcpatch(this.Ptr, pa.Ptr);

        public int AlwaysNe(TPCPatch temp2)
            => Meos.AlwaysNeTpcpatchTpcpatch(this.Ptr, temp2.Ptr);

        public Temporal? AtValue(PCPatch pa)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchAtValue(this.Ptr, pa.Ptr));

        public uint EndNpoints()
            => Meos.TpcpatchEndNpoints(this.Ptr);

        public PCPatch? EndValue()
            => MEOSFactory.WrapPCPatch(Meos.TpcpatchEndValue(this.Ptr));

        public int EverEq(PCPatch pa)
            => Meos.EverEqTpcpatchPcpatch(this.Ptr, pa.Ptr);

        public int EverEq(TPCPatch temp2)
            => Meos.EverEqTpcpatchTpcpatch(this.Ptr, temp2.Ptr);

        public int EverNe(PCPatch pa)
            => Meos.EverNeTpcpatchPcpatch(this.Ptr, pa.Ptr);

        public int EverNe(TPCPatch temp2)
            => Meos.EverNeTpcpatchTpcpatch(this.Ptr, temp2.Ptr);

        public Temporal? MinusValue(PCPatch pa)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchMinusValue(this.Ptr, pa.Ptr));

        public long Npoints()
            => Meos.TpcpatchNpoints(this.Ptr);

        public string Out()
            => Meos.TpcpatchOut(this.Ptr);

        public uint Pcid()
            => Meos.TpcpatchPcid(this.Ptr);

        public uint StartNpoints()
            => Meos.TpcpatchStartNpoints(this.Ptr);

        public PCPatch? StartValue()
            => MEOSFactory.WrapPCPatch(Meos.TpcpatchStartValue(this.Ptr));

        public Geo? Swath(Interval maxt)
        {
            IntPtr _maxt = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(maxt, _maxt, false);
                return MEOSFactory.WrapGeo(Meos.TpcpatchSwath(this.Ptr, _maxt));
            }
            finally
            {
                Marshal.FreeHGlobal(_maxt);
            }
        }

        public Temporal? Teq(PCPatch pa)
            => MEOSFactory.WrapTemporal(Meos.TeqTpcpatchPcpatch(this.Ptr, pa.Ptr));

        public Temporal? Teq(TPCPatch temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(PCPatch pa)
            => MEOSFactory.WrapTemporal(Meos.TneTpcpatchPcpatch(this.Ptr, pa.Ptr));

        public Temporal? Tne(TPCPatch temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(Meos.TpcpatchToTgeography(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TpcpatchToTgeometry(this.Ptr));

        public (SpanSet?[], PCPatch?[]) Unnest()
        {
            var _answered = Meos.TpcpatchUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapPCPatchArray(_answered.Item2));
        }

        public PCPatch? Value()
            => MEOSFactory.WrapPCPatch(Meos.TpcpatchValue(this.Ptr));

        public PCPatch? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcpatchValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapPCPatch(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public PCPatch? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcpatchValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPCPatch(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public PCPatch?[] Values()
            => MEOSFactory.WrapPCPatchArray(Meos.TpcpatchValues(this.Ptr));

        public static Temporal? FromBaseTemp(PCPatch pa, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchFromBaseTemp(pa.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TPCPatch.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TPCPatch.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchIn(str));

    }
}
