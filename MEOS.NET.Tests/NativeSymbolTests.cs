using System.Reflection;
using System.Runtime.InteropServices;

using MEOS.NET.Functions;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// Every function this binding declares must be a symbol the MEOS it loads
    /// exports.
    ///
    /// A P/Invoke binds by name at the first call, so a function MEOS renames or
    /// drops is invisible to the compiler and reaches a caller as an
    /// <see cref="EntryPointNotFoundException"/> at run time. Resolving every
    /// declared entry point against the loaded library turns that into one named
    /// failure here.
    /// </summary>
    [TestClass]
    public class NativeSymbolTests : MeosTest
    {
        [TestMethod]
        public void EveryDeclaredEntryPointResolvesInTheLoadedMeos()
        {
            string[] entryPoints = DeclaredEntryPoints();

            // A parity check that read no declaration would pass over anything.
            Assert.IsTrue(entryPoints.Length > 1000,
                $"only {entryPoints.Length} entry points were read from the binding");

            IntPtr meos = NativeLibrary.Load("meos", typeof(Meos).Assembly, null);
            List<string> missing = entryPoints
                .Where(name => !NativeLibrary.TryGetExport(meos, name, out _))
                .ToList();

            Assert.AreEqual(0, missing.Count,
                $"MEOS exports none of: {string.Join(", ", missing.Take(20))}");
        }

        [TestMethod]
        public void ASymbolMeosDoesNotExportIsSeenAsMissing()
        {
            IntPtr meos = NativeLibrary.Load("meos", typeof(Meos).Assembly, null);

            Assert.IsFalse(NativeLibrary.TryGetExport(meos, "meos_no_such_function", out _));
            Assert.IsTrue(NativeLibrary.TryGetExport(meos, "meos_initialize", out _));
        }

        /// <summary>The entry point of every native declaration the binding carries.</summary>
        private static string[] DeclaredEntryPoints()
        {
            Type native = typeof(Meos).GetNestedType("Native", BindingFlags.NonPublic)
                ?? throw new InvalidOperationException("the binding declares no Native class");

            return native
                .GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic
                    | BindingFlags.DeclaredOnly)
                .Select(method => method.GetCustomAttribute<LibraryImportAttribute>())
                .Where(attribute => attribute is not null)
                .Select(attribute => attribute!.EntryPoint!)
                .Distinct()
                .ToArray();
        }
    }
}
