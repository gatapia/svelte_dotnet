using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using srv.Controllers;

namespace srv;

public static class Init {
  public static void Dependencies(IServiceCollection services) {
    services.AddSingleton<DemoController>();
  }

  public static WebApplication Hosting(WebApplication app) {
    app.UseHttpsRedirection();
    var opts = new DefaultFilesOptions();
    opts.DefaultFileNames.Clear();
    opts.DefaultFileNames.Add("index.html");
    app.UseDefaultFiles(opts);
    app.UseStaticFiles();
    return app;
  }
}