using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;
        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Task> GetAll()
        {
            var data = _context.AppTask.ToList().OrderByDescending(x=>x.Id);
            return data;
        }
        public Task Get(int id)
        {
            return _context.AppTask.Find(id);
        }
        public void Insert(Task Task)
        {
            _context.AppTask.Add(Task);
            Save();
        }
        public void Delete(int TaskID)
        {
            Task Task = _context.AppTask.Find(TaskID);
            _context.AppTask.Remove(Task);
            Save();
        }
        public void Update(Task Task)
        {
            _context.Entry(Task).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public List<Task> GetByUserId(int Id)
        {
            var list = _context.AppTask.Where(x => x.UserId == Id).ToList();
            return list;
        }

        //public Task GetByNameAndPassword(LoginTaskDto dto)
        //{
        //    var Task = _context.AppTask.FirstOrDefault(x => x.Name == dto.Name && x.Password == dto.Password);
        //    return Task;

        //}
    }
}
