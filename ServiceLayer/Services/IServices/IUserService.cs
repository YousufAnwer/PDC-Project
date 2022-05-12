using DataAccessLayer.Dtos.UserDtos;
using DataAccessLayer.Models;
using System.Collections.Generic;

namespace ServiceLayer.Services.IServices
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User Get(int Id);
        User GetByNameAndPassword(LoginUserDto dto);
        void Insert(User User);
        void Delete(int Id);
        void Update(User User);
    }
}
