using System.Collections.Generic;
using System.Linq;

namespace solid.Open_Closed_Principle.After
{
    public class SecurityGuard
    {
        private List<ISpecification<User>> _specifications;

        public bool ValidateUser(User user)
        {
            return _specifications.Select(x => x.IsSatisfiedBy(user))
                .All(x => x);
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Cloth { get; set; }
        public string Age { get; set; }
    }

    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T candidate);
    }

    public class UserNameSpecification : ISpecification<User>
    {
        public bool IsSatisfiedBy(User user)
        {
            //...
            return default;
        }
    }
}
