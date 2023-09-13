using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddCors();

builder.Services.AddControllers();



//swagger
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

//Enable CORS
void ConfigureServices(IServiceCollection services)
{
    //Enable CORS
   // services.AddCors(c =>
   // {
      //  c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
    //});


    //JSON Serializer
   /* services.AddControllersWithViews().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
        .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
        = new DefaultContractResolver());*/

   // services.AddControllers();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

/*app.UseCors(builder => {
   builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
});*/


/*
void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{


    //Enable CORS
    app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseRouting();

    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });


}*/


app.UseAuthorization();

app.MapControllers();


app.Run();











