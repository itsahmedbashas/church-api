using System;
using System.ComponentModel.DataAnnotations;

namespace church_models.ViewModels
{
	public class ApplyingEntityViewModel
	{
		public ApplyingEntityViewModel()
		{
		}

        public int ApplyingEntityId { get; set; }

        public string ApplyingEntityName { get; set; } = string.Empty;

        public string ApplyingEntityDesc { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }
    }
}

