using System.Collections.Generic;
using Lego.Security.Roles;

namespace Lego.Security
{
    using System;

    public abstract class SubjectId : ValueObject, ISubjectId
    {
        protected SubjectId(object val) : base(val)
        {
        }

        public bool Equals(ISubjectId other)
        {
            return Equals(other as object);
        }
    }

    public abstract class TaskId : ValueObject, ITaskId
    {
        protected TaskId(object value) : base(value)
        {
        }

        public bool Equals(ITaskId other)
        {
            return Equals(other as object);
        }
    }

    public abstract class ObjectId : ValueObject, IObjectId
    {
        protected ObjectId(object value) : base(value)
        {
        }

        public bool Equals(IObjectId other)
        {
            return Equals(other as object);
        }
    }

    public abstract class RoleId : ValueObject, IRoleId
    {
        protected RoleId(object value) : base(value)
        {
        }

        public bool Equals(IRoleId other)
        {
            return Equals(other as object);
        }
    }

    public abstract class RelationId : ValueObject, IRelationId
    {
        protected RelationId(object value)
            : base(value)
        {
        }

        public bool Equals(IRelationId other)
        {
            return Equals(other as object);
        }
    }
}
