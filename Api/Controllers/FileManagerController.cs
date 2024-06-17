using System.Security.Claims;
using Api.Entities;
using Api.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace Api.Controllers
{
    [ApiController]
    public class FileManagerController : ControllerBase
    {

        private readonly IFileRepo _iFileRepo;
        private readonly ICurrentUserService _currentUserService;
        private readonly UserManager<UserEntity> _userManager;

        public FileManagerController(IFileRepo iFileRepo, ICurrentUserService currentUserService, UserManager<UserEntity> userManager)
        {
            _iFileRepo = iFileRepo;
            _currentUserService = currentUserService;
            _userManager = userManager;
        }
        [Authorize]
        [HttpPost]
        [Route("uploadingtodb")]
        public async Task<IActionResult> UploadFiletoDb(IFormFile file)
        {
            try
            {
                // var userId = "58a2bdfe-ceb8-4f72-b9cf-4fb7f508fa06";
                // var user = await _userManager.FindByEmailAsync(User.FindFirstValue(ClaimTypes.Email));
                // var userId = user.Id;

                var userId = _currentUserService.UserId;

                // if (file == null || string.IsNullOrEmpty(userId))
                // {
                //     return BadRequest("File or userId is missing");
                //

                using (var stream = file.OpenReadStream())
                {
                    var result = await _iFileRepo.UploadFileToDatabaseAsync(file.FileName, stream, userId);
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                // return StatusCode(500, $"Internal server error: {ex.Message}");
                Console.WriteLine(ex);
            }
            return Ok("success");
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("download/{materialId}")]
        public async Task<IActionResult> DownloadFile(int materialId)
        {
            try
            {
                var material = await _iFileRepo.Download(materialId);
                if (material == null)
                {
                    return NotFound();
                }
                return File(material.FileContent, "application/octet-stream", material.FileName + material.FileType);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}