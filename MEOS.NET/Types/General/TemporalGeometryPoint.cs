using MEOS.NET.Internal;

namespace MEOS.NET.Types.General
{
    public class TemporalGeometryPoint
    {
        private IntPtr _ptr;

        private TemporalGeometryPoint(IntPtr ptr)
        {
            this._ptr = ptr;
        }

        public static TemporalGeometryPoint From(string input)
        {
            var inst = MEOSExposedFunctions.tgeompoint_in(input);
            return new TemporalGeometryPoint(inst);
        }

        public static bool operator ==(TemporalGeometryPoint first, TemporalGeometryPoint second)
            => MEOSExposedFunctions.temporal_eq(first._ptr, second._ptr);

        public static bool operator !=(TemporalGeometryPoint first, TemporalGeometryPoint second)
            => MEOSExposedFunctions.temporal_ne(first._ptr, second._ptr);

        public override bool Equals(object? obj)
        {
            if (obj is null || GetType() != obj.GetType())
            {
                return false;
            }

            return MEOSExposedFunctions.temporal_eq(this._ptr, ((TemporalGeometryPoint)obj)._ptr);
        }

        public override int GetHashCode()
            => base.GetHashCode();

        public override string ToString()
            => MEOSExposedFunctions.tpoint_as_text(this._ptr, 1);

        public string ToJson()
            => MEOSExposedFunctions.temporal_as_mfjson(this._ptr, true, 3, 6, string.Empty);
    }
}
