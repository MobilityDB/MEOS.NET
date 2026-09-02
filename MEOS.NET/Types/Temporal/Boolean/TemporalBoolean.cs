using MEOS.NET.Functions;

namespace MEOS.NET.Types.Temporal.Boolean
{
    public class TemporalBoolean : Temporal
    {
        internal TemporalBoolean(IntPtr ptr) : base(ptr)
        { }

        public static TemporalBoolean FromMFJson(string mfJsonStr)
            => new TemporalBoolean(Meos.TboolFromMfjson(mfJsonStr));
    }
}
