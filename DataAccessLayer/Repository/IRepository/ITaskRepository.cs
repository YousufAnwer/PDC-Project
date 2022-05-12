using DataAccessLayer.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Repository.IRepository
{
    public interface ITaskRepository
    {
        IEnumerable<Task> GetAll();
        Task Get(int Id);
        List<Task> GetByUserId(int Id);
        void Insert(Task User);
        void Delete(int Id);
        void Update(Task User);
        void Save();
    }
}
