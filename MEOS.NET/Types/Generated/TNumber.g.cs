#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Temporal numbers; supports linear interpolation.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNumber : Temporal
    {
        internal TNumber(IntPtr ptr) : base(ptr) { }

        public Temporal? Abs()
            => MEOSFactory.WrapTemporal(Meos.TnumberAbs(this.Ptr));

        public Temporal? AngularDifference()
            => MEOSFactory.WrapTemporal(Meos.TnumberAngularDifference(this.Ptr));

        public Temporal? AtSpan(Span span)
            => MEOSFactory.WrapTemporal(Meos.TnumberAtSpan(this.Ptr, span.Ptr));

        public Temporal? AtSpanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TnumberAtSpanset(this.Ptr, ss.Ptr));

        public Temporal? AtTbox(TBox box)
            => MEOSFactory.WrapTemporal(Meos.TnumberAtTbox(this.Ptr, box.Ptr));

        public Temporal? DeltaValue()
            => MEOSFactory.WrapTemporal(Meos.TnumberDeltaValue(this.Ptr));

        public double Integral()
            => Meos.TnumberIntegral(this.Ptr);

        public Temporal? MinusSpan(Span span)
            => MEOSFactory.WrapTemporal(Meos.TnumberMinusSpan(this.Ptr, span.Ptr));

        public Temporal? MinusSpanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TnumberMinusSpanset(this.Ptr, ss.Ptr));

        public Temporal? MinusTbox(TBox box)
            => MEOSFactory.WrapTemporal(Meos.TnumberMinusTbox(this.Ptr, box.Ptr));

        public Span? ToSpan()
            => MEOSFactory.WrapSpan(Meos.TnumberToSpan(this.Ptr));

        public TBox? ToTbox()
            => MEOSFactory.WrapTBox(Meos.TnumberToTbox(this.Ptr));

        public Temporal? Trend()
            => MEOSFactory.WrapTemporal(Meos.TnumberTrend(this.Ptr));

        public double Twavg()
            => Meos.TnumberTwavg(this.Ptr);

        public SpanSet? Valuespans()
            => MEOSFactory.WrapSpanSet(Meos.TnumberValuespans(this.Ptr));

    }
}
