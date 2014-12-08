using System;
using System.Linq.Expressions;
using Domain.Seedwork.Entities;
using PersonalDomain.Infrastructure.ExpressionBuilder;

namespace Domain.Seedwork.Specifications
{
    public class OrSpecification<T> : CompositeSpecification<T> where T : EquatableDomainObject<T>
    {
        private readonly ISpecification<T> _rightSideSpecification;
        public override ISpecification<T> RightSideSpecification
        {
            get { return _rightSideSpecification; }
        }

        private readonly ISpecification<T> _leftSideSpecification;
        public override ISpecification<T> LeftSideSpecification
        {
            get { return _leftSideSpecification; }
        }

        public OrSpecification(ISpecification<T> leftSide, ISpecification<T> rightSide)
        {
            _leftSideSpecification = leftSide;
            _rightSideSpecification = rightSide;
        }

        public override Expression<Func<T, Boolean>> SatisfiedBy()
        {
            Expression<Func<T, Boolean>> left = _leftSideSpecification.SatisfiedBy();
            Expression<Func<T, Boolean>> right = _rightSideSpecification.SatisfiedBy();

            return (left.Or(right));
        }
    }

}
