using System;
using System.ComponentModel.DataAnnotations;

namespace church_models.Entities
{
    public class ProjectType
    {
        public ProjectType()
        {
        }

        [Key]
        public int ProjectTypeId { get; set; }

        [Required]
        public string ProjectTypeName { get; set; } = string.Empty;

        public string? ProjectTypeDesc { get; set; } = string.Empty;

        public bool? IsDeleted { get; set; }
    }
}

