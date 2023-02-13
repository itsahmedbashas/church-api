using System;
using System.ComponentModel.DataAnnotations;

namespace church_models.Entities
{
    public class CompletionStatus
    {
        public CompletionStatus()
        {
        }

        [Key]
        public int CompletionStatusId { get; set; }

        [Required]
        public string CompletionStatusName { get; set; } = string.Empty;

        public string? CompletionStatusDesc { get; set; } = string.Empty;

        public bool? IsDeleted { get; set; }
    }
}

