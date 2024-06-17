using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Api.Contracts
{
    public class CreateFile
    {
        public string FileName { get; set; }
        public DateTimeOffset DateUploaded { get; set; }
        public string FileType { get; set; }
        public long FileSizeInBytes { get; set; }
        public byte[] FileContent { get; set; }
    }

    public static class FileHelper
    {
        public static async Task<byte[]> ReadFileContentAsync(IFormFile file)
        {
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                return stream.ToArray();
            }
        }
    }
}
