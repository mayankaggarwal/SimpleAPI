namespace SimpleAPI.Tests;

using SimpleAPI.Api.Controllers;
public class UnitTest1
{
  ValuesController controller = new ValuesController();

  [Fact]
  public void GetByIdReturnsMyName()
  {
    var returnValue = controller.Get(1);
    Assert.Equal("Mayank Aggarwal", returnValue.Value);
  }

  [Fact]
  public void GetRetrunsData()
  {
    var returnValue = controller.Get();
    Assert.NotNull(returnValue);
    Assert.NotNull(returnValue.Value);
    Assert.True(returnValue.Value.Any());
  }
}