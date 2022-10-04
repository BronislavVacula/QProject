namespace Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DatabaseColumn : Attribute
    {
        public bool ReadOnly { get; set; } = false;
    }
}
