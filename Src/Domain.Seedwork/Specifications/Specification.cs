using System;
using System.Linq.Expressions;
using Domain.Seedwork.Entities;

namespace Domain.Seedwork.Specifications
{
    public abstract class Specification<T> : ISpecification<T> where T : EquatableDomainObject<T>
    {
        public abstract Expression<Func<T, Boolean>> SatisfiedBy();

        public static Specification<T> operator &(Specification<T> leftSideSpecification, Specification<T> rightSideSpecification)
        {
            return new AndSpecification<T>(leftSideSpecification, rightSideSpecification);
        }

        public static Specification<T> operator |(Specification<T> leftSideSpecification, Specification<T> rightSideSpecification)
        {
            return new OrSpecification<T>(leftSideSpecification, rightSideSpecification);
        }

        public static Specification<T> operator !(Specification<T> specification)
        {
            return new NotSpecification<T>(specification);
        }

        public static bool operator false(Specification<T> specification)
        {
            return false;
        }

        public static bool operator true(Specification<T> specification)
        {
            return false;
        }
    }
}
