using DataAccessLayer.Dtos.UserDtos;
using DataAccessLayer.Models;
using DataAccessLayer.Repository.IRepository;
using ServiceLayer.Services.IServices;
using System;
using System.Collections.Generic;

namespace ServiceLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Delete(int Id)
        {
            _userRepository.Delete(Id);

        }

        public User Get(int Id)
        {
            return _userRepository.Get(Id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetByNameAndPassword(LoginUserDto dto)
        {
            var user = _userRepository.GetByNameAndPassword(dto);
            if (user==null)
            {
                throw new NullReferenceException("User Not Found");
            }
            else
            {
                return user;
            }
            
        }

        public void Insert(User User)
        {
            _userRepository.Insert(User);
        }

        public void Update(User User)
        {
            _userRepository.Update(User);
        }
    }
}
