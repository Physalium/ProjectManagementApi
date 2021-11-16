﻿using System;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using ProjectManagement.Core.Base.Mappings;

namespace ProjectManagement.Core.UseCases.Tasks.Commands.CreateTask
{
    public class CreateTaskCommand : IRequest<CreateTaskCommandResponse>, IMapFrom<Task>
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public TaskPriority TaskPriority { get; set; }
        public TaskStatus TaskStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TargetDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public bool IsActive { get; set; }
        
        public int StepId { get; set; }
        
        /*public ICollection<Oversee> Oversees { get; set; }
        public ICollection<Assign> Assigns { get; set; }
        public ICollection<TaskChange> TaskChanges { get; set; }*/

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<CreateTaskCommand, Task>();
        }
    }
}