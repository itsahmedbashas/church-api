using System;
using church_models.Entities;

namespace church_repos
{
    public interface IAdminRepo
    {
        // Get LkPs
        public Task<List<ProjectStatus>> GetProjectStatus(string searchText);
        public Task<List<ProjectType>> GetProjectTypes(string searchText);
        public Task<List<CompletionStatus>> GetCompletionStatus(string searchText);
        public Task<List<ApplyingEntity>> GetApplyingEntity(string searchText);
        public Task<List<ApplicantCommunity>> GetApplicantCommunity(string searchText);
        // Save LKPs
        public Task SaveProjectStatus(ProjectStatus projectStatus);
        public Task SaveProjectTypes(ProjectType projectType);
        public Task UpdateProjectStatus(ProjectStatus projectStatus);
        public Task UpdateProjectTypes(ProjectType projectType);
        public Task SaveCompletionStatus(CompletionStatus completionStatus);
        public Task UpdateCompletionStatus(CompletionStatus completionStatus);
        public Task SaveApplyingEntity(ApplyingEntity applyingEntity);
        public Task UpdateApplyingEntity(ApplyingEntity applyingEntity);
        public Task SaveApplicantCommunity(ApplicantCommunity applicantCommunity);
        public Task UpdateApplicantCommunity(ApplicantCommunity applicantCommunity);
        // Delete LKPs
        public Task DeleteProjectStatus(int id);
        public Task DeleteProjectType(int id);
        public Task DeleteCompletionStatus(int id);
        public Task DeleteApplicantCommunity(int id);
        public Task DeleteApplyingEntity(int id);

        // Project Related
        // Save Project
        public Task SaveProject(Project project);
        public Task<List<Project>> GetProjects(string searchText);
        public Task<Project> GetProject(int projectId);
        public Task UpdateProject(Project project);
    }
}

