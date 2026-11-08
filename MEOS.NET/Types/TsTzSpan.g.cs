#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TsTzSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSpan : Span
    {
        internal TsTzSpan(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public bool Adjacent(DateTime t)
            => Meos.AdjacentSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Adjacent(TBox box)
            => Meos.AdjacentTstzspanTbox(this.Ptr, box.Ptr);

        public bool Adjacent(Temporal temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TsTzSpan s2)
            => Meos.AdjacentSpanSpan(this.Ptr, s2.Ptr);

        public bool Adjacent(TsTzSpanSet ss)
            => Meos.AdjacentSpanSpanset(this.Ptr, ss.Ptr);

        public bool Adjacent(TBigInt temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TBool temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TCBuffer temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TFloat temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TGeogPoint temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TGeography temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TGeomPoint temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TGeometry temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TH3Index temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TInt temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TJsonb temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TNPoint temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TPCPatch temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TPCPoint temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TPose temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TPoseChain temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TQuadbin temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TRGeometry temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TS2Cell temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Adjacent(TText temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(DateTime t)
            => Meos.AfterSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool After(TBox box)
            => Meos.AfterTstzspanTbox(this.Ptr, box.Ptr);

        public bool After(Temporal temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TBigInt temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TBool temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TCBuffer temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TFloat temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TGeogPoint temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TGeography temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TGeomPoint temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TGeometry temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TH3Index temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TInt temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TJsonb temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TNPoint temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TPCPatch temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TPCPoint temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TPose temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TPoseChain temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TQuadbin temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TRGeometry temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TS2Cell temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(TText temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public string AsText()
            => this.Out();

        public bool Before(DateTime t)
            => Meos.BeforeSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Before(TBox box)
            => Meos.BeforeTstzspanTbox(this.Ptr, box.Ptr);

        public bool Before(Temporal temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TBigInt temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TBool temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TCBuffer temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TFloat temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TGeogPoint temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TGeography temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TGeomPoint temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TGeometry temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TH3Index temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TInt temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TJsonb temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TNPoint temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TPCPatch temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TPCPoint temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TPose temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TPoseChain temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TQuadbin temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TRGeometry temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TS2Cell temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Before(TText temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public Span?[] Bins(Interval duration, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanArray(Meos.TstzspanBins(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public bool Contained(TBox box)
            => Meos.ContainedTstzspanTbox(this.Ptr, box.Ptr);

        public bool Contained(Temporal temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TsTzSpan s2)
            => Meos.ContainedSpanSpan(this.Ptr, s2.Ptr);

        public bool Contained(TsTzSpanSet ss)
            => Meos.ContainedSpanSpanset(this.Ptr, ss.Ptr);

        public bool Contained(TBigInt temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TBool temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TCBuffer temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TFloat temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TGeogPoint temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TGeography temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TGeomPoint temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TGeometry temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TH3Index temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TInt temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TJsonb temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TNPoint temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TPCPatch temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TPCPoint temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TPose temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TPoseChain temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TQuadbin temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TRGeometry temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TS2Cell temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contained(TText temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(DateTime t)
            => Meos.ContainsSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Contains(TBox box)
            => Meos.ContainsTstzspanTbox(this.Ptr, box.Ptr);

        public bool Contains(Temporal temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TsTzSpan s2)
            => Meos.ContainsSpanSpan(this.Ptr, s2.Ptr);

        public bool Contains(TsTzSpanSet ss)
            => Meos.ContainsSpanSpanset(this.Ptr, ss.Ptr);

        public bool Contains(TBigInt temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TBool temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TCBuffer temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TFloat temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TGeogPoint temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TGeography temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TGeomPoint temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TGeometry temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TH3Index temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TInt temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TJsonb temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TNPoint temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TPCPatch temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TPCPoint temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TPose temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TPoseChain temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TQuadbin temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TRGeometry temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TS2Cell temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(TText temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public Interval? Distance(DateTime t)
            => MEOSConvert.ToStruct<Interval>(Meos.DistanceSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Interval? Distance(TsTzSpan s2)
            => MEOSConvert.ToStruct<Interval>(Meos.DistanceTstzspanTstzspan(this.Ptr, s2.Ptr));

        public Interval? Duration()
            => MEOSConvert.ToStruct<Interval>(Meos.TstzspanDuration(this.Ptr));

        public Span? Expand(Interval interv)
        {
            IntPtr _interv = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(interv, _interv, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanExpand(this.Ptr, _interv));
            }
            finally
            {
                Marshal.FreeHGlobal(_interv);
            }
        }

        public Span? Intersection(DateTime t)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Span? Intersection(TsTzSpan s2)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Intersection(TsTzSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpanSpanset(this.Ptr, ss.Ptr));

        public bool Left(TsTzSpan s2)
            => Meos.LeftSpanSpan(this.Ptr, s2.Ptr);

        public bool Left(TsTzSpanSet ss)
            => Meos.LeftSpanSpanset(this.Ptr, ss.Ptr);

        public DateTime Lower()
            => MEOSConvert.ToDateTime(Meos.TstzspanLower(this.Ptr));

        public SpanSet? Minus(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public SpanSet? Minus(TsTzSpan s2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Minus(TsTzSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpanset(this.Ptr, ss.Ptr));

        public string Out()
            => Meos.TstzspanOut(this.Ptr);

        public bool Overafter(DateTime t)
            => Meos.OverafterSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Overafter(TBox box)
            => Meos.OverafterTstzspanTbox(this.Ptr, box.Ptr);

        public bool Overafter(Temporal temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TBigInt temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TBool temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TCBuffer temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TFloat temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TGeogPoint temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TGeography temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TGeomPoint temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TGeometry temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TH3Index temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TInt temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TJsonb temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TNPoint temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TPCPatch temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TPCPoint temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TPose temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TPoseChain temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TQuadbin temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TRGeometry temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TS2Cell temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overafter(TText temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(DateTime t)
            => Meos.OverbeforeSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Overbefore(TBox box)
            => Meos.OverbeforeTstzspanTbox(this.Ptr, box.Ptr);

        public bool Overbefore(Temporal temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TBigInt temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TBool temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TCBuffer temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TFloat temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TGeogPoint temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TGeography temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TGeomPoint temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TGeometry temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TH3Index temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TInt temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TJsonb temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TNPoint temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TPCPatch temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TPCPoint temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TPose temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TPoseChain temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TQuadbin temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TRGeometry temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TS2Cell temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(TText temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TBox box)
            => Meos.OverlapsTstzspanTbox(this.Ptr, box.Ptr);

        public bool Overlaps(Temporal temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TsTzSpan s2)
            => Meos.OverlapsSpanSpan(this.Ptr, s2.Ptr);

        public bool Overlaps(TsTzSpanSet ss)
            => Meos.OverlapsSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overlaps(TBigInt temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TBool temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TCBuffer temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TFloat temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TGeogPoint temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TGeography temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TGeomPoint temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TGeometry temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TH3Index temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TInt temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TJsonb temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TNPoint temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TPCPatch temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TPCPoint temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TPose temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TPoseChain temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TQuadbin temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TRGeometry temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TS2Cell temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TText temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overleft(TsTzSpan s2)
            => Meos.OverleftSpanSpan(this.Ptr, s2.Ptr);

        public bool Overleft(TsTzSpanSet ss)
            => Meos.OverleftSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overright(TsTzSpan s2)
            => Meos.OverrightSpanSpan(this.Ptr, s2.Ptr);

        public bool Overright(TsTzSpanSet ss)
            => Meos.OverrightSpanSpanset(this.Ptr, ss.Ptr);

        public bool Radjacent(DateTime t)
            => Meos.AdjacentTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rafter(DateTime t)
            => Meos.AfterTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rbefore(DateTime t)
            => Meos.BeforeTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rcontained(DateTime t)
            => Meos.ContainedTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Right(TsTzSpan s2)
            => Meos.RightSpanSpan(this.Ptr, s2.Ptr);

        public bool Right(TsTzSpanSet ss)
            => Meos.RightSpanSpanset(this.Ptr, ss.Ptr);

        public Span? Rintersection(DateTime t)
            => MEOSFactory.WrapSpan(Meos.IntersectionTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public SpanSet? Rminus(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.MinusTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public bool Roverafter(DateTime t)
            => Meos.OverafterTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Roverbefore(DateTime t)
            => Meos.OverbeforeTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public SpanSet? Runion(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.UnionTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public bool Same(TBox box)
            => Meos.SameTstzspanTbox(this.Ptr, box.Ptr);

        public bool Same(Temporal temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TBigInt temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TBool temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TCBuffer temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TFloat temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TGeogPoint temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TGeography temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TGeomPoint temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TGeometry temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TH3Index temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TInt temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TJsonb temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TNPoint temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TPCPatch temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TPCPoint temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TPose temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TPoseChain temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TQuadbin temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TRGeometry temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TS2Cell temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Same(TText temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public Span? Scale(Interval duration)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanScale(this.Ptr, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Span? Shift(Interval shift)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanShift(this.Ptr, _shift));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
            }
        }

        public Span? ShiftScale(Interval shift, Interval duration)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanShiftScale(this.Ptr, _shift, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Span? ToDatespan()
            => MEOSFactory.WrapSpan(Meos.TstzspanToDatespan(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TstzspanToStbox(this.Ptr));

        public Span? Tprecision(Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanTprecision(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public SpanSet? Union(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public SpanSet? Union(TsTzSpan s2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Union(TsTzSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpanset(this.Ptr, ss.Ptr));

        public DateTime Upper()
            => MEOSConvert.ToDateTime(Meos.TstzspanUpper(this.Ptr));

        public static Span? FromText(string str)
            => TsTzSpan.In(str);

        public static Span? FromTimestamptz(DateTime t)
            => MEOSFactory.WrapSpan(Meos.TimestamptzToSpan(MEOSConvert.ToTimestampTz(t)));

        public static Span? GetBin(DateTime t, Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanGetBin(MEOSConvert.ToTimestampTz(t), _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.TstzspanIn(str));

        public static Span? Make(DateTime lower, DateTime upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.TstzspanMake(MEOSConvert.ToTimestampTz(lower), MEOSConvert.ToTimestampTz(upper), lower_inc, upper_inc));

    }
}
