#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Temporal types carrying an STBox spatial bounding box.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TSpatial : Temporal
    {
        internal TSpatial(IntPtr ptr) : base(ptr) { }

        public bool Above(STBox box)
            => Meos.AboveTspatialStbox(this.Ptr, box.Ptr);

        public bool Above(TSpatial temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Adjacent(STBox box)
            => Meos.AdjacentTspatialStbox(this.Ptr, box.Ptr);

        public bool Adjacent(TSpatial temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool After(STBox box)
            => Meos.AfterTspatialStbox(this.Ptr, box.Ptr);

        public bool After(TSpatial temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public byte[]? AsEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.TspatialAsEwkb(this.Ptr, variant, _size_out);
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
            => Meos.TspatialAsEwkt(this.Ptr, maxdd);

        public string AsHexEWKB(byte variant)
            => Meos.TspatialAsHexewkb(this.Ptr, variant);

        public new string AsText(int maxdd)
            => Meos.TspatialAsText(this.Ptr, maxdd);

        public bool Back(STBox box)
            => Meos.BackTspatialStbox(this.Ptr, box.Ptr);

        public bool Back(TSpatial temp2)
            => Meos.BackTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Before(STBox box)
            => Meos.BeforeTspatialStbox(this.Ptr, box.Ptr);

        public bool Before(TSpatial temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Below(STBox box)
            => Meos.BelowTspatialStbox(this.Ptr, box.Ptr);

        public bool Below(TSpatial temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contained(STBox box)
            => Meos.ContainedTspatialStbox(this.Ptr, box.Ptr);

        public bool Contained(TSpatial temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(STBox box)
            => Meos.ContainsTspatialStbox(this.Ptr, box.Ptr);

        public bool Contains(TSpatial temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Front(STBox box)
            => Meos.FrontTspatialStbox(this.Ptr, box.Ptr);

        public bool Front(TSpatial temp2)
            => Meos.FrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Left(STBox box)
            => Meos.LeftTspatialStbox(this.Ptr, box.Ptr);

        public bool Left(TSpatial temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overabove(STBox box)
            => Meos.OveraboveTspatialStbox(this.Ptr, box.Ptr);

        public bool Overabove(TSpatial temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(STBox box)
            => Meos.OverafterTspatialStbox(this.Ptr, box.Ptr);

        public bool Overafter(TSpatial temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overback(STBox box)
            => Meos.OverbackTspatialStbox(this.Ptr, box.Ptr);

        public bool Overback(TSpatial temp2)
            => Meos.OverbackTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(STBox box)
            => Meos.OverbeforeTspatialStbox(this.Ptr, box.Ptr);

        public bool Overbefore(TSpatial temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(STBox box)
            => Meos.OverbelowTspatialStbox(this.Ptr, box.Ptr);

        public bool Overbelow(TSpatial temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overfront(STBox box)
            => Meos.OverfrontTspatialStbox(this.Ptr, box.Ptr);

        public bool Overfront(TSpatial temp2)
            => Meos.OverfrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(STBox box)
            => Meos.OverlapsTspatialStbox(this.Ptr, box.Ptr);

        public bool Overlaps(TSpatial temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(STBox box)
            => Meos.OverleftTspatialStbox(this.Ptr, box.Ptr);

        public bool Overleft(TSpatial temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(STBox box)
            => Meos.OverrightTspatialStbox(this.Ptr, box.Ptr);

        public bool Overright(TSpatial temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Right(STBox box)
            => Meos.RightTspatialStbox(this.Ptr, box.Ptr);

        public bool Right(TSpatial temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public int SRID()
            => Meos.TspatialSrid(this.Ptr);

        public bool Same(STBox box)
            => Meos.SameTspatialStbox(this.Ptr, box.Ptr);

        public bool Same(TSpatial temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? SetSRID(int srid)
            => MEOSFactory.WrapTemporal(Meos.TspatialSetSrid(this.Ptr, srid));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TspatialToStbox(this.Ptr));

        public Temporal? Transform(int srid)
            => MEOSFactory.WrapTemporal(Meos.TspatialTransform(this.Ptr, srid));

        public Temporal? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapTemporal(Meos.TspatialTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

    }
}
