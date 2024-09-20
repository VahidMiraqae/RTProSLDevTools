using System.Net.Mime;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();
//app.UseStaticFiles();
app.MapControllers();

app.Use(async (a, b) =>
{
    a.Items.Add("before", "1");
    await b(a);
    await a.Response.WriteAsync($"<h1>hello</h1>");
});

app.Use((HttpContext a, RequestDelegate b) =>
{
    a.Items.Add("next", "2345234");
    a.Response.StatusCode = StatusCodes.Status200OK;
    a.Response.ContentType = MediaTypeNames.Text.Html;
    return Task.CompletedTask;
});


app.Run();
