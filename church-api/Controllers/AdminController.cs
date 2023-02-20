using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using church_models.Entities;
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

        [HttpPost("saveProject")]
        public async Task<IActionResult> SaveProject([FromBody] Project project)
        {
            await _adminService.SaveProject(project);
            return Ok(true);
        }

        [HttpGet("getProjects")]
        public async Task<IActionResult> GetProjects(string? searchText)
        {
            var projects = await _adminService.GetProjects(searchText);
            return Ok(projects);
        }

        [HttpGet("getProject/{id}")]
        public async Task<IActionResult> GetProjects(int id)
        {
            var project = await _adminService.GetProject(id);
            return Ok(project);
        }

        [HttpPut("updateProject")]
        public async Task<IActionResult> UpdateProject(Project project)
        {
            await _adminService.UpdateProject(project);
            return Ok(true);
        }

        [HttpDelete("deleteProjects")]
        public async Task<IActionResult> DeleteProjects(List<int> projectIds)
        {
            await _adminService.DeleteProjects(projectIds);
            return Ok(true);
        }
    }
}

