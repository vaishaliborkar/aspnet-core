using Abp.Application.Services.Dto;
using AppliedTech.TaskApp.Reminders.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppliedTech.TaskApp.Reminders
{
    public interface IReminderAppService
    {
        Task<ListResultDto<ReminderListDto>> GetById(long userId);

        Task Create(CreateReminderInput input);

        Task CreateSeen(CreateSeenInput input);
    }

}
