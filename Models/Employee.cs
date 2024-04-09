using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Employee
    {
        [Key]public string EmpId {  get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmailId {  get; set; }
        public string PhoneNumber { get; set; }

    }
}
