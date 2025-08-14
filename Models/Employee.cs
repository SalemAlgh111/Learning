using Learning.ViewModel;
using System.ComponentModel.DataAnnotations;
namespace Learning.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage="أسم الموظف مطلوب ")]
        public string FName { get; set; }

        public int PhoneN { get; set; }

        public DateTime Birthday { get; set; }

        public string JobTitle { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }




        public EmployeeVM ToEmployeeVM()
        {
            return new EmployeeVM()
            {
                FName = FName,
                PhoneN = PhoneN,
                Birthday = Birthday,
                JobTitle = JobTitle,
                Email = Email,
                Department = Department
            };
        }

    }
}
