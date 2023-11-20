using TaskManagerApi.Models;

namespace TaskManagerApi.Interfaces
{
    public interface ITask
    {
        EntityTask Add(EntityTask entityTask);
        List<EntityTask> Get();
        EntityTask GetById(Guid Id);
        EntityTask Update(EntityTask entityTask);
        void Delete(Guid Id);
    }
}
