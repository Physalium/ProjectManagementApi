﻿using Domain.Entities;
using MediatR;
using ProjectManagement.Core.Base.Mappings;
using System;

namespace ProjectManagement.Core.UseCases.Projects.Commands.UpdateProject
{
    public class UpdateProjectCommand : IRequest<UpdateProjectCommandResponse>, IMapFrom<Project>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TargetDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }

        public static void Mapping(MappingProfile profile)
        {
            profile.CreateMap<UpdateProjectCommand, Project>();
        }
    }
}