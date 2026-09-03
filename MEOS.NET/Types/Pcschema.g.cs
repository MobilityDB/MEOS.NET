#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The dimension schema a point cloud value is read through. Every pcpoint and pcpatch accessor takes one, and the process-global cache answers it for a pcid. MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Pcschema : Value
    {
        internal Pcschema(IntPtr ptr) : base(ptr) { }

        public static string? Compression(uint pcid)
            => Meos.MeosPcSchemaCompression(pcid);

        public static Pcschema? Get(uint pcid)
            => MEOSFactory.WrapPcschema(Meos.MeosPcSchema(pcid));

        public static int Ndims(uint pcid)
            => Meos.MeosPcSchemaNdims(pcid);

        public static int SRID(uint pcid)
            => Meos.MeosPcSchemaSrid(pcid);

        public static string? Xml(uint pcid)
            => Meos.MeosPcSchemaXml(pcid);

    }
}
