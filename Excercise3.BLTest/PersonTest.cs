namespace Excercise3.BL.Test
{
    public class PersonTest
    {
        [Fact]
        public void ValidateFName_WhenFNameLengthLessThanTwo_ShouldThrowArgumentException()
        {
            var person = new Person("Christian", "Rönnholm");
            
            var ex = Assert.Throws<ArgumentException>(() =>
                                                  person.ValidateFName("C"));
            Assert.Equal(Language.ValidateFNameArgumentException,
                          ex.Message);            
        }

        [Fact]
        public void ValidateFName_WhenFNameLengthMoreThanTen_ShouldThrowArgumentException()
        {
            var person = new Person("Christian", "Rönnholm");
            
            var ex = Assert.Throws<ArgumentException>(() =>
                                                  person.ValidateFName("ChristianRö"));
            Assert.Equal(Language.ValidateFNameArgumentException,
                          ex.Message);
        }

        [Fact]
        public void ValidateFName_WhenValid()
        {
            var person = new Person("Christian", "Rönnholm");
            
            Assert.True(person.ValidateFName("Christian"));
        }
    }
}