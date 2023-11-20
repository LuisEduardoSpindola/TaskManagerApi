using System.ComponentModel.DataAnnotations;

namespace TaskManagerApi.Models
{
    public class EntityTask
    {
        [Key]
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public DateTime Created { get; private set; } = DateTime.Now;

        public DateTime Term { get; private set; }

        public EntityTask(Guid Id, string Name, string Description, DateTime Created, DateTime Term)
        {
            this.Id = Guid.NewGuid();
            this.Name = Name;
            this.Description = Description;
            this.Created = Created;
            this.Term = Term;
        }
    }
}
