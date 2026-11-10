#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The DateSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class DateSet : Set
    {
        internal DateSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public bool After(DateOnly d)
            => Meos.AfterSetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public bool Before(DateOnly d)
            => Meos.BeforeSetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Contained(DateSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(DateOnly d)
            => Meos.ContainsSetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Contains(DateSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public int Distance(DateSet s2)
            => Meos.DistanceDatesetDateset(this.Ptr, s2.Ptr);

        public int Distance(DateOnly d)
            => Meos.DistanceSetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public DateOnly EndValue()
            => MEOSConvert.ToDateOnly(Meos.DatesetEndValue(this.Ptr));

        public Set? Intersection(DateOnly d)
            => MEOSFactory.WrapSet(Meos.IntersectionSetDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public Set? Intersection(DateSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public bool Left(DateSet s2)
            => Meos.LeftSetSet(this.Ptr, s2.Ptr);

        public Set? Minus(DateOnly d)
            => MEOSFactory.WrapSet(Meos.MinusSetDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public Set? Minus(DateSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public bool Overafter(DateOnly d)
            => Meos.OverafterSetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Overbefore(DateOnly d)
            => Meos.OverbeforeSetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Overlaps(DateSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool Overleft(DateSet s2)
            => Meos.OverleftSetSet(this.Ptr, s2.Ptr);

        public bool Overright(DateSet s2)
            => Meos.OverrightSetSet(this.Ptr, s2.Ptr);

        public bool Rafter(DateOnly d)
            => Meos.AfterDateSet(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rbefore(DateOnly d)
            => Meos.BeforeDateSet(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rcontained(DateOnly d)
            => Meos.ContainedDateSet(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Right(DateSet s2)
            => Meos.RightSetSet(this.Ptr, s2.Ptr);

        public Set? Rintersection(DateOnly d)
            => MEOSFactory.WrapSet(Meos.IntersectionDateSet(MEOSConvert.ToDateADT(d), this.Ptr));

        public Set? Rminus(DateOnly d)
            => MEOSFactory.WrapSet(Meos.MinusDateSet(MEOSConvert.ToDateADT(d), this.Ptr));

        public bool Roverafter(DateOnly d)
            => Meos.OverafterDateSet(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Roverbefore(DateOnly d)
            => Meos.OverbeforeDateSet(MEOSConvert.ToDateADT(d), this.Ptr);

        public Set? Runion(DateOnly d)
            => MEOSFactory.WrapSet(Meos.UnionDateSet(MEOSConvert.ToDateADT(d), this.Ptr));

        public Set? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSet(Meos.DatesetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public DateOnly StartValue()
            => MEOSConvert.ToDateOnly(Meos.DatesetStartValue(this.Ptr));

        public Set? ToTstzset()
            => MEOSFactory.WrapSet(Meos.DatesetToTstzset(this.Ptr));

        public Set? Union(DateOnly d)
            => MEOSFactory.WrapSet(Meos.UnionSetDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public Set? Union(DateSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public DateOnly? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(4);
            try
            {
                if (!Meos.DatesetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSConvert.ToDateOnly(Marshal.ReadInt32(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public int[] Values()
            => Meos.DatesetValues(this.Ptr);

        public static Set? FromDate(DateOnly d)
            => MEOSFactory.WrapSet(Meos.DateToSet(MEOSConvert.ToDateADT(d)));

        public static Set? FromText(string str)
            => DateSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.DatesetIn(str));

        public static Set? Make(int[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.DatesetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
