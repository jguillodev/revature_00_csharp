using Devops.Client.Controllers;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Devops.Test
{
  
  public class ClientTest
  {
    private  readonly ILogger<HomeController> logger = LoggerFactory.Create(o => o.SetMinimumLevel(LogLevel.Debug)).CreateLogger<HomeController> ();
    [Fact]
    public void Test_IndexPage()
    {
      //arrange
      var home = new HomeController(logger);
      var index = home.Index();
     

      Assert.NotNull(index);
    }

    [Fact]
      public void Test_PrivacyPage()
    {
      //arrange
      var home = new HomeController(logger);
      var privacy = home.Privacy();

     
      Assert.NotNull(privacy);
    }
  }
}