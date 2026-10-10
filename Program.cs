
namespace FirstDemoWebAPI
{
    using FirstDemoWebAPI.IInterface;
    using FirstDemoWebAPI.Service;


    public class Program
    {
        public static void Main(string[] args)
        {

            //-----------------SEction One-- Register Service---------------------------------------------------------------
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();


            //Custom Service
            builder.Services.AddSingleton<IEMployeeService, EmployeeService>();


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //------------------Sectoin Two -- Configure or USer Services--------------------------------------------------------------
            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();


             

            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();
            //app.UseAuthorization();
            app.MapControllers();
            app.Run();



        }
    }
}
