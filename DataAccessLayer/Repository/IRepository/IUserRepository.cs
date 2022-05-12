using DataAccessLayer.Dtos.UserDtos;
using DataAccessLayer.Models;
using System.Collections.Generic;

namespace DataAccessLayer.Repository.IRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User Get(int Id);
        User GetByNameAndPassword(LoginUserDto dto);
        void Insert(User User);
        void Delete(int Id);
        void Update(User User);
        void Save();
    }
}
