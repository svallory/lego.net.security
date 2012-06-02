using System;
using Lego.Security.Roles;

namespace Lego.Security.Rules
{
    /*
    public class HasRole : AccessRuleBase
    {
        private readonly RoleId _role;

        public HasRole(RoleId role)
        {
            _role = role;
        }

        public HasRole(Type rtype)
        {
            var r = Activator.CreateInstance(rtype) as RoleId;
            _role = r;
        }

        public override bool IsSatisfiedBy(ISubject subject)
        {
            return subject.HasRole(_role);
        }
    }

    public class HasRole<TRole> : HasRole where TRole : IRole
    {
        public HasRole() : base(typeof(TRole))
        {
        }
    }
     * */
}
