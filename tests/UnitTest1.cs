using Xunit;

using domain;

namespace tests;

public class UnitTestSpeaker
{
    [Fact]
    public void TestSpeakerFirstName()
    {
        MySpeakerHelper helper = new MySpeakerHelper();
        //Arrange
        Speaker s = new Speaker();
        
        //Act
        s.FirstName = helper.GetFirstName("Dude");

        //Assert
        Assert.Equal(s.FirstName, "Dude");
        
    }
}