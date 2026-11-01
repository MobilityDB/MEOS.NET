#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Set of spatial values, the types MEOS's spatialset_type admits: its SRID, its bounding box and its spatial text and binary forms.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class SpatialSet : Set
    {
        internal SpatialSet(IntPtr ptr) : base(ptr) { }

        public byte[]? AsEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.SpatialsetAsEwkb(this.Ptr, variant, _size_out);
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
            => Meos.SpatialsetAsEwkt(this.Ptr, maxdd);

        public string AsHexEWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                return Meos.SpatialsetAsHexewkb(this.Ptr, variant, _size_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public string AsText(int maxdd)
            => Meos.SpatialsetAsText(this.Ptr, maxdd);

        public string Out(int maxdd)
            => Meos.SpatialsetOut(this.Ptr, maxdd);

        public int SRID()
            => Meos.SpatialsetSrid(this.Ptr);

        public Set? SetSRID(int srid)
            => MEOSFactory.WrapSet(Meos.SpatialsetSetSrid(this.Ptr, srid));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.SpatialsetToStbox(this.Ptr));

        public Set? Transform(int srid)
            => MEOSFactory.WrapSet(Meos.SpatialsetTransform(this.Ptr, srid));

        public Set? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapSet(Meos.SpatialsetTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

    }
}
