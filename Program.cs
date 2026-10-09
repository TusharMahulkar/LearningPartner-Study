namespace FirstDemoWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //-----------------SEction One---------------------------------------------------------------
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
             


            //------------------SEctoin Two--------------------------------------------------------------
            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();


            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
