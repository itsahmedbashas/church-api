using System;
using System.ComponentModel.DataAnnotations;

namespace church_models.ViewModels
{
	public class CompletionStatusViewModel
	{
		public CompletionStatusViewModel()
		{
		}

        public int CompletionStatusId { get; set; }

        public string CompletionStatusName { get; set; } = string.Empty;

        public string CompletionStatusDesc { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }
    }
}

