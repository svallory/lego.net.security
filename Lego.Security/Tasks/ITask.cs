using Lego.Security.Rules;

namespace Lego.Security.Tasks
{
    public interface ITask
    {
        string Name { get; }
    }

    public interface ISelfAuthorizableTask<TSubject> : ITask
    {
        IAccessRule<TSubject> GetAccessRule();
    }
}