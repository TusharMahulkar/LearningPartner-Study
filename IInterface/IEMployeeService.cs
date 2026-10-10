using FirstDemoWebAPI.Model;

namespace FirstDemoWebAPI.IInterface
{
    public interface IEMployeeService
    {
        public List<EmployeeModel> GetEmployees();

        public List<EmployeeModel> AddEmployee(EmployeeModel emp);

        public EmployeeModel GetEmployeeById(int id);
         
    }
}
