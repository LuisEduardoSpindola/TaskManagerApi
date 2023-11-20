using TaskManagerApi.Data;
using TaskManagerApi.Interfaces;
using TaskManagerApi.Models;

namespace TaskManagerApi.Repositories
{
    public class TaskRepository : ITask
    {
        private readonly TaskApiContext _context;

        public TaskRepository(TaskApiContext context)
        {
            _context = context;
        }

        public EntityTask Add(EntityTask entityTask)
        {
            var addedEntity = _context.Add(entityTask).Entity;
            _context.SaveChanges();
            return addedEntity;
        }


        public List<EntityTask> Get()
        {
            return _context.Set<EntityTask>().ToList();
        }

        public EntityTask GetById(Guid Id)
        {
            return _context.Set<EntityTask>().FirstOrDefault(task => task.Id == Id);
        }

        public EntityTask Update(EntityTask entityTask)
        {
            var updatedEntity = _context.Update(entityTask).Entity;
            _context.SaveChanges();
            return updatedEntity;
        }


        public void Delete(Guid Id)
        {
            var entityTaskToRemove = _context.Set<EntityTask>().FirstOrDefault(task => task.Id == Id);
            _context.Remove(entityTaskToRemove);
            _context.SaveChanges();
        }
    }
}
