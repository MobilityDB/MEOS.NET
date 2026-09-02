using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_float.h</c> declares.</summary>
    public static partial class Meos
    {
        public static float AddFloat4Float4(float num1, float num2)
            => SafeExecution<float>(() => Native.AddFloat4Float4(num1, num2));

        public static double AddFloat4Float8(float num1, double num2)
            => SafeExecution<double>(() => Native.AddFloat4Float8(num1, num2));

        public static double AddFloat8Float4(double num1, float num2)
            => SafeExecution<double>(() => Native.AddFloat8Float4(num1, num2));

        public static double AddFloat8Float8(double num1, double num2)
            => SafeExecution<double>(() => Native.AddFloat8Float8(num1, num2));

        public static float DivFloat4Float4(float num1, float num2)
            => SafeExecution<float>(() => Native.DivFloat4Float4(num1, num2));

        public static double DivFloat4Float8(float num1, double num2)
            => SafeExecution<double>(() => Native.DivFloat4Float8(num1, num2));

        public static double DivFloat8Float4(double num1, float num2)
            => SafeExecution<double>(() => Native.DivFloat8Float4(num1, num2));

        public static double DivFloat8Float8(double num1, double num2)
            => SafeExecution<double>(() => Native.DivFloat8Float8(num1, num2));

        public static bool EqFloat4Float4(float num1, float num2)
            => SafeExecution<bool>(() => Native.EqFloat4Float4(num1, num2));

        public static bool EqFloat4Float8(float num1, double num2)
            => SafeExecution<bool>(() => Native.EqFloat4Float8(num1, num2));

        public static bool EqFloat8Float4(double num1, float num2)
            => SafeExecution<bool>(() => Native.EqFloat8Float4(num1, num2));

        public static bool EqFloat8Float8(double num1, double num2)
            => SafeExecution<bool>(() => Native.EqFloat8Float8(num1, num2));

        public static float Float4Abs(float num)
            => SafeExecution<float>(() => Native.Float4Abs(num));

        public static int Float4Cmp(float num1, float num2)
            => SafeExecution<int>(() => Native.Float4Cmp(num1, num2));

        public static uint Float4Hash(float num)
            => SafeExecution<uint>(() => Native.Float4Hash(num));

        public static ulong Float4HashExtended(float num, ulong seed)
            => SafeExecution<ulong>(() => Native.Float4HashExtended(num, seed));

        public static float Float4In(string num)
            => SafeExecution<float>(() => Native.Float4In(num));

        public static float Float4Larger(float num1, float num2)
            => SafeExecution<float>(() => Native.Float4Larger(num1, num2));

        public static string Float4Out(float num)
            => SafeExecution<string>(() => Native.Float4Out(num));

        public static float Float4Smaller(float num1, float num2)
            => SafeExecution<float>(() => Native.Float4Smaller(num1, num2));

        public static double Float4ToFloat8(float num)
            => SafeExecution<double>(() => Native.Float4ToFloat8(num));

        public static short Float4ToInt16(float num)
            => SafeExecution<short>(() => Native.Float4ToInt16(num));

        public static int Float4ToInt32(float num)
            => SafeExecution<int>(() => Native.Float4ToInt32(num));

        public static float Float4Um(float num)
            => SafeExecution<float>(() => Native.Float4Um(num));

        public static float Float4Up(float num)
            => SafeExecution<float>(() => Native.Float4Up(num));

        public static double Float8Abs(double num)
            => SafeExecution<double>(() => Native.Float8Abs(num));

        public static double Float8Acos(double num)
            => SafeExecution<double>(() => Native.Float8Acos(num));

        public static double Float8Acosd(double num)
            => SafeExecution<double>(() => Native.Float8Acosd(num));

        public static double Float8Acosh(double num)
            => SafeExecution<double>(() => Native.Float8Acosh(num));

        public static double Float8Asin(double num)
            => SafeExecution<double>(() => Native.Float8Asin(num));

        public static double Float8Asind(double num)
            => SafeExecution<double>(() => Native.Float8Asind(num));

        public static double Float8Asinh(double num)
            => SafeExecution<double>(() => Native.Float8Asinh(num));

        public static double Float8Atan(double num)
            => SafeExecution<double>(() => Native.Float8Atan(num));

        public static double Float8Atan2(double num1, double num2)
            => SafeExecution<double>(() => Native.Float8Atan2(num1, num2));

        public static double Float8Atan2d(double num1, double num2)
            => SafeExecution<double>(() => Native.Float8Atan2d(num1, num2));

        public static double Float8Atand(double num)
            => SafeExecution<double>(() => Native.Float8Atand(num));

        public static double Float8Atanh(double num)
            => SafeExecution<double>(() => Native.Float8Atanh(num));

        public static double Float8Cbrt(double num)
            => SafeExecution<double>(() => Native.Float8Cbrt(num));

        public static double Float8Ceil(double num)
            => SafeExecution<double>(() => Native.Float8Ceil(num));

        public static int Float8Cmp(double num1, double num2)
            => SafeExecution<int>(() => Native.Float8Cmp(num1, num2));

        public static double Float8Cos(double num)
            => SafeExecution<double>(() => Native.Float8Cos(num));

        public static double Float8Cosd(double num)
            => SafeExecution<double>(() => Native.Float8Cosd(num));

        public static double Float8Cosh(double num)
            => SafeExecution<double>(() => Native.Float8Cosh(num));

        public static double Float8Cot(double num)
            => SafeExecution<double>(() => Native.Float8Cot(num));

        public static double Float8Cotd(double num)
            => SafeExecution<double>(() => Native.Float8Cotd(num));

        public static double Float8Degrees(double num)
            => SafeExecution<double>(() => Native.Float8Degrees(num));

        public static double Float8Exp(double num)
            => SafeExecution<double>(() => Native.Float8Exp(num));

        public static double Float8Floor(double num)
            => SafeExecution<double>(() => Native.Float8Floor(num));

        public static double Float8Gamma(double num)
            => SafeExecution<double>(() => Native.Float8Gamma(num));

        public static uint Float8Hash(double num)
            => SafeExecution<uint>(() => Native.Float8Hash(num));

        public static ulong Float8HashExtended(double num, ulong seed)
            => SafeExecution<ulong>(() => Native.Float8HashExtended(num, seed));

        public static double Float8In(string str)
            => SafeExecution<double>(() => Native.Float8In(str));

        public static double Float8Larger(double num1, double num2)
            => SafeExecution<double>(() => Native.Float8Larger(num1, num2));

        public static double Float8Lgamma(double num)
            => SafeExecution<double>(() => Native.Float8Lgamma(num));

        public static double Float8Ln(double num)
            => SafeExecution<double>(() => Native.Float8Ln(num));

        public static double Float8Log10(double num)
            => SafeExecution<double>(() => Native.Float8Log10(num));

        public static double Float8Pi()
            => SafeExecution<double>(() => Native.Float8Pi());

        public static double Float8Pow(double num1, double num2)
            => SafeExecution<double>(() => Native.Float8Pow(num1, num2));

        public static double Float8Radians(double num)
            => SafeExecution<double>(() => Native.Float8Radians(num));

        public static double Float8Rint(double num)
            => SafeExecution<double>(() => Native.Float8Rint(num));

        public static double Float8Round(double num, int maxdd)
            => SafeExecution<double>(() => Native.Float8Round(num, maxdd));

        public static double Float8Sign(double num)
            => SafeExecution<double>(() => Native.Float8Sign(num));

        public static double Float8Sin(double num)
            => SafeExecution<double>(() => Native.Float8Sin(num));

        public static double Float8Sind(double num)
            => SafeExecution<double>(() => Native.Float8Sind(num));

        public static double Float8Sinh(double num)
            => SafeExecution<double>(() => Native.Float8Sinh(num));

        public static double Float8Smaller(double num1, double num2)
            => SafeExecution<double>(() => Native.Float8Smaller(num1, num2));

        public static double Float8Sqrt(double num)
            => SafeExecution<double>(() => Native.Float8Sqrt(num));

        public static double Float8Tan(double num)
            => SafeExecution<double>(() => Native.Float8Tan(num));

        public static double Float8Tand(double num)
            => SafeExecution<double>(() => Native.Float8Tand(num));

        public static double Float8Tanh(double num)
            => SafeExecution<double>(() => Native.Float8Tanh(num));

        public static float Float8ToFloat4(double num)
            => SafeExecution<float>(() => Native.Float8ToFloat4(num));

        public static short Float8ToInt16(double num)
            => SafeExecution<short>(() => Native.Float8ToInt16(num));

        public static int Float8ToInt32(double num)
            => SafeExecution<int>(() => Native.Float8ToInt32(num));

        public static double Float8Trunc(double num)
            => SafeExecution<double>(() => Native.Float8Trunc(num));

        public static double Float8Um(double num)
            => SafeExecution<double>(() => Native.Float8Um(num));

        public static double Float8Up(double num)
            => SafeExecution<double>(() => Native.Float8Up(num));

        public static int Float8WidthBucket(double num, double bound1, double bound2, int count)
            => SafeExecution<int>(() => Native.Float8WidthBucket(num, bound1, bound2, count));

        public static bool GeFloat4Float4(float num1, float num2)
            => SafeExecution<bool>(() => Native.GeFloat4Float4(num1, num2));

        public static bool GeFloat4Float8(float num1, double num2)
            => SafeExecution<bool>(() => Native.GeFloat4Float8(num1, num2));

        public static bool GeFloat8Float4(double num1, float num2)
            => SafeExecution<bool>(() => Native.GeFloat8Float4(num1, num2));

        public static bool GeFloat8Float8(double num1, double num2)
            => SafeExecution<bool>(() => Native.GeFloat8Float8(num1, num2));

        public static bool GtFloat4Float4(float num1, float num2)
            => SafeExecution<bool>(() => Native.GtFloat4Float4(num1, num2));

        public static bool GtFloat4Float8(float num1, double num2)
            => SafeExecution<bool>(() => Native.GtFloat4Float8(num1, num2));

        public static bool GtFloat8Float4(double num1, float num2)
            => SafeExecution<bool>(() => Native.GtFloat8Float4(num1, num2));

        public static bool GtFloat8Float8(double num1, double num2)
            => SafeExecution<bool>(() => Native.GtFloat8Float8(num1, num2));

        public static float Int16ToFloat4(short num)
            => SafeExecution<float>(() => Native.Int16ToFloat4(num));

        public static double Int16ToFloat8(short num)
            => SafeExecution<double>(() => Native.Int16ToFloat8(num));

        public static float Int32ToFloat4(int num)
            => SafeExecution<float>(() => Native.Int32ToFloat4(num));

        public static double Int32ToFloat8(int num)
            => SafeExecution<double>(() => Native.Int32ToFloat8(num));

        public static bool LeFloat4Float4(float num1, float num2)
            => SafeExecution<bool>(() => Native.LeFloat4Float4(num1, num2));

        public static bool LeFloat4Float8(float num1, double num2)
            => SafeExecution<bool>(() => Native.LeFloat4Float8(num1, num2));

        public static bool LeFloat8Float4(double num1, float num2)
            => SafeExecution<bool>(() => Native.LeFloat8Float4(num1, num2));

        public static bool LeFloat8Float8(double num1, double num2)
            => SafeExecution<bool>(() => Native.LeFloat8Float8(num1, num2));

        public static bool LtFloat4Float4(float num1, float num2)
            => SafeExecution<bool>(() => Native.LtFloat4Float4(num1, num2));

        public static bool LtFloat4Float8(float num1, double num2)
            => SafeExecution<bool>(() => Native.LtFloat4Float8(num1, num2));

        public static bool LtFloat8Float4(double num1, float num2)
            => SafeExecution<bool>(() => Native.LtFloat8Float4(num1, num2));

        public static bool LtFloat8Float8(double num1, double num2)
            => SafeExecution<bool>(() => Native.LtFloat8Float8(num1, num2));

        public static float MinusFloat4Float4(float num1, float num2)
            => SafeExecution<float>(() => Native.MinusFloat4Float4(num1, num2));

        public static double MinusFloat4Float8(float num1, double num2)
            => SafeExecution<double>(() => Native.MinusFloat4Float8(num1, num2));

        public static double MinusFloat8Float4(double num1, float num2)
            => SafeExecution<double>(() => Native.MinusFloat8Float4(num1, num2));

        public static double MinusFloat8Float8(double num1, double num2)
            => SafeExecution<double>(() => Native.MinusFloat8Float8(num1, num2));

        public static float MulFloat4Float4(float num1, float num2)
            => SafeExecution<float>(() => Native.MulFloat4Float4(num1, num2));

        public static double MulFloat4Float8(float num1, double num2)
            => SafeExecution<double>(() => Native.MulFloat4Float8(num1, num2));

        public static double MulFloat8Float4(double num1, float num2)
            => SafeExecution<double>(() => Native.MulFloat8Float4(num1, num2));

        public static double MulFloat8Float8(double num1, double num2)
            => SafeExecution<double>(() => Native.MulFloat8Float8(num1, num2));

        public static bool NeFloat4Float4(float num1, float num2)
            => SafeExecution<bool>(() => Native.NeFloat4Float4(num1, num2));

        public static bool NeFloat4Float8(float num1, double num2)
            => SafeExecution<bool>(() => Native.NeFloat4Float8(num1, num2));

        public static bool NeFloat8Float4(double num1, float num2)
            => SafeExecution<bool>(() => Native.NeFloat8Float4(num1, num2));

        public static bool NeFloat8Float8(double num1, double num2)
            => SafeExecution<bool>(() => Native.NeFloat8Float8(num1, num2));

    }
}
