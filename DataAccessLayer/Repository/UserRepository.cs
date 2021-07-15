using DataAccessLayer.Data;
using DataAccessLayer.Models;
using DataAccessLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetAll()
        {
            return _context.AppUsers.ToList();
        }
        public User Get(int id)
        {
            return _context.AppUsers.Find(id);
        }
        public void Insert(User User)
        {
            _context.AppUsers.Add(User);
            Save();
        }
        public void Delete(int UserID)
        {
            User User = _context.AppUsers.Find(UserID);
            _context.AppUsers.Remove(User);
            Save();
        }
        public void Update(User User)
        {
            _context.Entry(User).State = EntityState.Modified;
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
    }
}
