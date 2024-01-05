using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AdminController : BaseApiController
    {
        [Authorize(Policy = "RequireAdminRole")]
        [HttpGet("users-with-roles")]
        public ActionResult GetUsersWithRoles() 
        {
            return Ok("Only Admins Can See This!!");
        }

        [Authorize(Policy = "ModeratePhotoRole")]
        [HttpGet("photos-to-moderate")]
        public ActionResult GetPhotosForModeration() 
        {
            return Ok("Admins or Moderators Can See This!!");
        }
    }
}