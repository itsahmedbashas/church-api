using System;
using System.ComponentModel.DataAnnotations;

namespace church_models.Entities
{
    public class ProjectStatus
    {
        [Key]
        public int ProjectStatusId { get; set; }

        [Required]
        public string ProjectStatusName { get; set; } = string.Empty;

        public string? ProjectStatusDesc { get; set; } = string.Empty;

        public bool? IsDeleted { get; set; }
    }
}

