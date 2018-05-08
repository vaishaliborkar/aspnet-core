using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using AppliedTech.TaskApp.Tasks.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedTech.TaskApp.Tasks
{
    public class TaskAppService : TaskAppAppServiceBase, ITaskAppService
    {
        private readonly IRepository<Task> _taskRepository;

        public TaskAppService(IRepository<Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input)
        {
            var tasks = await _taskRepository
                .GetAll()
                .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<TaskListDto>(
                ObjectMapper.Map<List<TaskListDto>>(tasks)
            );
        }

        public async System.Threading.Tasks.Task Create(CreateTaskInput input)
        {
            var task = ObjectMapper.Map<Task>(input);
            await _taskRepository.InsertAsync(task);
        }
    }
}
