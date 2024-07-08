using Api.Data;
using Api.Entities;
using Api.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Api.Controllers;

[ApiController]
public class FileManagerController : ControllerBase
{

    private readonly IFileRepo _iFileRepo;
    private readonly ICurrentUserService _currentUserService;
    private readonly UserManager<UserEntity> _userManager;
    private readonly ApplicationContext _context;


    public FileManagerController(
        IFileRepo iFileRepo, 
        ICurrentUserService currentUserService, 
        UserManager<UserEntity> userManager,
        ApplicationContext context
    )
    {
        _iFileRepo = iFileRepo;
        _currentUserService = currentUserService;
        _userManager = userManager;
        _context = context;
    }
    [Authorize]
    [HttpPost]
    [Route("uploadingtodb")]
    public async Task<IActionResult> UploadFiletoDb(IFormFile file)
    {
            var userId = _currentUserService.UserId;

            using (var stream = file.OpenReadStream())
            {
                var result = await _iFileRepo.UploadFileToDatabaseAsync(file.FileName, stream, userId);
                return Ok(result);
            }
    }

    // [Authorize]
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

    [HttpGet]
    [Route("/all-files")]

    public async Task<ActionResult> GetAll()
    {
        var files = await _context.Materials.ToListAsync();
        return Ok(files);
    }
}