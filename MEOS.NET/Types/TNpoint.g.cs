#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TNpoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNpoint : TSpatial
    {
        internal TNpoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtGeom(this.Ptr, gs.Ptr));

        public Temporal? AtNpoint(Npoint np)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtNpoint(this.Ptr, np.Ptr));

        public Temporal? AtNpointset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtNpointset(this.Ptr, s.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TnpointAtStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? CumulativeLength()
            => MEOSFactory.WrapTemporal(Meos.TnpointCumulativeLength(this.Ptr));

        public Npoint? EndValue()
            => MEOSFactory.WrapNpoint(Meos.TnpointEndValue(this.Ptr));

        public double Length()
            => Meos.TnpointLength(this.Ptr);

        public Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusGeom(this.Ptr, gs.Ptr));

        public Temporal? MinusNpoint(Npoint np)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusNpoint(this.Ptr, np.Ptr));

        public Temporal? MinusNpointset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusNpointset(this.Ptr, s.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TnpointMinusStbox(this.Ptr, box.Ptr, border_inc));

        public new string Out(int maxdd)
            => Meos.TnpointOut(this.Ptr, maxdd);

        public Nsegment?[] Positions()
            => MEOSFactory.WrapNsegmentArray(Meos.TnpointPositions(this.Ptr));

        public long Route()
            => Meos.TnpointRoute(this.Ptr);

        public Set? Routes()
            => MEOSFactory.WrapSet(Meos.TnpointRoutes(this.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TnpointSpeed(this.Ptr));

        public Npoint? StartValue()
            => MEOSFactory.WrapNpoint(Meos.TnpointStartValue(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TnpointToTgeompoint(this.Ptr));

        public Geo? Trajectory()
            => MEOSFactory.WrapGeo(Meos.TnpointTrajectory(this.Ptr));

        public Geo? Twcentroid()
            => MEOSFactory.WrapGeo(Meos.TnpointTwcentroid(this.Ptr));

        public Npoint? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TnpointValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return MEOSFactory.WrapNpoint(Marshal.ReadIntPtr(_value));
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Npoint? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TnpointValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapNpoint(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Npoint?[] Values()
            => MEOSFactory.WrapNpointArray(Meos.TnpointValues(this.Ptr));

        public static Temporal? FromBaseTemp(Npoint np, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TnpointFromBaseTemp(np.Ptr, temp.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TnpointFromMfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TnpointIn(str));

    }
}
