using System;
using System.Globalization;

namespace Lego.Security
{
    public abstract class ValueObject : IValueObject
    {
        public object Value { get; set; }

        #region IEquatable<ValuesClass> Members

        protected ValueObject(object value)
        {
            Value = value;
        }

        public bool Equals(ValueObject other)
        {
            if (ReferenceEquals(null, other)) return false;
            return (this.Value.Equals(other.Value));
        }

        #endregion

        public override bool Equals(object obj)
        {
            return this.Equals(obj as ValueObject);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (-1521134295 * Value.GetHashCode());
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static bool operator ==(ValueObject leftOperand, ValueObject rightOperand)
        {
            if (ReferenceEquals(null, leftOperand)) return ReferenceEquals(null, rightOperand);
            return leftOperand.Equals(rightOperand);
        }

        public static bool operator !=(ValueObject leftOperand, ValueObject rightOperand)
        {
            return !(leftOperand == rightOperand);
        }
    }
}