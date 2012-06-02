using Lego.Specification;

namespace Lego.Security.Rules
{
    public interface IAccessRule<TSubject> : ISpecification<TSubject>
    {
        new bool IsSatisfiedBy(TSubject subject);
    }

    public class AndRule<TSubject> : AndSpecification<TSubject>, IAccessRule<TSubject>
    {
        public AndRule(ISpecification<TSubject> s1, ISpecification<TSubject> s2)
            : base(s1, s2)
        {
        }
    }
    public class OrRule<TSubject> : OrSpecification<TSubject>, IAccessRule<TSubject>
    {
        public OrRule(ISpecification<TSubject> s1, ISpecification<TSubject> s2)
            : base(s1, s2)
        {
        }
    }
    public class NotRule<TSubject> : NotSpecification<TSubject>, IAccessRule<TSubject>
    {
        public NotRule(ISpecification<TSubject> s1)
            : base(s1)
        {
        }
    }

    public static class AccessRuleExtensions
    {
        public static IAccessRule<TSubject> And<TSubject>(this IAccessRule<TSubject> s1, IAccessRule<TSubject> s2)
        {
            return new AndRule<TSubject>(s1, s2);
        }

        public static IAccessRule<TSubject> Or<TSubject>(this IAccessRule<TSubject> s1, IAccessRule<TSubject> s2)
        {
            return new OrRule<TSubject>(s1, s2);
        }

        public static IAccessRule<TSubject> Not<TSubject>(this IAccessRule<TSubject> s)
        {
            return new NotRule<TSubject>(s);
        }
    }
}