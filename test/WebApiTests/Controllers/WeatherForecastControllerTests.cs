//add namespace for WeatherForecastController
using WebApi.Controllers;

namespace WebApiTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }
    
    // add a test method that tests the GetRange method of WeatherForecastContoller
    // Path: test/WebApiTests/Controllers/WeatherForecastControllerTests.cs
    [TestMethod]
    public void TestGetRange()
    {
        // Arrange
        var controller = new WeatherForecastController(null);
        var range = new DateRange { Length = 5 };
        
        // Act
        var result = controller.GetRange(range);
        
        // Assert
        Assert.AreEqual(5, result.Count());
    }
}