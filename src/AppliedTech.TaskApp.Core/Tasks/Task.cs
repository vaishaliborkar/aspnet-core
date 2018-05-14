﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using AppliedTech.TaskApp.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppliedTech.TaskApp.Tasks
{
    [Table("AppTasks")]
    public class Task : Entity, IHasCreationTime
    {

        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB

        [ForeignKey(nameof(AssignedPersonId))]
        public Person AssignedPerson { get; set; }
        public Guid? AssignedPersonId { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }

        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }



        public Task()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;
        }

        public Task(string title, string description = null, Guid? assignedPersonId = null)
            : this()
        {
            Title = title;
            Description = description;
            AssignedPersonId = assignedPersonId;
        }

    }
}
