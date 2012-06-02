using System;

namespace Lego.Security
{
    public interface IId<T> : IEquatable<T>
    {
        object Value { get; }
    }

    public interface ISubjectId : IId<ISubjectId> { }

    public interface ITaskId : IId<ITaskId> { }

    public interface IObjectId : IId<IObjectId> { }

    public interface IRoleId : IId<IRoleId> { }

    public interface IRelationId : IId<IRelationId>
    {
    }
}