using NUnit.Framework;
using srv.Controllers;

namespace srv_tests.Controllers;

public class DemoControllerTest {
  
  [Test] public void Demo_test() {
    var controller = new DemoController();
    Assert.AreEqual("Hello World", controller.GetDemoResponse().Result);
  }
}