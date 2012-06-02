using System.Collections.Generic;
using Lego.Security.Roles;
using Lego.Security.Tasks;

namespace Lego.Security.Authorization.STOP
{
    public interface IStopRule<TSubject, TTask, TObject, TRelation, TRole>
    {
        TSubject GetSubject();
        TTask GetTask();
        TObject GetObject();
        TRelation GetObjectRelation();
        TRole GetRole();
        Permission GetPermission();
    }
}