using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace church_models.Entities
{
    public class Project
    {
        public Project()
        {
        }

        [Key]
        public int ProjectId { get; set; }

        public string ProjectNumber { get; set; }

        public string ProjectTitle { get; set; }

        public string ApplicationDate { get; set; }

        public string? DesiredDate { get; set; }

        public string? EstimatedEndOfProject { get; set; }

        [ForeignKey("ProjectType")]
        public int ProjectTypeId { get; set; }
        public ProjectType? ProjectType { get; set; }

        [ForeignKey("ProjectStatus")]
        public int ProjectStatusId { get; set; }
        public ProjectStatus? ProjectStatus { get; set; }

        [ForeignKey("ApplyingEntity")]
        public int ApplyingEntityId { get; set; }
        public ApplyingEntity? ApplyingEntity { get; set; }

        public string ApplicantName { get; set; }

        [ForeignKey("ApplicantCommunity")]
        public int ApplicantCommunityId { get; set; }
        public ApplicantCommunity? ApplicantCommunity { get; set; }

        public string? ApplicantInstitution { get; set; }

        public string ApplicantEmailId { get; set; }

        public int TotalProjectCost { get; set; }

        public int? LocalContribution { get; set; }

        public int? AmountToBeAppliedForAgencies { get; set; }

        public string? ProjectCompletionDate { get; set; }

        [ForeignKey("CompletionStatus")]
        public int? CompletionStatusId { get; set; }
        public CompletionStatus? CompletionStatus { get; set; }

        public string? Remarks { get; set; }
    }
}

