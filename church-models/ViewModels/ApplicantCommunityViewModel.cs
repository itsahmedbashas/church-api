using System;
using System.ComponentModel.DataAnnotations;

namespace church_models.ViewModels
{
	public class ApplicantCommunityViewModel
	{
		public ApplicantCommunityViewModel()
		{
		}

        public int ApplicantCommunityId { get; set; }

        public string ApplicantCommunityName { get; set; } = string.Empty;

        public string ApplicantCommunityDesc { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }
    }
}

