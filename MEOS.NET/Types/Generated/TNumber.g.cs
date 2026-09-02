#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Temporal numbers; supports linear interpolation.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNumber : Temporal
    {
        internal TNumber(IntPtr ptr) : base(ptr) { }

        public Temporal? Abs()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_abs(this.Ptr));

        public Temporal? AngularDifference()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_angular_difference(this.Ptr));

        public Temporal? AtSpan(Span span)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_at_span(this.Ptr, span.Ptr));

        public Temporal? AtSpanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_at_spanset(this.Ptr, ss.Ptr));

        public Temporal? AtTbox(TBox box)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_at_tbox(this.Ptr, box.Ptr));

        public Temporal? DeltaValue()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_delta_value(this.Ptr));

        public double Integral()
            => MEOSExposedFunctions.tnumber_integral(this.Ptr);

        public Temporal? MinusSpan(Span span)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_minus_span(this.Ptr, span.Ptr));

        public Temporal? MinusSpanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_minus_spanset(this.Ptr, ss.Ptr));

        public Temporal? MinusTbox(TBox box)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_minus_tbox(this.Ptr, box.Ptr));

        public Span? ToSpan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.tnumber_to_span(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(MEOSExposedFunctions.tnumber_to_tbox(this.Ptr));

        public Temporal? Trend()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnumber_trend(this.Ptr));

        public double Twavg()
            => MEOSExposedFunctions.tnumber_twavg(this.Ptr);

        public SpanSet? Valuespans()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.tnumber_valuespans(this.Ptr));

    }
}
