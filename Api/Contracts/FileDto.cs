using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Contracts
{
    public class FileDto
    {
         public int Id { get; set; }
    public string FileName { get; set; }
    public DateTime DateUploaded { get; set; }
    public string UserId { get; set; }
    // Do not include User object here to prevent reference loops
    public string FileType { get; set; }
    public long FileSizeInBytes { get; set; }
    public byte[] FileContent { get; set; }
    }
}