﻿using ProjectManagement.Core.UseCases.Projects.Dto;
using System.Collections.Generic;

namespace ProjectManagement.Core.UseCases.Projects.Queries.GetProjects
{
    public class ProjectVm
    {
        public IList<ProjectDto> ProjectList { get; set; }
        public int Count { get; set; }
    }
}
