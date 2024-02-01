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

            var argsIntersection = first.Arguments.Intersect(other.Arguments);
            var argsAreIdentical = argsIntersection.Count() == first.Arguments.Count();

            return argsAreIdentical
                && first.FunctionName == other.FunctionName
                && first.ReturnType == other.ReturnType;
        }

        public int GetHashCode(CSFunctionDeclaration obj)
            => $"{obj.ReturnType}{obj.FunctionName}{obj.Arguments}".GetHashCode();
    }
}

