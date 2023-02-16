namespace SimpleLibrary.Test;

public class SumNumberTest
{
    [Fact]
    public void Sum_1Plus1_ShouldReturn2()
    {
        // prepare
        var sumNumber = new SumNumbers();
        var a = 1;
        var b = 1;
        // act
        var c = sumNumber.Sum(a,b);
        // assert
        Assert.Equal(2, c);
    }

    [Fact]
    public void Sum_1Plus1_ShouldNotReturn3()
    {
        // prepare
        var sumNumber = new SumNumbers();
        var a = 1;
        var b = 1;
        // act
        var c = sumNumber.Sum(a,b);
        // assert
        Assert.NotEqual(3, c);
    }
}