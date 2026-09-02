using MEOS.NET.Functions;

namespace MEOS.NET.Types.Collections.Integer
{
	public sealed class IntegerSpan : Span
	{
        internal IntegerSpan(IntPtr ptr) : base(ptr)
        { }

        public static IntegerSpan FromBounds(int xMin, int xMax, bool minInclusive = true, bool maxInclusive = false)
        {
            var res = Meos.IntspanMake(xMin, xMax, minInclusive, maxInclusive);
            return new IntegerSpan(res);
        }

        // TODO : Implement methods accordingly to PyMEOS and FloatSpan class
    }
}

