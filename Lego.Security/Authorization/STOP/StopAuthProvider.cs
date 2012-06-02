using System;
using Lego.Security.Tasks;

namespace Lego.Security.Authorization.STOP
{
    public class StopAuthProvider<TRule, TSubject, TTask, TObject, TRelation, TRole> : IAuthorizationProvider<TSubject, TTask> where TRule : IStopRule<TSubject, TTask, TObject, TRelation, TRole>
    {
        private readonly IStopRulesRepository<TRule, TSubject, TTask, TObject, TRelation, TRole> _repository;
        private TSubject _subject;

        public StopAuthProvider(IStopRulesRepository<TRule, TSubject, TTask, TObject, TRelation, TRole> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Just sets the subject to be authorized.
        /// Used for fluent programming.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        public IAuthorizationProvider<TSubject, TTask> Authorize(TSubject subject)
        {
            _subject = subject;
            return this;
        }

        public bool To(TTask task)
        {
            return To(task, false);
        }

        public bool To(TTask task, bool permissive)
        {
            if (permissive)
                return !WasForbidden(_subject, task);

            return WasGranted(_subject, task);
        }

        public bool To(TTask task, TObject obj, TRelation relation, bool permissive = false)
        {
            if (permissive)
                return !WasForbidden(_subject, task, obj, relation);

            return WasGranted(_subject, task, obj, relation);
        }

        public bool Authorize(TSubject subject, TTask task)
        {
            return Authorize(subject, task, false);
        }

        public bool Authorize(TSubject subject, TTask task, bool permissive)
        {
            if (permissive)
                return !WasForbidden(subject, task);

            return WasGranted(_subject, task);
        }

        public bool Authorize(TSubject subject, TTask task, TObject obj, TRelation relation, bool permissive)
        {
            if (permissive)
                return !WasForbidden(subject, task, obj, relation);

            return WasGranted(_subject, task, obj, relation);
        }

        public bool WasGranted(TSubject subject, TTask task)
        {
            throw new NotImplementedException();
        }

        public bool WasGranted(TSubject subject, TTask task, TObject obj, TRelation relation)
        {
            var rule = _repository.GetSubjectRule(subject, task, obj);

            return rule != null && rule.GetPermission() == Permission.Allow;
        }

        public bool WasForbidden(TSubject subject, TTask task)
        {
            throw new NotImplementedException();
        }

        public bool WasForbidden(TSubject subject, TTask task, TObject obj, TRelation relation)
        {
            var rule = _repository.GetSubjectRule(subject, task, obj);

            return rule != null && rule.GetPermission() == Permission.Deny;
        }
    }
}