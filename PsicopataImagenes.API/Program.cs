using PsicopataImagenes.API;
using PsicopataImagenes.Domain;
using PsicopataImagenes.Domain.common;
using PsicopataImagenes.Infraestructure.IoC;

var builder = WebApplication.CreateBuilder(args);
var paths = new OptionsPaths();
builder.Configuration.GetSection(OptionsPaths.AllowOriginPath).Bind(paths);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();
builder.Services.addServicesColleton();
builder.Services.AddCors(op =>
{
    op.AddPolicy(name: Conf.myCorsPolicy, policy => 
    {
        policy.WithOrigins(paths.localhost, paths.herokuDomain)
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(Conf.myCorsPolicy);
app.UseAuthorization();
app.MapControllers();
app.MapHub<UploadImageAlert>("/avatar");
app.Run();
