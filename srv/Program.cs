using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using srv;

var builder = WebApplication.CreateBuilder(args);

#if DEBUG
builder.Services.AddCors(opts => opts.AddPolicy("origins", bldr => bldr.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
#endif

Init.Dependencies(builder.Services);
var app = Init.Hosting(builder.Build());
Routes.Register(app);

#if DEBUG
app.UseCors("origins");
#endif

app.Run();