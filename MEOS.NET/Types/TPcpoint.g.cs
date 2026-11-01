#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TPcpoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPcpoint : TSpatial
    {
        internal TPcpoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Temporal? AtValue(Pcpoint pt)
            => MEOSFactory.WrapTemporal(Meos.TpcpointAtValue(this.Ptr, pt.Ptr));

        public Pcpoint? EndValue()
            => MEOSFactory.WrapPcpoint(Meos.TpcpointEndValue(this.Ptr));

        public Temporal? MinusValue(Pcpoint pt)
            => MEOSFactory.WrapTemporal(Meos.TpcpointMinusValue(this.Ptr, pt.Ptr));

        public string Out()
            => Meos.TpcpointOut(this.Ptr);

        public uint Pcid()
            => Meos.TpcpointPcid(this.Ptr);

        public Pcpoint? StartValue()
            => MEOSFactory.WrapPcpoint(Meos.TpcpointStartValue(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TpcpointToTgeompoint(this.Ptr));

        public (SpanSet?[], Pcpoint?[]) Unnest()
        {
            var _answered = Meos.TpcpointUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapPcpointArray(_answered.Item2));
        }

        public Pcpoint? Value()
            => MEOSFactory.WrapPcpoint(Meos.TpcpointValue(this.Ptr));

        public Pcpoint? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcpointValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapPcpoint(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Pcpoint? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpcpointValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPcpoint(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Pcpoint?[] Values()
            => MEOSFactory.WrapPcpointArray(Meos.TpcpointValues(this.Ptr));

        public static Temporal? FromBaseTemp(Pcpoint pt, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TpcpointFromBaseTemp(pt.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TPcpoint.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TpcpointFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TPcpoint.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TpcpointIn(str));

    }
}
