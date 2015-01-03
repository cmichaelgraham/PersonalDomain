using System;

namespace Domain.Seedwork.Entities
{
    public abstract class Entity : EquatableDomainObject<Entity>
    {
        public Int32 Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
