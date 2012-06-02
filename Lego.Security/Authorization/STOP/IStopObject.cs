namespace Lego.Security.Authorization.STOP
{
    public interface IStopObject
    {
        ObjectId Guid { get; }
        string Name { get; }
    }
}