using MEOS.NET.Enums;

namespace MEOS.NET.Helpers
{
	public static class EnumConverter
	{
		public static InterpolationType InterpolationTypeFromString(string str)
		{
			var lowered = str.ToLowerInvariant();

			switch (lowered)
			{
				case "none":
					return InterpolationType.None;

				case "discrete":
					return InterpolationType.Discrete;

				case "stepwise":
					return InterpolationType.Stepwise;

				case "linear":
					return InterpolationType.Linear;

				default:
					throw new ArgumentException("Given string does not represent an existing interpolation type");
			}
		}
	}
}

