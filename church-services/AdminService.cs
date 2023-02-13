using System;
using System.Collections;
using church_models.Entities;
using church_models.Shared;
using church_repos;

namespace church_services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepo _adminRepo;

        public AdminService(IAdminRepo adminRepo)
        {
            _adminRepo = adminRepo;
        }

        /// <summary>
        /// Get Project Status
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public async Task<List<ProjectStatus>> GetProjectStatus(string searchText)
        {
            return await _adminRepo.GetProjectStatus(searchText);
        }

        /// <summary>
        /// Get Project Types
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public async Task<List<ProjectType>> GetProjectTypes(string searchText)
        {
            return await _adminRepo.GetProjectTypes(searchText);
        }

        /// <summary>
        /// Get Completion Status
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public async Task<List<CompletionStatus>> GetCompletionStatus(string searchText)
        {
            return await _adminRepo.GetCompletionStatus(searchText);
        }

        /// <summary>
        /// Get Applying Entity
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public async Task<List<ApplyingEntity>> GetApplyingEntity(string searchText)
        {
            return await _adminRepo.GetApplyingEntity(searchText);
        }

        /// <summary>
        /// Get Applicant Community
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public async Task<List<ApplicantCommunity>> GetApplicantCommunity(string searchText)
        {
            return await _adminRepo.GetApplicantCommunity(searchText);
        }

        /// <summary>
        /// Save or Update Admin Lookup Based on Type
        /// </summary>
        /// <param name="adminLookup"></param>
        /// <returns></returns>
        public async Task SaveOrUpdateAdminLookupBasedOnType(AdminLookup adminLookup)
        {
            // calling relevant save method based on lookup id
            switch ((AdminMenus)adminLookup.LookupId)
            {
                case AdminMenus.ProjectStatus:
                    var projectStatus = new ProjectStatus
                    {
                        ProjectStatusName = adminLookup.Name,
                        ProjectStatusDesc = adminLookup.Desc
                    };

                    if (adminLookup.Id > 0)
                    {
                        projectStatus.ProjectStatusId = adminLookup.Id;
                        await _adminRepo.UpdateProjectStatus(projectStatus);
                    }
                    else
                    {
                        await _adminRepo.SaveProjectStatus(projectStatus);
                    }


                    break;
                case AdminMenus.ProjectTypes:
                    var projectType = new ProjectType
                    {
                        ProjectTypeName = adminLookup.Name,
                        ProjectTypeDesc = adminLookup.Desc
                    };

                    if (adminLookup.Id > 0)
                    {
                        projectType.ProjectTypeId = adminLookup.Id;
                        await _adminRepo.UpdateProjectTypes(projectType);
                    }
                    else
                    {
                        await _adminRepo.SaveProjectTypes(projectType);
                    }

                    break;
                case AdminMenus.CompletionStatus:
                    var completionStatus = new CompletionStatus
                    {
                        CompletionStatusName = adminLookup.Name,
                        CompletionStatusDesc = adminLookup.Desc
                    };

                    if (adminLookup.Id > 0)
                    {
                        completionStatus.CompletionStatusId = adminLookup.Id;
                        await _adminRepo.UpdateCompletionStatus(completionStatus);
                    }
                    else
                    {
                        await _adminRepo.SaveCompletionStatus(completionStatus);
                    }

                    break;
                case AdminMenus.ApplyingEntity:
                    var applyingEntity = new ApplyingEntity
                    {
                        ApplyingEntityName = adminLookup.Name,
                        ApplyingEntityDesc = adminLookup.Desc
                    };

                    if (adminLookup.Id > 0)
                    {
                        applyingEntity.ApplyingEntityId = adminLookup.Id;
                        await _adminRepo.UpdateApplyingEntity(applyingEntity);
                    }
                    else
                    {
                        await _adminRepo.SaveApplyingEntity(applyingEntity);
                    }

                    break;
                case AdminMenus.ApplicantCommunity:
                    var applicantCommunity = new ApplicantCommunity
                    {
                        ApplicantCommunityName = adminLookup.Name,
                        ApplicantCommunityDesc = adminLookup.Desc
                    };

                    if (adminLookup.Id > 0)
                    {
                        applicantCommunity.ApplicantCommunityId = adminLookup.Id;
                        await _adminRepo.UpdateApplicantCommunity(applicantCommunity);
                    }
                    else
                    {
                        await _adminRepo.SaveApplicantCommunity(applicantCommunity);
                    }

                    break;
            }
        }

        /// <summary>
        /// Delete Admin Lookup
        /// </summary>
        /// <param name="lookupId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteAdminLookup(int lookupId, int id)
        {
            switch ((AdminMenus)lookupId)
            {
                case AdminMenus.ProjectStatus:
                    await _adminRepo.DeleteProjectStatus(id);
                    break;
                case AdminMenus.ProjectTypes:
                    await _adminRepo.DeleteProjectType(id);
                    break;
                case AdminMenus.CompletionStatus:
                    await _adminRepo.DeleteCompletionStatus(id);
                    break;
                case AdminMenus.ApplyingEntity:
                    await _adminRepo.DeleteApplyingEntity(id);
                    break;
                case AdminMenus.ApplicantCommunity:
                    await _adminRepo.DeleteApplicantCommunity(id);
                    break;
                default:
                    break;
            }
        }
    }
}

