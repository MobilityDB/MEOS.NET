using System.Diagnostics.CodeAnalysis;
using MEOS.NET.Builder.Models;

namespace MEOS.NET.Builder.EqualityComparers
{
    public class CSFunctionDeclarationComparer : IEqualityComparer<CSFunctionDeclaration>
    {
        public bool Equals(CSFunctionDeclaration? first, CSFunctionDeclaration? other)
        {
            if (first is null || other is null)
            {
                throw new InvalidOperationException();
            }

            return first.Arguments == other.Arguments
                && first.FunctionName == other.FunctionName
                && first.ReturnType == other.ReturnType;
        }

        public int GetHashCode([DisallowNull] CSFunctionDeclaration obj)
            => $"{obj.ReturnType}{obj.FunctionName}{obj.Arguments}".GetHashCode();
    }
}

