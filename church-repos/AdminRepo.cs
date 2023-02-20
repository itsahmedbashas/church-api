using System;
using church_database;
using church_models.Entities;
using Microsoft.EntityFrameworkCore;

namespace church_repos
{
    public class AdminRepo : IAdminRepo
    {
        private readonly DataContext _context;

        public AdminRepo(DataContext context)
        {
            _context = context;
        }


        public async Task<List<ProjectStatus>> GetProjectStatus(string searchText)
        {
            if (!String.IsNullOrEmpty(searchText))
            {
                var res = await _context.ProjectStatus.Where(status => status.ProjectStatusName.ToLower().StartsWith(searchText.ToLower())).ToListAsync();
                return res;
            }
            else
            {
                return await _context.ProjectStatus.ToListAsync();
            }
        }

        public async Task<List<ProjectType>> GetProjectTypes(string searchText)
        {
            if (!String.IsNullOrEmpty(searchText))
            {
                var res = await _context.ProjectTypes.Where(status => status.ProjectTypeName.ToLower().StartsWith(searchText.ToLower())).ToListAsync();
                return res;
            }
            else
            {
                return await _context.ProjectTypes.ToListAsync();
            }
        }

        public async Task<List<CompletionStatus>> GetCompletionStatus(string searchText)
        {
            if (!String.IsNullOrEmpty(searchText))
            {
                var res = await _context.CompletionStatus.Where(status => status.CompletionStatusName.ToLower().StartsWith(searchText.ToLower())).ToListAsync();
                return res;
            }
            else
            {
                return await _context.CompletionStatus.ToListAsync();
            }
        }

        public async Task<List<ApplyingEntity>> GetApplyingEntity(string searchText)
        {
            if (!String.IsNullOrEmpty(searchText))
            {
                var res = await _context.ApplyingEntity.Where(status => status.ApplyingEntityName.ToLower().StartsWith(searchText.ToLower())).ToListAsync();
                return res;
            }
            else
            {
                return await _context.ApplyingEntity.ToListAsync();
            }
        }

        public async Task<List<ApplicantCommunity>> GetApplicantCommunity(string searchText)
        {
            if (!String.IsNullOrEmpty(searchText))
            {
                var res = await _context.ApplicantCommunity.Where(status => status.ApplicantCommunityName.ToLower().StartsWith(searchText.ToLower())).ToListAsync();
                return res;
            }
            else
            {
                return await _context.ApplicantCommunity.ToListAsync();
            }
        }

        /// <summary>
        /// Method to save Project Status
        /// </summary>
        /// <param name="projectStatus"></param>
        public async Task SaveProjectStatus(ProjectStatus projectStatus)
        {
            _context.ProjectStatus.Add(projectStatus);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Method to save Project Types
        /// </summary>
        /// <param name="projectType"></param>
        public async Task SaveProjectTypes(ProjectType projectType)
        {
            _context.ProjectTypes.Add(projectType);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Save Completion Status
        /// </summary>
        /// <param name="completionStatus"></param>
        /// <returns></returns>
        public async Task SaveCompletionStatus(CompletionStatus completionStatus)
        {
            _context.CompletionStatus.Add(completionStatus);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Save Applyting Entity
        /// </summary>
        /// <param name="applyingEntity"></param>
        /// <returns></returns>
        public async Task SaveApplyingEntity(ApplyingEntity applyingEntity)
        {
            _context.ApplyingEntity.Add(applyingEntity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Save Applicant Community
        /// </summary>
        /// <param name="applicantCommunity"></param>
        /// <returns></returns>
        public async Task SaveApplicantCommunity(ApplicantCommunity applicantCommunity)
        {
            _context.ApplicantCommunity.Add(applicantCommunity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update Project Status
        /// </summary>
        /// <param name="projectStatus"></param>
        /// <returns></returns>
        public async Task UpdateProjectStatus(ProjectStatus projectStatus)
        {
            _context.ProjectStatus.Update(projectStatus);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update Project Types
        /// </summary>
        /// <param name="projectType"></param>
        /// <returns></returns>
        public async Task UpdateProjectTypes(ProjectType projectType)
        {
            _context.ProjectTypes.Update(projectType);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update Completion Status
        /// </summary>
        /// <param name="completionStatus"></param>
        /// <returns></returns>
        public async Task UpdateCompletionStatus(CompletionStatus completionStatus)
        {
            _context.CompletionStatus.Update(completionStatus);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update Applying Entity
        /// </summary>
        /// <param name="applyingEntity"></param>
        /// <returns></returns>
        public async Task UpdateApplyingEntity(ApplyingEntity applyingEntity)
        {
            _context.ApplyingEntity.Update(applyingEntity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update Applicant Community
        /// </summary>
        /// <param name="applicantCommunity"></param>
        /// <returns></returns>
        public async Task UpdateApplicantCommunity(ApplicantCommunity applicantCommunity)
        {
            _context.ApplicantCommunity.Update(applicantCommunity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete Project Status
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteProjectStatus(int id)
        {
            var projectStatus = await _context.ProjectStatus.Where(status => status.ProjectStatusId.Equals(id)).FirstOrDefaultAsync();
            if (projectStatus != null)
            {
                _context.ProjectStatus.Remove(projectStatus);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Delete Project Types
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteProjectType(int id)
        {
            var projectType = await _context.ProjectTypes.Where(type => type.ProjectTypeId.Equals(id)).FirstOrDefaultAsync();
            if (projectType != null)
            {
                _context.ProjectTypes.Remove(projectType);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Delete Completion Status
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteCompletionStatus(int id)
        {
            var completionStatus = await _context.CompletionStatus.Where(type => type.CompletionStatusId.Equals(id)).FirstOrDefaultAsync();
            if (completionStatus != null)
            {
                _context.CompletionStatus.Remove(completionStatus);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Delete Applying Entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteApplyingEntity(int id)
        {
            var applyingEntity = await _context.ApplyingEntity.Where(type => type.ApplyingEntityId.Equals(id)).FirstOrDefaultAsync();
            if (applyingEntity != null)
            {
                _context.ApplyingEntity.Remove(applyingEntity);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Delete Applicant Community
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteApplicantCommunity(int id)
        {
            var applicantCommunity = await _context.ApplicantCommunity.Where(type => type.ApplicantCommunityId.Equals(id)).FirstOrDefaultAsync();
            if (applicantCommunity != null)
            {
                _context.ApplicantCommunity.Remove(applicantCommunity);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Saving Projects Data
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async Task SaveProject(Project project)
        {
            // create and assign Project Number while saving
            var projNumber = _context.Projects.Count() + 1;
            project.ProjectNumber = $"OFM-{projNumber}";

            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Get Projects
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public async Task<List<Project>> GetProjects(string searchText)
        {
            var projects = _context.Projects
                    .Include(p => p.ProjectStatus)
                    .Include(p => p.ProjectType)
                    .Include(p => p.CompletionStatus);


            if (!String.IsNullOrEmpty(searchText))
            {
                return await projects.Where(pro => pro.ProjectTitle.ToLower()
                    .Equals(searchText.ToLower())).ToListAsync();
            }
            else
            {
                return await projects.ToListAsync();
            }
        }

        /// <summary>
        /// Get Single Project Based on ID
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<Project> GetProject(int projectId)
        {
            var project = await _context.Projects.Where(proj => proj.ProjectId.Equals(projectId)).FirstOrDefaultAsync();

            if (project == null)
                throw new ArgumentException();

            return project;

        }

        /// <summary>
        /// Update Project
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async Task UpdateProject(Project project)
        {
            var result = await _context.Projects.Where(proj => proj.ProjectId.Equals(project.ProjectId)).AsNoTracking().FirstOrDefaultAsync();
            if (project == null)
                throw new ArgumentException();

            _context.Update(project);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete Projects
        /// </summary>
        /// <param name="projectIds"></param>
        /// <returns></returns>
        public async Task DeleteProjects(List<int> projectIds)
        {
            var projectsBasedOnIds = await _context.Projects.Where(proj => projectIds.Contains(proj.ProjectId)).ToListAsync();

            if (projectsBasedOnIds != null && projectsBasedOnIds.Count > 0)
            {
                _context.RemoveRange(projectsBasedOnIds);
                await _context.SaveChangesAsync();
            }
        }
    }
}

