using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repository.IRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User Get(int Id);
        void Insert(User User);
        void Delete(int Id);
        void Update(User User);
        void Save();
    }
}
