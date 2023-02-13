using System;
using System.Collections;
using church_models.Entities;
using church_models.Shared;

namespace church_services
{
    public interface IAdminService
    {
        //Get LKPs
        public Task<List<ProjectStatus>> GetProjectStatus(string searchText);

        public Task<List<ProjectType>> GetProjectTypes(string searchText);

        public Task<List<CompletionStatus>> GetCompletionStatus(string searchText);

        public Task<List<ApplyingEntity>> GetApplyingEntity(string searchText);

        public Task<List<ApplicantCommunity>> GetApplicantCommunity(string searchText);

        //Save LKPs
        public Task SaveOrUpdateAdminLookupBasedOnType(AdminLookup adminLookup);

        // Delete LKPs
        public Task DeleteAdminLookup(int lookupId, int id);
    }
}

