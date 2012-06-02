namespace Lego.Security.Authorization.STOP
{
    using System.Collections.Generic;
    using Tasks;

    public interface IStopRulesRepository<TRule,TSubject,TTask,TObject,TRelation,TRole>
    {
        /// <summary>
        /// Returns all the rules for the specified ISubject
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        ISet<TRule> GetSubjectRules(TSubject subject);

        /// <summary>
        /// Returns all the rules for the specified IStopTask
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        ISet<TRule> GetTaskRules(TTask task);

        /// <summary>
        /// Returns all the rules for the specified IStopObject
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        ISet<TRule> GetObjectRules(TObject obj);

        /// <summary>
        /// Get a rule for the specified subject and task where the object, and thus the relation, are both null.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        ISet<TRule> GetRules(TSubject subject, TTask task);

        TRule GetSubjectRule(TSubject subject, TTask task, TObject obj);

        TRule GetRoleRule(TRole role, TTask task, TObject obj);

        TRule GetRelationRule(TRelation relation, TTask task, TObject obj);
    }
}
