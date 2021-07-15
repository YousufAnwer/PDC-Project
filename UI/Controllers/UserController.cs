using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var listOfUser = _userService.GetAll();
            return View(listOfUser);
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


    }
}
