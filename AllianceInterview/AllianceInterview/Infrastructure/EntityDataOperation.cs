using System;

namespace AllianceInterview.Infrastructure
{
    /// <summary>
    /// Peform CRUD operation on text file
    /// </summary>
    public class EntityDataOperation: IDataOperation
    {
        private Entity EntityType { get; }
        public EntityDataOperation()
        {

        }
        public EntityDataOperation(Entity entity)
        {
            EntityType = entity;  
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public static Entity Find(string Id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            var entityType = EntityType;
            throw new NotImplementedException();
        }

        private void ReadFile(string filePath)
        {

        }

        private void GetType()
        {

        }
    }
}
