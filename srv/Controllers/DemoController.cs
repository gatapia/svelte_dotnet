using System.Dynamic;

namespace srv.Controllers;

public class DemoController {
  public DemoResponse GetDemoResponse() {
    return new DemoResponse { Result = "Hello World" };
  }
}

public class DemoResponse {
  public string Result { get; init; } = null!;
}