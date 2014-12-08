namespace Domain.Seedwork.Events
{
    public interface IDomainEventHandler<TDomainEvent> where TDomainEvent : IDomainEvent
    {
        void Handle(TDomainEvent eventArgs);
    }
}
