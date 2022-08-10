using Microsoft.AspNetCore.Builder;
using srv.Controllers;

namespace srv;

public static class Routes {
  public static void Register(WebApplication app) {
    app.MapGet("/api/demo", (DemoController controller) => controller.GetDemoResponse());
  }
}