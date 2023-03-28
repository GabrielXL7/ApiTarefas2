namespace ApiTarefas2;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.AddPersistence();

        var app = builder.Build();

        app.MapTarefasEndpoints();

        app.UseSwagger();
        app.UseSwaggerUI(c => { });

        app.Run();
    }
}