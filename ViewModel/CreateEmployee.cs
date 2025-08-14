using Learning.Models;
using System.ComponentModel.DataAnnotations;

namespace Learning.ViewModel
{
    public class CreateEmployee
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "أسم الموظف مطلوب ")]
        public string FName { get; set; }

        public int PhoneN { get; set; }

        public DateTime Birthday { get; set; }

        public string JobTitle { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public Employee ToEmployee()
        {

            return new Employee()
            {
                FName = FName,
               PhoneN = PhoneN,
                Email = Email,
                Birthday = Birthday,
                JobTitle = JobTitle,
                Department = Department
            };
        }


    }
}
