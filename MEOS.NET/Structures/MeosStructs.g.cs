#nullable enable

using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

namespace MEOS.NET.Structures
{
    /// <summary>The MEOS <c>MvtGeom</c> struct, as MEOS returns it.</summary>
    [GeneratedCode("MEOS.NET.Codegen", "0.1.0")]
    [StructLayout(LayoutKind.Sequential)]
    public struct MvtGeom
    {
        public IntPtr geom;
        public IntPtr times;
        public int count;
    }

    /// <summary>The MEOS <c>SpaceSplit</c> struct, as MEOS returns it.</summary>
    [GeneratedCode("MEOS.NET.Codegen", "0.1.0")]
    [StructLayout(LayoutKind.Sequential)]
    public struct SpaceSplit
    {
        public IntPtr fragments;
        public IntPtr bins;
        public int count;
    }

    /// <summary>The MEOS <c>SpaceTimeSplit</c> struct, as MEOS returns it.</summary>
    [GeneratedCode("MEOS.NET.Codegen", "0.1.0")]
    [StructLayout(LayoutKind.Sequential)]
    public struct SpaceTimeSplit
    {
        public IntPtr fragments;
        public IntPtr space_bins;
        public IntPtr time_bins;
        public int count;
    }

}
