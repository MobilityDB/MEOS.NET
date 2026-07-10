using MEOS.NET.Internal;

namespace MEOS.NET.Types.Temporal.Boolean
{
    public class TemporalBoolean : Temporal
    {
        internal TemporalBoolean(IntPtr ptr) : base(ptr)
        { }

        public static TemporalBoolean FromMFJson(string mfJsonStr)
            => new TemporalBoolean(MEOSExposedFunctions.tbool_from_mfjson(mfJsonStr));
    }
}
