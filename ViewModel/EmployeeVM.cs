
using Learning.Models;
using Learning.Controllers;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;
namespace Learning.ViewModel
{
    public class EmployeeVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "أسم الموظف مطلوب ")]
        public string FName { get; set; }

        public int PhoneN{ get; set; }

        public DateTime Birthday { get; set; }

        public string JobTitle { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

    

    }
}
