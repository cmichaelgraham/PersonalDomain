using System;
using System.Linq.Expressions;
using Domain.Seedwork.Entities;

namespace Domain.Seedwork.Specifications
{
    public class TrueSpecification<T> : Specification<T> where T : EquatableDomainObject<T>
    {
        public override Expression<Func<T, Boolean>> SatisfiedBy()
        {
            //Create "result variable" transform adhoc execution plan in prepared plan
            //for more info: http://geeks.ms/blogs/unai/2010/07/91/ef-4-0-performance-tips-1.aspx
            bool result = true;

            Expression<Func<T, Boolean>> trueExpression = t => result;
            return trueExpression;
        }
    }
}
