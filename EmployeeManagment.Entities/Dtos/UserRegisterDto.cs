using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagment.Entities.Dtos
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage = "Lütfen Email Adresi Giriniz")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Lütfen Parola Giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen İsim Giriniz")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen Soyisim Giriniz")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
    }
}
