var builder = WebApplication.CreateBuilder(args);
var MyAllowOrigin = "_myAllowOrigin";


//Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowOrigin, builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyMethod()   // Allow any HTTP method (GET, POST, etc.)
               .AllowAnyHeader(); ;
    });
});


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(MyAllowOrigin);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
