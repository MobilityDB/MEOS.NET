using MEOS.NET.Internal;

namespace MEOS.NET.Types.Collections.Integer
{
	public sealed class IntegerSpan : Span
	{
        internal IntegerSpan(IntPtr ptr) : base(ptr)
        { }

        public static IntegerSpan FromBounds(int xMin, int xMax, bool minInclusive = true, bool maxInclusive = false)
        {
            var res = MEOSExposedFunctions.intspan_make(xMin, xMax, minInclusive, maxInclusive);
            return new IntegerSpan(res);
        }

        // TODO : Implement methods accordingly to PyMEOS and FloatSpan class
    }
}

