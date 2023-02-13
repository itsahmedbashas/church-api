using System;
using System.ComponentModel.DataAnnotations;

namespace church_models.Entities
{
    public class ApplyingEntity
    {
        public ApplyingEntity()
        {
        }

        [Key]
        public int ApplyingEntityId { get; set; }

        [Required]
        public string ApplyingEntityName { get; set; } = string.Empty;

        public string? ApplyingEntityDesc { get; set; } = string.Empty;

        public bool? IsDeleted { get; set; }
    }
}

