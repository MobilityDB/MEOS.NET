#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TPCPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPCPoint : TSpatial
    {
        internal TPCPoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int AlwaysEq(PCPoint pt)
            => Meos.AlwaysEqTpcpointPcpoint(this.Ptr, pt.Ptr);

        public int AlwaysEq(TPCPoint temp2)
            => Meos.AlwaysEqTpcpointTpcpoint(this.Ptr, temp2.Ptr);

        public int AlwaysNe(PCPoint pt)
            => Meos.AlwaysNeTpcpointPcpoint(this.Ptr, pt.Ptr);

        public int AlwaysNe(TPCPoint temp2)
            => Meos.AlwaysNeTpcpointTpcpoint(this.Ptr, temp2.Ptr);

        public Temporal? AtTpcbox(TPCBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TpcpointAtTpcbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? AtValue(PCPoint pt)
            => MEOSFactory.WrapTemporal(Meos.TpcpointAtValue(this.Ptr, pt.Ptr));

        public bool Eintersects(Geo gs)
            => Meos.EintersectsTpcpointGeo(this.Ptr, gs.Ptr);

        public PCPoint? EndValue()
            => MEOSFactory.WrapPCPoint(Meos.TpcpointEndValue(this.Ptr));

        public int EverEq(PCPoint pt)
            => Meos.EverEqTpcpointPcpoint(this.Ptr, pt.Ptr);

        public int EverEq(TPCPoint temp2)
            => Meos.EverEqTpcpointTpcpoint(this.Ptr, temp2.Ptr);

        public int EverNe(PCPoint pt)
            => Meos.EverNeTpcpointPcpoint(this.Ptr, pt.Ptr);

        public int EverNe(TPCPoint temp2)
            => Meos.EverNeTpcpointTpcpoint(this.Ptr, temp2.Ptr);

        public Temporal? MinusTpcbox(TPCBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TpcpointMinusTpcbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? MinusValue(PCPoint pt)
            => MEOSFactory.WrapTemporal(Meos.TpcpointMinusValue(this.Ptr, pt.Ptr));

        public double Nad(Geo gs)
            => Meos.NadTpcpointGeo(this.Ptr, gs.Ptr);

        public uint Pcid()
            => Meos.TpcpointPcid(this.Ptr);

        public PCPoint? StartValue()
            => MEOSFactory.WrapPCPoint(Meos.TpcpointStartValue(this.Ptr));

        public Temporal? Teq(PCPoint pt)
            => MEOSFactory.WrapTemporal(Meos.TeqTpcpointPcpoint(this.Ptr, pt.Ptr));

        public Temporal? Teq(TPCPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(PCPoint pt)
            => MEOSFactory.WrapTemporal(Meos.TneTpcpointPcpoint(this.Ptr, pt.Ptr));

        public Temporal? Tne(TPCPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TpcpointToTgeogpoint(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TpcpointToTgeompoint(this.Ptr));

        public (SpanSet?[], PCPoint?[]) Unnest()
        {
            var _answered = Meos.TpcpointUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapPCPointArray(_answered.Item2));
        }

        public PCPoint? Value()
            => MEOSFactory.WrapPCPoint(Meos.TpcpointValue(this.Ptr));

        public PCPoint? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcpointValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapPCPoint(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public PCPoint? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcpointValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPCPoint(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public PCPoint?[] Values()
            => MEOSFactory.WrapPCPointArray(Meos.TpcpointValues(this.Ptr));

        public static Temporal? FromBaseTemp(PCPoint pt, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TpcpointFromBaseTemp(pt.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TPCPoint.FromText(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TpcpointFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => MEOSFactory.WrapTemporal(Meos.TpcpointIn(str));

    }
}
