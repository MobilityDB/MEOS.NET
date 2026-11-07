#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Temporal numbers; supports linear interpolation.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNumber : Temporal
    {
        internal TNumber(IntPtr ptr) : base(ptr) { }

        public Temporal? Abs()
            => MEOSFactory.WrapTemporal(Meos.TnumberAbs(this.Ptr));

        public Temporal? Add(TNumber tnumber2)
            => MEOSFactory.WrapTemporal(Meos.AddTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public bool Adjacent(TBox box)
            => Meos.AdjacentTnumberTbox(this.Ptr, box.Ptr);

        public bool Adjacent(TNumber temp2)
            => Meos.AdjacentTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool After(TBox box)
            => Meos.AfterTnumberTbox(this.Ptr, box.Ptr);

        public bool After(TNumber temp2)
            => Meos.AfterTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? AngularDifference()
            => MEOSFactory.WrapTemporal(Meos.TnumberAngularDifference(this.Ptr));

        public Temporal? AtSpan(Span span)
            => MEOSFactory.WrapTemporal(Meos.TnumberAtSpan(this.Ptr, span.Ptr));

        public Temporal? AtSpanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TnumberAtSpanset(this.Ptr, ss.Ptr));

        public Temporal? AtTbox(TBox box)
            => MEOSFactory.WrapTemporal(Meos.TnumberAtTbox(this.Ptr, box.Ptr));

        public double AvgValue()
            => Meos.TnumberAvgValue(this.Ptr);

        public bool Before(TBox box)
            => Meos.BeforeTnumberTbox(this.Ptr, box.Ptr);

        public bool Before(TNumber temp2)
            => Meos.BeforeTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Contained(TBox box)
            => Meos.ContainedTnumberTbox(this.Ptr, box.Ptr);

        public bool Contained(TNumber temp2)
            => Meos.ContainedTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Contains(TBox box)
            => Meos.ContainsTnumberTbox(this.Ptr, box.Ptr);

        public bool Contains(TNumber temp2)
            => Meos.ContainsTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? DeltaValue()
            => MEOSFactory.WrapTemporal(Meos.TnumberDeltaValue(this.Ptr));

        public Temporal? Div(TNumber tnumber2)
            => MEOSFactory.WrapTemporal(Meos.DivTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public double Integral()
            => Meos.TnumberIntegral(this.Ptr);

        public bool Left(Span s)
            => Meos.LeftTnumberNumspan(this.Ptr, s.Ptr);

        public bool Left(TBox box)
            => Meos.LeftTnumberTbox(this.Ptr, box.Ptr);

        public bool Left(TNumber temp2)
            => Meos.LeftTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? MinusSpan(Span span)
            => MEOSFactory.WrapTemporal(Meos.TnumberMinusSpan(this.Ptr, span.Ptr));

        public Temporal? MinusSpanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TnumberMinusSpanset(this.Ptr, ss.Ptr));

        public Temporal? MinusTbox(TBox box)
            => MEOSFactory.WrapTemporal(Meos.TnumberMinusTbox(this.Ptr, box.Ptr));

        public Temporal? Mul(TNumber tnumber2)
            => MEOSFactory.WrapTemporal(Meos.MulTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public bool Overafter(TBox box)
            => Meos.OverafterTnumberTbox(this.Ptr, box.Ptr);

        public bool Overafter(TNumber temp2)
            => Meos.OverafterTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overbefore(TBox box)
            => Meos.OverbeforeTnumberTbox(this.Ptr, box.Ptr);

        public bool Overbefore(TNumber temp2)
            => Meos.OverbeforeTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overlaps(TBox box)
            => Meos.OverlapsTnumberTbox(this.Ptr, box.Ptr);

        public bool Overlaps(TNumber temp2)
            => Meos.OverlapsTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overleft(Span s)
            => Meos.OverleftTnumberNumspan(this.Ptr, s.Ptr);

        public bool Overleft(TBox box)
            => Meos.OverleftTnumberTbox(this.Ptr, box.Ptr);

        public bool Overleft(TNumber temp2)
            => Meos.OverleftTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overright(Span s)
            => Meos.OverrightTnumberNumspan(this.Ptr, s.Ptr);

        public bool Overright(TBox box)
            => Meos.OverrightTnumberTbox(this.Ptr, box.Ptr);

        public bool Overright(TNumber temp2)
            => Meos.OverrightTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Right(Span s)
            => Meos.RightTnumberNumspan(this.Ptr, s.Ptr);

        public bool Right(TBox box)
            => Meos.RightTnumberTbox(this.Ptr, box.Ptr);

        public bool Right(TNumber temp2)
            => Meos.RightTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Same(TBox box)
            => Meos.SameTnumberTbox(this.Ptr, box.Ptr);

        public bool Same(TNumber temp2)
            => Meos.SameTnumberTnumber(this.Ptr, temp2.Ptr);

        public TBox?[] SplitEachNTboxes(int elem_count)
            => MEOSFactory.WrapTBoxArray(Meos.TnumberSplitEachNTboxes(this.Ptr, elem_count));

        public TBox?[] SplitNTboxes(int box_count)
            => MEOSFactory.WrapTBoxArray(Meos.TnumberSplitNTboxes(this.Ptr, box_count));

        public Temporal? Sub(TNumber tnumber2)
            => MEOSFactory.WrapTemporal(Meos.SubTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public TBox?[] Tboxes()
            => MEOSFactory.WrapTBoxArray(Meos.TnumberTboxes(this.Ptr));

        public Temporal? Tdistance(TNumber temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTnumberTnumber(this.Ptr, temp2.Ptr));

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
