using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace EmployeeManagment.WebUI.Helpers.Abstarct
{
    public interface IImageHelper
    {
        Task<UploadedImageDto> UploadPicture(IFormFile formFile);
        bool Delete(string path);
    }
}
