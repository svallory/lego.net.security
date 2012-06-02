using Lego.Security.Tasks;

namespace Lego.Security.Authorization
{
    /// <summary>
    /// Self-Authorizable Task Auth Provider
    /// </summary>
    public class SATAuthProvider<TSubject> : IAuthorizationProvider<TSubject, ISelfAuthorizableTask<TSubject>>
    {
        private TSubject _subject;

        public IAuthorizationProvider<TSubject, ISelfAuthorizableTask<TSubject>> Authorize(TSubject subject)
        {
            _subject = subject;
            return this;
        }

        public bool To(ISelfAuthorizableTask<TSubject> task)
        {
            return Authorize(_subject, task);
        }

        public bool Authorize(TSubject subject, ISelfAuthorizableTask<TSubject> task)
        {
            return task.GetAccessRule().IsSatisfiedBy(subject);
        }
    }
}