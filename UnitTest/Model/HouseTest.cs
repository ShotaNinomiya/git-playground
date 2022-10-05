using App.Model;
namespace UnitTest.Model;
public class HouseTest
{
    [Fact]
    public void CheckToStringFormat()
    {
        var expectedValue = "2000,test";

        House h = new(2000, "test");
        var actualValue = h.ToString();

        actualValue.Is(expectedValue);
    }

    [Fact]
    public void ThrowArgumentExceptionWhenIdIsMinus()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            House h = new(1999, "test");
        });
    }

    [Fact]
    public void ThrowArgumentExceptionWhenNameIsEmptyString()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            House h = new(0, "");
        });
    }
}