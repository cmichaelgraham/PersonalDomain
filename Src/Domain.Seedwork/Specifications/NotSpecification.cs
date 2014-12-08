using System;
using System.Linq;
using System.Linq.Expressions;
using Domain.Seedwork.Entities;

namespace Domain.Seedwork.Specifications
{
    public class NotSpecification<T> : Specification<T> where T : EquatableDomainObject<T>
    {
        private readonly Expression<Func<T, Boolean>> _originalCriteria;

        public NotSpecification(ISpecification<T> originalSpecification)
        {
            _originalCriteria = originalSpecification.SatisfiedBy();
        }

        public NotSpecification(Expression<Func<T, Boolean>> originalSpecification)
        {
            _originalCriteria = originalSpecification;
        }

        public override Expression<Func<T, Boolean>> SatisfiedBy()
        {
            return Expression.Lambda<Func<T, Boolean>>(Expression.Not(_originalCriteria.Body), _originalCriteria.Parameters.Single());
        }

    }
}
