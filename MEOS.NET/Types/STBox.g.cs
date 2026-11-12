#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Space x time box (bbox of TSpatial).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class STBox : Box
    {
        internal STBox(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Above(STBox box2)
            => Meos.AboveStboxStbox(this.Ptr, box2.Ptr);

        public bool Above(TSpatial temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TCBuffer temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TGeomPoint temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TGeometry temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TH3Index temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TNPoint temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TPose temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TPoseChain temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TQuadbin temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TRGeometry temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Above(TS2Cell temp)
            => Meos.AboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(STBox box2)
            => Meos.AdjacentStboxStbox(this.Ptr, box2.Ptr);

        public bool Adjacent(TSpatial temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TCBuffer temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TGeogPoint temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TGeography temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TGeomPoint temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TGeometry temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TH3Index temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TNPoint temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TPose temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TPoseChain temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TQuadbin temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TRGeometry temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool Adjacent(TS2Cell temp)
            => Meos.AdjacentStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(STBox box2)
            => Meos.AfterStboxStbox(this.Ptr, box2.Ptr);

        public bool After(TSpatial temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TCBuffer temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TGeogPoint temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TGeography temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TGeomPoint temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TGeometry temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TH3Index temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TNPoint temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TPose temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TPoseChain temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TQuadbin temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TRGeometry temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public bool After(TS2Cell temp)
            => Meos.AfterStboxTspatial(this.Ptr, temp.Ptr);

        public int AlwaysOverlaps(TGeo temp)
            => Meos.AlwaysOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public int AlwaysOverlaps(TCBuffer temp)
            => Meos.AlwaysOverlapsStboxTcbuffer(this.Ptr, temp.Ptr);

        public int AlwaysOverlaps(TNPoint temp)
            => Meos.AlwaysOverlapsStboxTnpoint(this.Ptr, temp.Ptr);

        public int AlwaysOverlaps(TPose temp)
            => Meos.AlwaysOverlapsStboxTpose(this.Ptr, temp.Ptr);

        public int AlwaysOverlaps(TRGeometry temp)
            => Meos.AlwaysOverlapsStboxTrgeometry(this.Ptr, temp.Ptr);

        public int AlwaysOverlaps(TGeogPoint temp)
            => Meos.AlwaysOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public int AlwaysOverlaps(TGeography temp)
            => Meos.AlwaysOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public int AlwaysOverlaps(TGeomPoint temp)
            => Meos.AlwaysOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public int AlwaysOverlaps(TGeometry temp)
            => Meos.AlwaysOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public double Area(bool spheroid)
            => Meos.StboxArea(this.Ptr, spheroid);

        public byte[]? AsEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.StboxAsEwkb(this.Ptr, variant, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public string AsEWKT(int maxdd)
            => this.Out(maxdd);

        public string AsHexEWKB(byte variant)
            => Meos.StboxAsHexewkb(this.Ptr, variant);

        public string AsHexWKB(byte variant)
            => Meos.StboxAsHexwkb(this.Ptr, variant);

        public string AsText(int maxdd)
            => Meos.StboxAsText(this.Ptr, maxdd);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.StboxAsWkb(this.Ptr, variant, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public bool Back(STBox box2)
            => Meos.BackStboxStbox(this.Ptr, box2.Ptr);

        public bool Back(TSpatial temp)
            => Meos.BackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Back(TGeomPoint temp)
            => Meos.BackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Back(TGeometry temp)
            => Meos.BackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Back(TPose temp)
            => Meos.BackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Back(TPoseChain temp)
            => Meos.BackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Back(TRGeometry temp)
            => Meos.BackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(STBox box2)
            => Meos.BeforeStboxStbox(this.Ptr, box2.Ptr);

        public bool Before(TSpatial temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TCBuffer temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TGeogPoint temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TGeography temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TGeomPoint temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TGeometry temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TH3Index temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TNPoint temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TPose temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TPoseChain temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TQuadbin temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TRGeometry temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Before(TS2Cell temp)
            => Meos.BeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(STBox box2)
            => Meos.BelowStboxStbox(this.Ptr, box2.Ptr);

        public bool Below(TSpatial temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TCBuffer temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TGeomPoint temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TGeometry temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TH3Index temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TNPoint temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TPose temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TPoseChain temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TQuadbin temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TRGeometry temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Below(TS2Cell temp)
            => Meos.BelowStboxTspatial(this.Ptr, temp.Ptr);

        public int Cmp(STBox box2)
            => Meos.StboxCmp(this.Ptr, box2.Ptr);

        public bool Contained(STBox box2)
            => Meos.ContainedStboxStbox(this.Ptr, box2.Ptr);

        public bool Contained(TSpatial temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TCBuffer temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TGeogPoint temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TGeography temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TGeomPoint temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TGeometry temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TH3Index temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TNPoint temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TPose temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TPoseChain temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TQuadbin temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TRGeometry temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contained(TS2Cell temp)
            => Meos.ContainedStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(STBox box2)
            => Meos.ContainsStboxStbox(this.Ptr, box2.Ptr);

        public bool Contains(TSpatial temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TCBuffer temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TGeogPoint temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TGeography temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TGeomPoint temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TGeometry temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TH3Index temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TNPoint temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TPose temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TPoseChain temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TQuadbin temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TRGeometry temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Contains(TS2Cell temp)
            => Meos.ContainsStboxTspatial(this.Ptr, temp.Ptr);

        public STBox? Copy()
            => MEOSFactory.WrapSTBox(Meos.StboxCopy(this.Ptr));

        public bool Eq(STBox box2)
            => Meos.StboxEq(this.Ptr, box2.Ptr);

        public int EverOverlaps(TGeo temp)
            => Meos.EverOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public int EverOverlaps(TCBuffer temp)
            => Meos.EverOverlapsStboxTcbuffer(this.Ptr, temp.Ptr);

        public int EverOverlaps(TNPoint temp)
            => Meos.EverOverlapsStboxTnpoint(this.Ptr, temp.Ptr);

        public int EverOverlaps(TPose temp)
            => Meos.EverOverlapsStboxTpose(this.Ptr, temp.Ptr);

        public int EverOverlaps(TRGeometry temp)
            => Meos.EverOverlapsStboxTrgeometry(this.Ptr, temp.Ptr);

        public int EverOverlaps(TGeogPoint temp)
            => Meos.EverOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public int EverOverlaps(TGeography temp)
            => Meos.EverOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public int EverOverlaps(TGeomPoint temp)
            => Meos.EverOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public int EverOverlaps(TGeometry temp)
            => Meos.EverOverlapsStboxTgeo(this.Ptr, temp.Ptr);

        public STBox? ExpandSpace(double d)
            => MEOSFactory.WrapSTBox(Meos.StboxExpandSpace(this.Ptr, d));

        public STBox? ExpandTime(Interval interv)
        {
            IntPtr _interv = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(interv, _interv, false);
                return MEOSFactory.WrapSTBox(Meos.StboxExpandTime(this.Ptr, _interv));
            }
            finally
            {
                Marshal.FreeHGlobal(_interv);
            }
        }

        public bool Front(STBox box2)
            => Meos.FrontStboxStbox(this.Ptr, box2.Ptr);

        public bool Front(TSpatial temp)
            => Meos.FrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Front(TGeomPoint temp)
            => Meos.FrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Front(TGeometry temp)
            => Meos.FrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Front(TPose temp)
            => Meos.FrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Front(TPoseChain temp)
            => Meos.FrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Front(TRGeometry temp)
            => Meos.FrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Ge(STBox box2)
            => Meos.StboxGe(this.Ptr, box2.Ptr);

        public STBox? GetSpace()
            => MEOSFactory.WrapSTBox(Meos.StboxGetSpace(this.Ptr));

        public bool Gt(STBox box2)
            => Meos.StboxGt(this.Ptr, box2.Ptr);

        public uint Hash()
            => Meos.StboxHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.StboxHashExtended(this.Ptr, seed);

        public bool Hast()
            => Meos.StboxHast(this.Ptr);

        public bool Hasx()
            => Meos.StboxHasx(this.Ptr);

        public bool Hasz()
            => Meos.StboxHasz(this.Ptr);

        public STBox? Intersection(STBox box2)
            => MEOSFactory.WrapSTBox(Meos.IntersectionStboxStbox(this.Ptr, box2.Ptr));

        public bool Isgeodetic()
            => Meos.StboxIsgeodetic(this.Ptr);

        public bool Le(STBox box2)
            => Meos.StboxLe(this.Ptr, box2.Ptr);

        public bool Left(STBox box2)
            => Meos.LeftStboxStbox(this.Ptr, box2.Ptr);

        public bool Left(TSpatial temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TCBuffer temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TGeomPoint temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TGeometry temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TH3Index temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TNPoint temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TPose temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TPoseChain temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TQuadbin temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TRGeometry temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Left(TS2Cell temp)
            => Meos.LeftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Lt(STBox box2)
            => Meos.StboxLt(this.Ptr, box2.Ptr);

        public double Nad(Geo gs, bool spheroid)
            => Meos.NadStboxGeo(this.Ptr, gs.Ptr, spheroid);

        public double Nad(STBox box2, bool spheroid)
            => Meos.NadStboxStbox(this.Ptr, box2.Ptr, spheroid);

        public double Nad(TRGeometry temp)
            => Meos.NadStboxTrgeometry(this.Ptr, temp.Ptr);

        public double Nad(Geography gs, bool spheroid)
            => Meos.NadStboxGeo(this.Ptr, gs.Ptr, spheroid);

        public double Nad(Geometry gs, bool spheroid)
            => Meos.NadStboxGeo(this.Ptr, gs.Ptr, spheroid);

        public bool Ne(STBox box2)
            => Meos.StboxNe(this.Ptr, box2.Ptr);

        public string Out(int maxdd)
            => Meos.StboxOut(this.Ptr, maxdd);

        public bool Overabove(STBox box2)
            => Meos.OveraboveStboxStbox(this.Ptr, box2.Ptr);

        public bool Overabove(TSpatial temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TCBuffer temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TGeomPoint temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TGeometry temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TH3Index temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TNPoint temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TPose temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TPoseChain temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TQuadbin temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TRGeometry temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overabove(TS2Cell temp)
            => Meos.OveraboveStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(STBox box2)
            => Meos.OverafterStboxStbox(this.Ptr, box2.Ptr);

        public bool Overafter(TSpatial temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TCBuffer temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TGeogPoint temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TGeography temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TGeomPoint temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TGeometry temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TH3Index temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TNPoint temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TPose temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TPoseChain temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TQuadbin temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TRGeometry temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overafter(TS2Cell temp)
            => Meos.OverafterStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overback(STBox box2)
            => Meos.OverbackStboxStbox(this.Ptr, box2.Ptr);

        public bool Overback(TSpatial temp)
            => Meos.OverbackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overback(TGeomPoint temp)
            => Meos.OverbackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overback(TGeometry temp)
            => Meos.OverbackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overback(TPose temp)
            => Meos.OverbackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overback(TPoseChain temp)
            => Meos.OverbackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overback(TRGeometry temp)
            => Meos.OverbackStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(STBox box2)
            => Meos.OverbeforeStboxStbox(this.Ptr, box2.Ptr);

        public bool Overbefore(TSpatial temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TCBuffer temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TGeogPoint temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TGeography temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TGeomPoint temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TGeometry temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TH3Index temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TNPoint temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TPose temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TPoseChain temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TQuadbin temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TRGeometry temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbefore(TS2Cell temp)
            => Meos.OverbeforeStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(STBox box2)
            => Meos.OverbelowStboxStbox(this.Ptr, box2.Ptr);

        public bool Overbelow(TSpatial temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TCBuffer temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TGeomPoint temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TGeometry temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TH3Index temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TNPoint temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TPose temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TPoseChain temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TQuadbin temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TRGeometry temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overbelow(TS2Cell temp)
            => Meos.OverbelowStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overfront(STBox box2)
            => Meos.OverfrontStboxStbox(this.Ptr, box2.Ptr);

        public bool Overfront(TSpatial temp)
            => Meos.OverfrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overfront(TGeomPoint temp)
            => Meos.OverfrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overfront(TGeometry temp)
            => Meos.OverfrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overfront(TPose temp)
            => Meos.OverfrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overfront(TPoseChain temp)
            => Meos.OverfrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overfront(TRGeometry temp)
            => Meos.OverfrontStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(STBox box2)
            => Meos.OverlapsStboxStbox(this.Ptr, box2.Ptr);

        public bool Overlaps(TSpatial temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TCBuffer temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TGeogPoint temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TGeography temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TGeomPoint temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TGeometry temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TH3Index temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TNPoint temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TPose temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TPoseChain temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TQuadbin temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TRGeometry temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overlaps(TS2Cell temp)
            => Meos.OverlapsStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(STBox box2)
            => Meos.OverleftStboxStbox(this.Ptr, box2.Ptr);

        public bool Overleft(TSpatial temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TCBuffer temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TGeomPoint temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TGeometry temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TH3Index temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TNPoint temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TPose temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TPoseChain temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TQuadbin temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TRGeometry temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overleft(TS2Cell temp)
            => Meos.OverleftStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(STBox box2)
            => Meos.OverrightStboxStbox(this.Ptr, box2.Ptr);

        public bool Overright(TSpatial temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TCBuffer temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TGeomPoint temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TGeometry temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TH3Index temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TNPoint temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TPose temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TPoseChain temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TQuadbin temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TRGeometry temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Overright(TS2Cell temp)
            => Meos.OverrightStboxTspatial(this.Ptr, temp.Ptr);

        public double Perimeter(bool spheroid)
            => Meos.StboxPerimeter(this.Ptr, spheroid);

        public STBox?[] QuadSplit()
            => MEOSFactory.WrapSTBoxArray(Meos.StboxQuadSplit(this.Ptr));

        public bool Right(STBox box2)
            => Meos.RightStboxStbox(this.Ptr, box2.Ptr);

        public bool Right(TSpatial temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TCBuffer temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TGeomPoint temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TGeometry temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TH3Index temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TNPoint temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TPose temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TPoseChain temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TQuadbin temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TRGeometry temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public bool Right(TS2Cell temp)
            => Meos.RightStboxTspatial(this.Ptr, temp.Ptr);

        public STBox? Round(int maxdd)
            => MEOSFactory.WrapSTBox(Meos.StboxRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.StboxSrid(this.Ptr);

        public bool Same(STBox box2)
            => Meos.SameStboxStbox(this.Ptr, box2.Ptr);

        public bool Same(TSpatial temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TCBuffer temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TGeogPoint temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TGeography temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TGeomPoint temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TGeometry temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TH3Index temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TNPoint temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TPose temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TPoseChain temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TQuadbin temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TRGeometry temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public bool Same(TS2Cell temp)
            => Meos.SameStboxTspatial(this.Ptr, temp.Ptr);

        public STBox? ScaleTime(Interval duration)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBox(Meos.StboxScaleTime(this.Ptr, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public STBox? SetSRID(int srid)
            => MEOSFactory.WrapSTBox(Meos.StboxSetSrid(this.Ptr, srid));

        public STBox? ShiftScaleTime(Interval shift, Interval duration)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBox(Meos.StboxShiftScaleTime(this.Ptr, _shift, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
                Marshal.FreeHGlobal(_duration);
            }
        }

        public STBox? ShiftTime(Interval shift)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                return MEOSFactory.WrapSTBox(Meos.StboxShiftTime(this.Ptr, _shift));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
            }
        }

        public byte[]? Sortkey()
        {
            IntPtr _size = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.StboxSortkey(this.Ptr, _size);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size);
            }
        }

        public STBox?[] SpaceTiles(double xsize, double ysize, double zsize, Geo sorigin, bool border_inc)
            => MEOSFactory.WrapSTBoxArray(Meos.StboxSpaceTiles(this.Ptr, xsize, ysize, zsize, sorigin.Ptr, border_inc));

        public STBox?[] SpaceTimeTiles(double xsize, double ysize, double zsize, Interval duration, Geo sorigin, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBoxArray(Meos.StboxSpaceTimeTiles(this.Ptr, xsize, ysize, zsize, _duration, sorigin.Ptr, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public double SpatialDistance(STBox box2)
            => Meos.StboxSpatialDistance(this.Ptr, box2.Ptr);

        public STBox?[] TimeTiles(Interval duration, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBoxArray(Meos.StboxTimeTiles(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public DateTime? Tmax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxTmax(this.Ptr, _result))
                {
                    return null;
                }

                return MEOSConvert.ToDateTime(Marshal.ReadInt64(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public bool? TmaxInc()
        {
            IntPtr _result = Marshal.AllocHGlobal(1);
            try
            {
                if (!Meos.StboxTmaxInc(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.ReadByte(_result) != 0;
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public DateTime? Tmin()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxTmin(this.Ptr, _result))
                {
                    return null;
                }

                return MEOSConvert.ToDateTime(Marshal.ReadInt64(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public bool? TminInc()
        {
            IntPtr _result = Marshal.AllocHGlobal(1);
            try
            {
                if (!Meos.StboxTminInc(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.ReadByte(_result) != 0;
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public BOX3D? ToBox3d()
            => MEOSConvert.ToStruct<BOX3D>(Meos.StboxToBox3d(this.Ptr));

        public GBOX? ToGbox()
            => MEOSConvert.ToStruct<GBOX>(Meos.StboxToGbox(this.Ptr));

        public Geo? ToGeo()
            => MEOSFactory.WrapGeo(Meos.StboxToGeo(this.Ptr));

        public Geo? ToGeog()
            => MEOSFactory.WrapGeo(Meos.StboxToGeog(this.Ptr));

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.StboxToGeom(this.Ptr));

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(Meos.StboxToTstzspan(this.Ptr));

        public STBox? Transform(int srid)
            => MEOSFactory.WrapSTBox(Meos.StboxTransform(this.Ptr, srid));

        public STBox? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapSTBox(Meos.StboxTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

        public STBox? Union(STBox box2, bool strict)
            => MEOSFactory.WrapSTBox(Meos.UnionStboxStbox(this.Ptr, box2.Ptr, strict));

        public double Volume()
            => Meos.StboxVolume(this.Ptr);

        public double? Xmax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxXmax(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double? Xmin()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxXmin(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double? Ymax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxYmax(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double? Ymin()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxYmin(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double? Zmax()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxZmax(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public double? Zmin()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.StboxZmin(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public static STBox? FromBox3d(BOX3D box)
        {
            IntPtr _box = Marshal.AllocHGlobal(Marshal.SizeOf<BOX3D>());
            try
            {
                Marshal.StructureToPtr(box, _box, false);
                return MEOSFactory.WrapSTBox(Meos.Box3dToStbox(_box));
            }
            finally
            {
                Marshal.FreeHGlobal(_box);
            }
        }

        public static STBox? FromEWKB(byte[] wkb)
            => STBox.FromWKB(wkb);

        public static STBox? FromEWKT(string str)
            => STBox.In(str);

        public static STBox? FromGbox(GBOX box)
        {
            IntPtr _box = Marshal.AllocHGlobal(Marshal.SizeOf<GBOX>());
            try
            {
                Marshal.StructureToPtr(box, _box, false);
                return MEOSFactory.WrapSTBox(Meos.GboxToStbox(_box));
            }
            finally
            {
                Marshal.FreeHGlobal(_box);
            }
        }

        public static STBox? FromHexEWKB(string hexwkb)
            => STBox.FromHexWKB(hexwkb);

        public static STBox? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapSTBox(Meos.StboxFromHexwkb(hexwkb));

        public static STBox? FromText(string str)
            => STBox.In(str);

        public static STBox? FromTimestamptz(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.TimestamptzToStbox(MEOSConvert.ToTimestampTz(t)));

        public static STBox? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSTBox(Meos.StboxFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static STBox? GetSpaceTile(Geo point, double xsize, double ysize, double zsize, Geo sorigin)
            => MEOSFactory.WrapSTBox(Meos.StboxGetSpaceTile(point.Ptr, xsize, ysize, zsize, sorigin.Ptr));

        public static STBox? GetSpaceTimeTile(Geo point, DateTime t, double xsize, double ysize, double zsize, Interval duration, Geo sorigin, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBox(Meos.StboxGetSpaceTimeTile(point.Ptr, MEOSConvert.ToTimestampTz(t), xsize, ysize, zsize, _duration, sorigin.Ptr, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public static STBox? GetTimeTile(DateTime t, Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBox(Meos.StboxGetTimeTile(MEOSConvert.ToTimestampTz(t), _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public static STBox? In(string str)
            => MEOSFactory.WrapSTBox(Meos.StboxIn(str));

        public static STBox? Make(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, Span s)
            => MEOSFactory.WrapSTBox(Meos.StboxMake(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s.Ptr));

    }
}
