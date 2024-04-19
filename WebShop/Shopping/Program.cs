using GraphiQl;

using GraphQL;
using GraphQL.Types;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Shopping.Data;
using Shopping.Interfaces;
using Shopping.Mutation;
using Shopping.Query;
using Shopping.Schema;
using Shopping.Services;
using Shopping.Type;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();

builder.Services.AddTransient<ProductType>();
builder.Services.AddTransient<CategoryType>();
builder.Services.AddTransient<CustomerType>();

builder.Services.AddTransient<ISchema, ProductSchema>();
builder.Services.AddTransient<ISchema, CategorySchema>();
builder.Services.AddTransient<ISchema, CustomerSchema>();

builder.Services.AddTransient<ProductQuery>();
builder.Services.AddTransient<CategoryQuery>();
builder.Services.AddTransient<CustomerQuery>();
builder.Services.AddTransient<RootQuery>();


builder.Services.AddTransient<ProductMutation>();
builder.Services.AddTransient<RootMutation>();

builder.Services.AddTransient<ProductInputType>();
builder.Services.AddTransient<CategoryInputType>();

builder.Services.AddTransient<ISchema, RootSchema>();   

builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());

builder.Services.AddDbContext<GraphQLDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddCors(options =>
{
    var frontend = configuration.GetValue<string>("front-url");

    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(frontend).AllowAnyMethod().AllowAnyHeader();
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

app.UseCors();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.UseAuthorization();

app.MapControllers();

app.Run();
