using App.Model;
namespace UnitTest.Model;
public class PersonTest
{
    [Fact]
    public void CheckToStringFormat()
    {
        var expectedValue = "0,test";

        Person p = new(0, "test");
        var actualValue = p.ToString();

        actualValue.Is(expectedValue);
    }

    [Fact]
    public void ThrowArgumentExceptionWhenIdIsMinus()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Person p = new(-1, "test");
        });
    }

    [Fact]
    public void ThrowArgumentExceptionWhenNameIsEmptyString()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Person p = new(0, "");
        });
    }
}