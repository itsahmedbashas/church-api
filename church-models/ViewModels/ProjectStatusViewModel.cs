using System;
namespace church_models.ViewModels
{
	public class ProjectStatusViewModel
	{
        public int ProjectStatusId { get; set; }

        public string ProjectStatusName { get; set; } = string.Empty;

        public string ProjectStatusDesc { get; set; } = string.Empty;
    }
}

