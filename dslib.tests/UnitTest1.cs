using Xunit;
using dslib;

namespace dslib.tests;
public class UnitTestsForDsLib
{
    [Fact]
    public void CanCreateStack()
    {
        //arrange
        //act        
        Stack s = new Stack();
        //assert
        Assert.Equal(s.Length, 0);

    }

    [Fact]
    public void CanPushOntoStack()
    {
        //arrange
        Stack s = new Stack();
        //act 
        s.Push("item");        
        //assert 
        Assert.Equal(s.Length, 1);
    }
}