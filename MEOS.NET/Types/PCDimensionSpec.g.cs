#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Types
{
    /// <summary>The MEOS <c>PCDimensionSpec</c>, as the values of its fields.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public readonly record struct PCDimensionSpec(string Name, string Description, int Position, string Interpretation, double Scale, double Offset, bool Active)
    {
        /// <summary>The values laid out one after another as MEOS reads
        /// them, each string a copy added to <paramref name="strings"/>,
        /// which the caller frees with the block after the call.</summary>
        internal static IntPtr ToBlock(PCDimensionSpec[] values, List<IntPtr> strings)
        {
            IntPtr block = Marshal.AllocHGlobal(56 * Math.Max(values.Length, 1));
            for (int i = 0; i < values.Length; i++)
            {
                IntPtr item = IntPtr.Add(block, i * 56);
                PCDimensionSpec value = values[i];
                IntPtr _Name = value.Name is null ? IntPtr.Zero
                    : Marshal.StringToCoTaskMemUTF8(value.Name);
                strings.Add(_Name);
                Marshal.WriteIntPtr(item, 0, _Name);
                IntPtr _Description = value.Description is null ? IntPtr.Zero
                    : Marshal.StringToCoTaskMemUTF8(value.Description);
                strings.Add(_Description);
                Marshal.WriteIntPtr(item, 8, _Description);
                Marshal.StructureToPtr(value.Position, IntPtr.Add(item, 16), false);
                IntPtr _Interpretation = value.Interpretation is null ? IntPtr.Zero
                    : Marshal.StringToCoTaskMemUTF8(value.Interpretation);
                strings.Add(_Interpretation);
                Marshal.WriteIntPtr(item, 24, _Interpretation);
                Marshal.StructureToPtr(value.Scale, IntPtr.Add(item, 32), false);
                Marshal.StructureToPtr(value.Offset, IntPtr.Add(item, 40), false);
                Marshal.WriteByte(item, 48, (byte) (value.Active ? 1 : 0));
            }

            return block;
        }
    }
}
