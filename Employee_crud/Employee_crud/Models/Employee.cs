using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_crud.Models
{
    public class Employee
    {
        [Display(Name = "ID Nhân Viên")]
        [Required]
        public int IdEmployee { get; set; }
        [Required]
        [Display(Name = "Tên Nhân Viên")]
        [MinLength (1,ErrorMessage ="Tối thiểu 1 kí tự")]
        public string NameEmployee { get; set; }
        [Range(16,50,ErrorMessage ="Tôis thiểu 16 tuổi")]
        [Display(Name = "Tuổi Nhân Viên")]

        public int AgeEmployee { get; set; }
        [Display(Name = "Lương theo ngày của Nhân Viên")]

        public double DailySalary { get; set; }
        [Display(Name = "Số ngày làm việc Nhân Viên")]
        public int NumberDay { get; set; }
        [Display(Name = "Lương Nhân Viên")]
        public double EmployeeWages => DailySalary * NumberDay;
    }
}
