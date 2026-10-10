using FirstDemoWebAPI.IInterface;
using FirstDemoWebAPI.Model;
using FirstDemoWebAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace FirstDemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //EmployeeService service = new EmployeeService();

        private IEMployeeService service;

        public EmployeeController(IEMployeeService empService)
        {
            this.service = empService;
        }


        //api/Employee/all
        [HttpGet("allEmployeeList")]
        public List<EmployeeModel> GetEmployees()
        {
            return null;
        }


        [HttpPost("CreateEmployee")]
        public List<EmployeeModel> CreateEmployee([FromBody] EmployeeModel empData)
        {
            return service.AddEmployee(empData);
        }


        [HttpGet("UserId")]
        public EmployeeModel GetById(int id)
        { 
           return service.GetEmployeeById(id);        
        }

    }
}
