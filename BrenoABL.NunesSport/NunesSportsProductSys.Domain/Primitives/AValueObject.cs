using System;

namespace NSPS.Domain.Primitives;

public abstract class AValueObject : IEquatable<AValueObject>
{

    public abstract IEnumerable<object> GetAtomicValues();



    //-----
    private bool ValuesAreEqual(AValueObject other)
    {
        return GetAtomicValues().SequenceEqual(other.GetAtomicValues());
    }

    public bool Equals(AValueObject? other)
    {
        return other is not null && ValuesAreEqual(other);
    }

    public override bool Equals(object? obj)
    {
        return obj is AValueObject other && ValuesAreEqual(other);
    }

    public override int GetHashCode()
    {
        return GetAtomicValues().
            Aggregate(default(int), HashCode.Combine);
    }

}
