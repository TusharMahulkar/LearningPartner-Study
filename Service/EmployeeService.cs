using FirstDemoWebAPI.Model;

namespace FirstDemoWebAPI.Service
{
    public class EmployeeService
    {
        List<EmployeeModel> employeeList = new List<EmployeeModel>();
        public EmployeeService()
        {
            AllEmployee();
        }

        private void AllEmployee()
        {
            EmployeeModel model2 = new EmployeeModel();
            model2.Id = 2;
            model2.Employee_Name = "TEST-2";

            EmployeeModel model3 = new EmployeeModel();
            model3.Id = 3;
            model3.Employee_Name = "TEST-3";


            employeeList.Add(model2);
            employeeList.Add(model3);
        }

        public List<EmployeeModel> GetEmployees()
        {
            return employeeList;
        }


        public List<EmployeeModel> AddEmployee(EmployeeModel emp)
        {             
            employeeList.Add(emp);
            return employeeList;
        }


        public EmployeeModel GetEmployeeById(int id)
        {
           return employeeList.FirstOrDefault(a => a.Id == id);
        }

    }
}
