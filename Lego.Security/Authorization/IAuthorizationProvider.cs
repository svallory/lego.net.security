using Lego.Security.Tasks;

namespace Lego.Security.Authorization
{
    public interface IAuthorizationProvider<TSubject, TTask>
    {
        /// <summary>
        /// Just sets the subject and returns itself.
        /// Used for fluent programming.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        IAuthorizationProvider<TSubject, TTask> Authorize(TSubject subject);

        /// <summary>
        /// Calls Authorize() passing the previously set user.
        /// Used for fluent programming.
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        bool To(TTask task);

        bool Authorize(TSubject subject, TTask task);
    }
}