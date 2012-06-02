using System;
using System.Collections.Generic;
using Lego.Security.Roles;
using Lego.Security.Tasks;

namespace Lego.Security
{
    public interface ISubject
    {
        ICollection<IRole> GetRoles();
        bool HasRole(IRole role);
    }
}