using System.Runtime.InteropServices;

using MEOS.NET.API.Internal;

namespace MEOS.NET.Types.Temporal
{
    [StructLayout(LayoutKind.Sequential)]
    public class TemporalGeometryPoint
    {
        private IntPtr _ptr;

        private TemporalGeometryPoint(IntPtr ptr)
        {
            this._ptr = ptr;
        }

        public static TemporalGeometryPoint From(string input)
        {
            IntPtr inst = MEOSFunctions.tgeompoint_in(input);

            return new TemporalGeometryPoint(inst);
        }

        public override string ToString()
        {
            return MEOSFunctions.tpoint_out(this._ptr, 1);
        }
    }
}
