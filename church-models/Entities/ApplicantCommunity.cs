using System;
using System.ComponentModel.DataAnnotations;

namespace church_models.Entities
{
    public class ApplicantCommunity
    {
        public ApplicantCommunity()
        {
        }

        [Key]
        public int ApplicantCommunityId { get; set; }

        [Required]
        public string ApplicantCommunityName { get; set; } = string.Empty;

        public string? ApplicantCommunityDesc { get; set; } = string.Empty;

        public bool? IsDeleted { get; set; }
    }
}

