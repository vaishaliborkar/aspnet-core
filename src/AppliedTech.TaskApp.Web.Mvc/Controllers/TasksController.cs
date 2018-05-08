using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppliedTech.TaskApp.Controllers;
using AppliedTech.TaskApp.Tasks;
using AppliedTech.TaskApp.Tasks.Dtos;
using AppliedTech.TaskApp.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppliedTech.TaskApp.Web.Mvc.Controllers
{
    public class TasksController : TaskAppControllerBase
    {
        private readonly ITaskAppService _taskAppService;
        public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items);
            return View(model);
        }
    }
}