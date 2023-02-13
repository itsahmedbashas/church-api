using System;
using System.ComponentModel.DataAnnotations;

namespace church_models.ViewModels
{
	public class ProjectTypeViewModel
	{
		public ProjectTypeViewModel()
		{
		}

        public int ProjectTypeId { get; set; }

        public string ProjectTypeName { get; set; } = string.Empty;

        public string ProjectTypeDesc { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }
    }
}

