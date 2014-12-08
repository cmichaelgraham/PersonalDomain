using System;
using System.Linq.Expressions;

namespace Domain.Seedwork.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, Boolean>> SatisfiedBy();
    }
}
