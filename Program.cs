namespace GameBackend;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args); /*Criar uma aplication web, construtor web*/

        // Add MIDDLEWARES (services):

        builder.Services.AddControllers();

        // Add MIDDLEWARES (swagger):
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        WebApplication app = builder.Build(); /*Serviços e configurações */

        if(app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        

        // Use MIDDWARE (adiciona no pipeline de execução):

        app.MapControllers(); //Ordem aqui importa!!!

        app.Run();
    }
}