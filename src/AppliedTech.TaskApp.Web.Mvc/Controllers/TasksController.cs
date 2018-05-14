using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AppliedTech.TaskApp.Common;
using AppliedTech.TaskApp.Controllers;
using AppliedTech.TaskApp.Tasks;
using AppliedTech.TaskApp.Tasks.Dtos;
using AppliedTech.TaskApp.Web.Models.People;
using AppliedTech.TaskApp.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppliedTech.TaskApp.Web.Mvc.Controllers
{
    public class TasksController : TaskAppControllerBase
    {
        private readonly ITaskAppService _taskAppService;
        private readonly ILookupAppService _lookupAppService;

        public TasksController(ITaskAppService taskAppService, ILookupAppService lookupAppService)
        {
            _taskAppService = taskAppService;
            _lookupAppService = lookupAppService;
        }

        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items)
            {
                SelectedTaskState = input.State
            };
            return View(model);
        }

        public async Task<ActionResult> Create()
        {
            var peopleSelectListItems = (await _lookupAppService.GetPeopleComboboxItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            peopleSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("Unassigned"), Selected = true });

            return View(new CreateTaskViewModel(peopleSelectListItems));
        }
    }
}