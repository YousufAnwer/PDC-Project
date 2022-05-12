using DataAccessLayer.Dtos.UserDtos;
using DataAccessLayer.Helper;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ServiceLayer.Services.IServices;
using System.Linq;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
      

        public UserController(IUserService userService )
        {
            _userService = userService;
           
        }
        [HttpGet]
        public IActionResult Index()
        {
         
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginUserDto dto)
        {
            var user=_userService.GetByNameAndPassword(dto);
            if (user!=null)
            {
                GolobalConfig.CurrentUserId = user.Id;

                // TempData["list"] = listOfTask.ToList();
               // new { json = JsonConvert.SerializeObject(listOfTask) }
                return RedirectToAction("Dashboard", "Task");
            }
           

            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(User u)
        {
            _userService.Insert(u);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult LogOut()
        {
           
            return NotFound();
        }


    }
}
