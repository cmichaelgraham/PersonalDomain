using System;

namespace Domain.Seedwork.Events
{
    public interface IDomainEvent
    {
        DateTime TimeStamp { get; }
    }
}
