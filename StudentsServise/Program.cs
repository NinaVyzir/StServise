using Microsoft.EntityFrameworkCore;
using StudentsServise.StudentsData;
using StudentsServise.Services;


var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddDbContext<StudentDataContext>(x =>
    x.UseNpgsql(builder.Configuration.GetConnectionString("StudentsDb") ?? string.Empty));


var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<SServise>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();