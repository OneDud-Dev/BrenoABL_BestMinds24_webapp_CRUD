using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace NSPS.Domain.Primitives;

public abstract class AnEntity : IEquatable<AnEntity>
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; private init; }



    protected AnEntity(Guid id)
    {
        Id = id;
    }


    //---
    public override int GetHashCode()
    {
        return Id.GetHashCode() * 41;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        if (obj is not AnEntity entity)
        {
            return false;
        }


        return entity.Id == Id;
    }

    public bool Equals(AnEntity? other)
    {
        if (other is null)
        {
            return false;
        }

        if (other.GetType() != GetType())
        {
            return false;
        }

        return other.Id == Id;
    }

    public static bool operator ==(AnEntity? first, AnEntity? second)
    {
        return first is not null &&
                second is not null &&
                first.Equals(second);
    }

    public static bool operator !=(AnEntity? first, AnEntity? second)
    {
        return !(first == second);
    }

}
