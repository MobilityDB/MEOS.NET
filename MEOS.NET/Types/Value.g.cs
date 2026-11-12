#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Base values a binding holds as instances: those MEOS passes by reference, and the grid cells, which it passes by value.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Value : MEOSObject
    {
        internal Value(IntPtr ptr) : base(ptr) { }

    }
}
