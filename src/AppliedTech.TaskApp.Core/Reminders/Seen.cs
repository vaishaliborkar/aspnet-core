using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppliedTech.TaskApp.Reminders
{
    [Table("AppSeen")]
    public class Seen : FullAuditedEntity<long>
    {
        public const int MaxRemarkLength = 256;

        [ForeignKey(nameof(ReminderId))]
        public Reminder AssignedReminder { get; set; }
        public long? ReminderId { get; set; }

        [MaxLength(MaxRemarkLength)]
        public string Remark { get; set; }

        public Seen()
        {

        }

        public Seen(string remark, long? reminderId = null)
          : this()
        {
            Remark = remark;
            ReminderId = reminderId;
        }

    }
}
