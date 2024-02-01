namespace MEOS.NET.Builder.Models
{
    internal class CSFunctionArgument
    {
        internal string Type { get; set; } = string.Empty;

        internal string Name { get; set; } = string.Empty;

        public override string ToString()
            => $"{this.Type} {this.Name}";

        public override bool Equals(object? obj)
        {
            if (obj?.GetType() != this.GetType()) throw new ArgumentException();

            var other = obj as CSFunctionArgument;
            if (other == null) throw new ArgumentNullException();

            return other.Name == this.Name
                && other.Type == this.Type;
        }

        public override int GetHashCode()
            => $"{this.Type} {this.Name}".GetHashCode();
    }
}
