using System;

namespace AllianceInterview.Infrastructure
{
    public abstract class Entity 
    {
        public string Id { get; }
        private IDataOperation Operation { get; }
        public Entity()
        {
            Id = Guid.NewGuid().ToString();
            Operation = new EntityDataOperation(this);
        }

        public void Delete()
        {
            Operation.Delete();
        }

        public static Entity Find(string Id)
        {
           return EntityDataOperation.Find(Id);
        }

        public void Save()
        {
            Operation.Save();
        }
    }
}
