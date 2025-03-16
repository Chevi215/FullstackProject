using Kids_Canvas.Data;
using Kids_Canvas.Core.Services;
using Kids_Canvas.Service;
using Kids_Canvas.Core.Repositories;
using Kids_Canvas.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ICategoryService,CategoryService>();

builder.Services.AddScoped<ICommentsService, CommentsService>();

builder.Services.AddScoped<IDrowingsService,DrowingsService>();

builder.Services.AddScoped<IFavorite_DrowingsService,Favorite_DrowingsService>();

builder.Services.AddScoped<IUserService,UserService>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddDbContext<DataContext>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
