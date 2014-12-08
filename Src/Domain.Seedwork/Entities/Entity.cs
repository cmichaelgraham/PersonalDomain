using System;

namespace Domain.Seedwork.Entities
{
    public abstract class Entity : EquatableDomainObject<Entity>
    {
        public Int32 Id { get; set; }
    }
}
