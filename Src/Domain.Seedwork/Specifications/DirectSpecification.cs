using System;
using System.Linq.Expressions;
using Domain.Seedwork.Entities;

namespace Domain.Seedwork.Specifications
{
    public class DirectSpecification<T> : Specification<T> where T : EquatableDomainObject<T>
    {
        private readonly Expression<Func<T, Boolean>> _matchingCriteria;

        public DirectSpecification(Expression<Func<T, Boolean>> matchingCriteria)
        {
            _matchingCriteria = matchingCriteria;
        }

        public override Expression<Func<T, Boolean>> SatisfiedBy()
        {
            return _matchingCriteria;
        }
    }
}
