#nullable enable

using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

using MEOS.NET.Functions;

namespace MEOS.NET.Structures
{
    /// <summary>The MEOS <c>AFFINE</c> struct, as MEOS returns it.</summary>
    [GeneratedCode("MEOS.NET.Codegen", "0.1.0")]
    [StructLayout(LayoutKind.Sequential)]
    public struct AFFINE
    {
        public double afac;
        public double bfac;
        public double cfac;
        public double dfac;
        public double efac;
        public double ffac;
        public double gfac;
        public double hfac;
        public double ifac;
        public double xoff;
        public double yoff;
        public double zoff;
    }

    /// <summary>The MEOS <c>BOX3D</c> struct, as MEOS returns it.</summary>
    [GeneratedCode("MEOS.NET.Codegen", "0.1.0")]
    [StructLayout(LayoutKind.Sequential)]
    public struct BOX3D
    {
        public double xmin;
        public double ymin;
        public double zmin;
        public double xmax;
        public double ymax;
        public double zmax;
        public int srid;

        /// <summary>The <c>BOX3D</c> MEOS reads from this text.</summary>
        public static BOX3D? In(string str)
        {
            IntPtr ptr = Meos.Box3dIn(str);
            return ptr == IntPtr.Zero ? null : Marshal.PtrToStructure<BOX3D>(ptr);
        }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
        {
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf<BOX3D>());
            try
            {
                Marshal.StructureToPtr(this, ptr, false);
                return Meos.Box3dOut(ptr, 15);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }
    }

    /// <summary>The MEOS <c>Interval</c> struct, as MEOS returns it.</summary>
    [GeneratedCode("MEOS.NET.Codegen", "0.1.0")]
    [StructLayout(LayoutKind.Sequential)]
    public struct Interval
    {
        public long time;
        public int day;
        public int month;

        /// <summary>The <c>Interval</c> MEOS reads from this text.</summary>
        public static Interval? In(string str)
        {
            IntPtr ptr = Meos.IntervalIn(str, -1);
            return ptr == IntPtr.Zero ? null : Marshal.PtrToStructure<Interval>(ptr);
        }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
        {
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(this, ptr, false);
                return Meos.IntervalOut(ptr);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }
    }

    /// <summary>The MEOS <c>Match</c> struct, as MEOS returns it.</summary>
    [GeneratedCode("MEOS.NET.Codegen", "0.1.0")]
    [StructLayout(LayoutKind.Sequential)]
    public struct Match
    {
        public int i;
        public int j;
    }

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

    /// <summary>The MEOS <c>TimeTzADT</c> struct, as MEOS returns it.</summary>
    [GeneratedCode("MEOS.NET.Codegen", "0.1.0")]
    [StructLayout(LayoutKind.Sequential)]
    public struct TimeTzADT
    {
        public long time;
        public int zone;

        /// <summary>The <c>TimeTzADT</c> MEOS reads from this text.</summary>
        public static TimeTzADT? In(string str)
        {
            IntPtr ptr = Meos.PgTimetzIn(str, -1);
            return ptr == IntPtr.Zero ? null : Marshal.PtrToStructure<TimeTzADT>(ptr);
        }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
        {
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf<TimeTzADT>());
            try
            {
                Marshal.StructureToPtr(this, ptr, false);
                return Meos.PgTimetzOut(ptr);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }
    }

}
