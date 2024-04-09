using Ems.data;
using Ems.Models;
using Models;

namespace Services
{
    public class EmployeeServices
    {
        private readonly DbContextDemo _dbContextDemo;
        public EmployeeServices(DbContextDemo dbContext)
        {
            _dbContextDemo = dbContext;
        }
        public List<Employee> GetEmployeeDetails()
        {
            return _dbContextDemo.Employees.ToList();
        }

        public List<Employee> GetEmployeById(string id) 
        {
           return _dbContextDemo.Employees.Where(a=>a.EmpId == id).ToList();
        }
        public string AddEmployee(Employee employee)
        {
            bool found=_dbContextDemo.Employees.Any(a=>a.EmpId==employee.EmpId);
            if (found)
            {
                return "employee already exist";
            }
            else
            {
                _dbContextDemo.Employees.Add(employee);
                _dbContextDemo.SaveChanges();
                return "Employeev Added Successfully";
            }
        }
        
    }
}
