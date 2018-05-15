using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppliedTech.TaskApp.Reminders
{
    [Table("AppReminders")]
    public class Reminder : FullAuditedEntity<long>
    {
        public const int MaxMessageLength = 64 * 1024; //64KB

        [Required]
        [MaxLength(MaxMessageLength)]
        public string Message { get; set; }

        public DateTime ReminderDateTime { get; set; }

        public Reminder()
        {
            ReminderDateTime = Clock.Now;
        }
        public Reminder(string message, DateTime reminderDateTime)
        {
            Message = message;
            ReminderDateTime = reminderDateTime;
        }

    }
}
