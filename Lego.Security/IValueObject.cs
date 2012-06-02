using System;

namespace Lego.Security
{
    public interface IValueObject : IEquatable<ValueObject>
    {
        object Value { get; set; }
        bool Equals(ValueObject other);
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}