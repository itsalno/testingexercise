namespace TestMethods;


public class UnitTest1
{
    
    private readonly Methods.Methods.IMethods _exercises = new Methods.Methods();
    
    [Fact]
    public void TestReverseString()
    {
        var s = "Hello";

        var result =_exercises.reverseString(s);

        Assert.Equal("olleH",result);
        
    }
    
    
    
    [Fact]
    public void TestfindMax()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var result = _exercises.findMax(numbers);
        Assert.Equal(5,result);
    }

    [Fact]
    public void TestCountOccurencies()
    {
        var str = "hello world";
        var charToCount = 'l';
        var result = _exercises.CountOccurencies(str, charToCount);
        Assert.Equal(3, result);
    }
    
    
    
    
}