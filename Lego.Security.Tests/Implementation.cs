using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lego.Security.Authorization.STOP;

namespace Lego.Security.Tests
{
    public class MySubject
    {
    }
    public class MyTask
    {
    }
    public class MyObject
    {
    }
    public class MyRole
    {
    }
    public class MyRelation
    {
    }

    class MyRule : IStopRule<MySubject,MyTask,MyObject,MyRelation,MyRole>
    {
        public MySubject GetSubject()
        {
            throw new NotImplementedException();
        }

        public MyTask GetTask()
        {
            throw new NotImplementedException();
        }

        public MyObject GetObject()
        {
            throw new NotImplementedException();
        }

        public MyRelation GetObjectRelation()
        {
            throw new NotImplementedException();
        }

        public MyRole GetRole()
        {
            throw new NotImplementedException();
        }

        public Permission GetPermission()
        {
            throw new NotImplementedException();
        }
    }

    class MyRepo : IStopRulesRepository<MyRule,MySubject,MyTask,MyObject,MyRelation,MyRole>
    {
        public ISet<MyRule> GetSubjectRules(MySubject subject)
        {
            throw new NotImplementedException();
        }

        public ISet<MyRule> GetTaskRules(MyTask task)
        {
            throw new NotImplementedException();
        }

        public ISet<MyRule> GetObjectRules(MyObject obj)
        {
            throw new NotImplementedException();
        }

        public ISet<MyRule> GetRules(MySubject subject, MyTask task)
        {
            throw new NotImplementedException();
        }

        public MyRule GetSubjectRule(MySubject subject, MyTask task, MyObject obj)
        {
            throw new NotImplementedException();
        }

        public MyRule GetRoleRule(MyRole role, MyTask task, MyObject obj)
        {
            throw new NotImplementedException();
        }

        public MyRule GetRelationRule(MyRelation relation, MyTask task, MyObject obj)
        {
            throw new NotImplementedException();
        }
    }
    
    class MyStopAuth : StopAuthProvider<MyRule,MySubject,MyTask,MyObject,MyRelation,MyRole>
    {
        public MyStopAuth(MyRepo repository) : base(repository)
        {
        }
    }
}
