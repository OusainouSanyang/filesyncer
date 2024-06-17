using Api.Contracts;
using Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.IRepository
{
    public interface IFileRepo
    {
     
          Task<int> UploadFileToDatabaseAsync(string fileName, Stream fileStream ,string userId);

          
            Task<FileEntity> Download(int materialId);
       

       
    }
}