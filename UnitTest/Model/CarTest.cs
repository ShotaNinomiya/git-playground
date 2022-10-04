using App.Model;
namespace UnitTest.Model;
public class CarTest
{
    [Fact]
    public void CheckToStringFormat()
    {
        var expectedValue = "1000,test";

        Car c = new(1000, "test", 100);
        var actualValue = c.ToString();

        actualValue.Is(expectedValue);
    }

    [Fact]
    public void ThrowArgumentExceptionWhenIdIsMinus()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Car c = new(999, "test", 1000);
        });
    }

    [Fact]
    public void ThrowArgumentExceptionWhenNameIsEmptyString()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Car c = new(1000, "", 1000);
        });
    }
}