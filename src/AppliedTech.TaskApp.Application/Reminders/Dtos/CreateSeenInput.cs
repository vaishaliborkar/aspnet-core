using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppliedTech.TaskApp.Reminders.Dtos
{
    [AutoMapTo(typeof(Seen))]
    public class CreateSeenInput
    {
        public long? ReminderId { get; set; }

        [MaxLength(Seen.MaxRemarkLength)]
        public string Remark { get; set; }
    }
}
