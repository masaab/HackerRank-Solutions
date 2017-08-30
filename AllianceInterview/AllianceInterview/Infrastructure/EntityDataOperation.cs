using AllianceInterview.Domain;
using System;
using System.IO;
using System.Reflection;
using System.Linq;

namespace AllianceInterview.Infrastructure
{
    /// <summary>
    /// Peform CRUD operation on text file
    /// </summary>
    public class EntityDataOperation : IDataOperation
    {
        private Entity EntityType { get; set; }
        private static string FileFullPath{get;set;}
        private const string DatabaseName = "Database.txt";
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
            string[] entityArrayResult = File.ReadAllLines(GetFullFilePath(DatabaseName)).Where(a => a.Contains(Id)).FirstOrDefault().Split('|');
            return CreateEntity(entityArrayResult);
        }

        public void Save()
        {
            var entityType = EntityType;
            var record = $"ID | {entityType.Id} | {entityType.ToString()}";
            File.AppendAllLines(GetFullFilePath(DatabaseName), new string[] { record });
        }

        private static Entity CreateEntity(string [] result)
        {
            var entityType = result.LastOrDefault().Trim();
            string[] addressStringArray = result[4].Trim().Split('-');
            Address address = new Address(addressStringArray[0], addressStringArray[1], addressStringArray[2], addressStringArray[3]);
            if (entityType == "Person")
            {
                return CreatePerson(result, address);
            }
            else
            {
                return CreateBusiness(result, address);
            }
        }
     
        private static Person CreatePerson(string [] stringResult, Address address)
        {
            string Id = stringResult[1].Trim().ToString();
            string firstName = stringResult[2].Trim();
            string lastName = stringResult[3].Trim();
            
            Person person = new Person(firstName, lastName, address);
            person.Id = Id;
            return person;
        }

        private static Business CreateBusiness(string[] stringResult, Address address)
        {
            Business business = new Business(stringResult[2], address);
            business.Id = stringResult[1].Trim().ToString();
            return business;
        }

        private static string GetFullFilePath(string fileName)
        {
            string SolutionName = "AllianceInterview.sln";
            //Get name of the target project which we want to test
            
            var projectName = typeof(Entity).GetTypeInfo().Assembly.GetName().Name;

            //Get currently executing test project path
            var applicationBasePath = new Uri((typeof(Entity).GetTypeInfo().Assembly.CodeBase)).LocalPath;
            //Find the folder which contains the solution file. We then use this information to find the 
            //target project which we want to test
            DirectoryInfo directoryInfo = new DirectoryInfo(applicationBasePath);
            do
            {
                var solutionFileInfo = new FileInfo(Path.Combine(directoryInfo.FullName, SolutionName));
                if (solutionFileInfo.Exists)
                {
                   return Path.GetFullPath(Path.Combine(directoryInfo.FullName, projectName,"Database", fileName));
                }
                directoryInfo = directoryInfo.Parent;
            }
            while (directoryInfo.Parent != null);

            throw new Exception($"Solution root could not be located using application root {applicationBasePath}");
        }
    }
}
