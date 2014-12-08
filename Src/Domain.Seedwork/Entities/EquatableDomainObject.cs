using System;
using System.Collections.Generic;
using System.Reflection;

namespace Domain.Seedwork.Entities
{
    //http://grabbagoft.blogspot.com/2007/06/generic-value-object-equality.html

    public abstract class EquatableDomainObject<T> : IEquatable<T> where T : class
    {
        public override Boolean Equals(Object obj)
        {
            return obj != null && Equals(obj);
        }

        public virtual Boolean Equals(T other)
        {
            if (other == null)
                return false;

            Type t = GetType();
            Type otherType = other.GetType();

            if (t != otherType)
                return false;

            FieldInfo[] fields = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var fieldInfo in fields)
            {
                object value1 = fieldInfo.GetValue(other);
                object value2 = fieldInfo.GetValue(this);

                if (value1 == null)
                {
                    if (value2 != null)
                        return false;
                }
                else if (!value1.Equals(value2))
                    return false;
            }

            return true;
        }

        private IEnumerable<FieldInfo> GetFields()
        {
            Type t = GetType();

            List<FieldInfo> fields = new List<FieldInfo>();

            while (t != typeof(object))
            {
                fields.AddRange(t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public));
                t = t.BaseType;
            }

            return fields;
        }

        public override Int32 GetHashCode()
        {
            IEnumerable<FieldInfo> fields = GetFields();

            int startValue = 17;
            int multiplier = 59;

            int hashCode = startValue;

            foreach (FieldInfo field in fields)
            {
                object value = field.GetValue(this);

                if (value != null)
                    hashCode = hashCode * multiplier + value.GetHashCode();
            }

            return hashCode;
        }

        public static Boolean operator ==(EquatableDomainObject<T> left, EquatableDomainObject<T> right)
        {
            return Equals(left, null) ? (Equals(right, null)) : left.Equals(right);
        }

        public static Boolean operator !=(EquatableDomainObject<T> left, EquatableDomainObject<T> right)
        {
            return !(left == right);
        }
    }
}
