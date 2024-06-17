using Microsoft.AspNetCore.Identity;

namespace Api.Entities
{
    public class UserEntity : IdentityUser
    {
      public ICollection<FileEntity> Uploads { get; set; }  =  [];
    }
}