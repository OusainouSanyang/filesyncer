using Api.Entities;

namespace Api.Contracts
{
    public class UserDto
    {
        public string UserId { get; set; } // Include the user ID property
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; } public List<FileDto> Uploads { get; set; }
    }
}
