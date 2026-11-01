#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TPcpatch class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPcpatch : TSpatial
    {
        internal TPcpatch(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Temporal? AtValue(Pcpatch pa)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchAtValue(this.Ptr, pa.Ptr));

        public uint EndNpoints()
            => Meos.TpcpatchEndNpoints(this.Ptr);

        public Pcpatch? EndValue()
            => MEOSFactory.WrapPcpatch(Meos.TpcpatchEndValue(this.Ptr));

        public Temporal? MinusValue(Pcpatch pa)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchMinusValue(this.Ptr, pa.Ptr));

        public long Npoints()
            => Meos.TpcpatchNpoints(this.Ptr);

        public string Out()
            => Meos.TpcpatchOut(this.Ptr);

        public uint Pcid()
            => Meos.TpcpatchPcid(this.Ptr);

        public uint StartNpoints()
            => Meos.TpcpatchStartNpoints(this.Ptr);

        public Pcpatch? StartValue()
            => MEOSFactory.WrapPcpatch(Meos.TpcpatchStartValue(this.Ptr));

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

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TpcpatchToTgeometry(this.Ptr));

        public (SpanSet?[], Pcpatch?[]) Unnest()
        {
            var _answered = Meos.TpcpatchUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapPcpatchArray(_answered.Item2));
        }

        public Pcpatch? Value()
            => MEOSFactory.WrapPcpatch(Meos.TpcpatchValue(this.Ptr));

        public Pcpatch? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcpatchValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapPcpatch(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Pcpatch? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcpatchValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPcpatch(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Pcpatch?[] Values()
            => MEOSFactory.WrapPcpatchArray(Meos.TpcpatchValues(this.Ptr));

        public static Temporal? FromBaseTemp(Pcpatch pa, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchFromBaseTemp(pa.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TPcpatch.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TPcpatch.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TpcpatchIn(str));

    }
}
