using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppliedTech.TaskApp.Reminders.Dtos
{
    [AutoMapTo(typeof(Reminder))]
    public class UpdateReminderInput
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(Reminder.MaxMessageLength)]
        public string Message { get; set; }

        public DateTime ReminderDateTime { get; set; }
    }
}
