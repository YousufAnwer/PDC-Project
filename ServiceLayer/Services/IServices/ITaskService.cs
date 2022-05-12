using DataAccessLayer.Dtos.TaskDtos;
using DataAccessLayer.Models;
using System.Collections.Generic;

namespace ServiceLayer.Services.IServices
{
    public interface ITaskService
    {
        IEnumerable<Task> GetAll();
        Task Get(int Id);
        List<Task> GetByUserId(int Id);
        void Insert(Task Task);
        void Delete(int Id);
        void Update(Task Task);
    }
}
