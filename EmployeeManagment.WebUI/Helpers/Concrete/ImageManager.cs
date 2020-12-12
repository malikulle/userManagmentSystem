using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Entities.Dtos;
using EmployeeManagment.WebUI.Helpers.Abstarct;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace EmployeeManagment.WebUI.Helpers.Concrete
{
    public class ImageManager : IImageHelper
    {
        private readonly IWebHostEnvironment _env;
        private readonly string _wwwroot;
        private readonly string imgFolder = "images";
        public ImageManager(IWebHostEnvironment env)
        {
            _env = env;
            _wwwroot = _env.WebRootPath;
        }

        public bool Delete(string path)
        {
            var fileToDelete = Path.Combine($"{_wwwroot}/{imgFolder}/", path);
            if (System.IO.File.Exists(fileToDelete))
            {
                System.IO.File.Delete(fileToDelete);
                return true;
            }
            return false;

        }

        public async Task<UploadedImageDto> UploadPicture(IFormFile formFile)
        {
            if (!Directory.Exists($"{_wwwroot}/{imgFolder}"))
            {
                Directory.CreateDirectory($"{_wwwroot}/{imgFolder}");
            }


            string oldFileName = Path.GetFileNameWithoutExtension(formFile.FileName);

            string fileExtension = Path.GetExtension(formFile.FileName);

            string random = Guid.NewGuid().ToString();

            string newFileName = $"{random}.jpg";
            var path = Path.Combine($"{_wwwroot}/{imgFolder}", newFileName);

            await using (var stream = new FileStream(path, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            }

            return new UploadedImageDto()
            {
                Extension = fileExtension,
                FullName = $"{newFileName}",
                OldName = oldFileName,
                FolderName = imgFolder,
                Path = path,
                Size = formFile.Length
            };
        }
    }
}
