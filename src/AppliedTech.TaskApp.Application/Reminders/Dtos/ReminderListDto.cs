using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppliedTech.TaskApp.Reminders.Dtos
{
    [AutoMapFrom(typeof(Reminder))]
    public class ReminderListDto : FullAuditedEntityDto
    {
        public string Message { get; set; }
        public DateTime ReminderDateTime { get; set; }
    }
}
