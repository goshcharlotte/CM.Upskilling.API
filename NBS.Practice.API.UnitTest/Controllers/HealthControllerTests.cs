using NBS.Practice.API.Controllers;

namespace NBS.Practice.API.UnitTest;

public class Tests
{
    private HealthController _controller;

    [SetUp]
    public void Setup()
    {
        _controller = new HealthController();
    }

    [Test]
    public void Ping_ReturnsTrue()
    {
        // Arrange

        // Act
        var response = _controller.Ping();

        // Assert
        Assert.That(response == true);
    }

    [Test]
    public void Echo_ReturnsInput()
    {
        // Arrange
        var testString = "this is a test string";

        // Act
        var response = _controller.Echo(testString);

        // Assert
        Assert.That(response == testString);
    }
}
