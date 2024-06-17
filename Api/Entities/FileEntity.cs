namespace Api.Entities
{
    public class FileEntity
    {
        public int Id { get; set; }
        public string FileName {get; set;}
        public DateTimeOffset DateUploaded { get; set; }
        public string UserId {get; set;}
        public UserEntity User {get; set;}
        public string FileType { get; set; }
        public long FileSizeInBytes { get; set; }
        public byte[] FileContent { get; set; }
    }
}