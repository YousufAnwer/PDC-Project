using DataAccessLayer.Models;
using DataAccessLayer.Repository.IRepository;
using ServiceLayer.Services.IServices;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _TaskRepository;
        public TaskService(ITaskRepository TaskRepository)
        {
            _TaskRepository = TaskRepository;
        }
        public void Delete(int Id)
        {
            _TaskRepository.Delete(Id);

        }

        public Task Get(int Id)
        {
            return _TaskRepository.Get(Id);
        }

        public IEnumerable<Task> GetAll()
        {
            return _TaskRepository.GetAll();
        }

        public List<Task> GetByUserId(int Id)
        {
            var data = _TaskRepository.GetAll().Where(x => x.UserId == Id).ToList();
           
           return data;
        }

        //public Task GetByNameAndPassword(LoginTaskDto dto)
        //{
        //    var Task = _TaskRepository.GetByNameAndPassword(dto);
        //    if (Task==null)
        //    {
        //        throw new NullReferenceException("Task Not Found");
        //    }
        //    else
        //    {
        //        return Task;
        //    }

        //}

        public void Insert(Task Task)
        {
            _TaskRepository.Insert(Task);
        }

        public void Update(Task Task)
        {
            _TaskRepository.Update(Task);
        }
    }

    //public class Task2Service:ITaskService
}
