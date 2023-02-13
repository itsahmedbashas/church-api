using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using church_models.Shared;
using church_services;
using Microsoft.AspNetCore.Mvc;

namespace church_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAdminLookUps([Required] int id, string? searchText)
        {
            var adminMenu = (AdminMenus)id;
            switch (adminMenu)
            {
                case AdminMenus.ApplicantCommunity:
                    return Ok(await _adminService.GetApplicantCommunity(searchText));

                case AdminMenus.ApplyingEntity:
                    return Ok(await _adminService.GetApplyingEntity(searchText));

                case AdminMenus.CompletionStatus:
                    return Ok(await _adminService.GetCompletionStatus(searchText));

                case AdminMenus.ProjectStatus:
                    return Ok(await _adminService.GetProjectStatus(searchText));

                case AdminMenus.ProjectTypes:
                    return Ok(await _adminService.GetProjectTypes(searchText));

                default:
                    break;

            }

            return Ok(null);
        }

        [HttpPost]
        public async Task<IActionResult> SaveAdminLookup(AdminLookup adminLookup)
        {
            await _adminService.SaveOrUpdateAdminLookupBasedOnType(adminLookup);
            return Ok(true);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAdminLookup(AdminLookup adminLookup)
        {
            await _adminService.SaveOrUpdateAdminLookupBasedOnType(adminLookup);
            return Ok(true);
        }

        [HttpDelete("{lookupid}/{id}")]
        public async Task<IActionResult> DeleteAdminLookup(int lookupid, int id)
        {
            await _adminService.DeleteAdminLookup(lookupid, id);
            return Ok(true);
        }
    }
}

