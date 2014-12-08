using Domain.Seedwork.Entities;

namespace Domain.Seedwork.Specifications
{
    public abstract class CompositeSpecification<T> : Specification<T> where T : EquatableDomainObject<T>
    {
        public abstract ISpecification<T> LeftSideSpecification { get; }
        public abstract ISpecification<T> RightSideSpecification { get; }
    }
}
