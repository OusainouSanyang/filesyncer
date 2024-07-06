using Api.Data;
using Api.Entities;
using Api.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository;

public class FileRepo : IFileRepo
{
    private readonly ApplicationContext _context;

    private readonly ICurrentUserService _currentUserService;
    public FileRepo(ApplicationContext context, ICurrentUserService currentUserService)
    {
        _context = context;
        _currentUserService = currentUserService;
    }



    public async Task<int> UploadFileToDatabaseAsync(string fileName, Stream fileStream, string userId)
    {

        if (fileStream == null || string.IsNullOrEmpty(userId))
        {
            throw new ArgumentNullException("fileStream or userId");
        }

        using (var memoryStream = new MemoryStream())
        {
            await fileStream.CopyToAsync(memoryStream);
            var material = new FileEntity
            {
                FileName = fileName,
                FileContent = memoryStream.ToArray(),
                FileType = Path.GetExtension(fileName),
                FileSizeInBytes = memoryStream.Length,
                UserId = userId
            };

            _context.Materials.Add(material);
            await _context.SaveChangesAsync();
            return material.Id;
        }
    }

    public async Task<FileEntity> Download(int materialId)
    {
        var material = await _context.Materials.FirstOrDefaultAsync(x => x.Id == materialId);
        return material;
    }
}
