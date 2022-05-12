using DataAccessLayer.Dtos.TaskDtos;
using DataAccessLayer.Helper;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ServiceLayer.Services;
using ServiceLayer.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UI.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
           // _taskService = new TaskService(null);
        }
        [HttpGet]
        public IActionResult Dashboard()
        {
            var listOfTask = _taskService.GetByUserId(GolobalConfig.CurrentUserId);
          //  var listOfBrands = JsonConvert.DeserializeObject<List<Task>>(json);
            return View(listOfTask);
        }

        [HttpPost]
        public IActionResult Dashboard(Task obj)
        {
            _taskService.Insert(obj);
            return RedirectToAction("Dashboard");
        }
       [HttpPost]
        public IActionResult Delete( TaskDto dto)
        {
            _taskService.Delete(dto.Id);
            return RedirectToAction("Dashboard");
        }


    }
}
