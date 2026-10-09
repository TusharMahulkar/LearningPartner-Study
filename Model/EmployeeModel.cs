using System.Text.Json.Serialization;

namespace FirstDemoWebAPI.Model
{
    public class EmployeeModel
    {

        [JsonPropertyName("Id")]
        public int Id { get; set; }

       [JsonPropertyName("Name")]
        public string Employee_Name { get; set; }
        
    }
}
