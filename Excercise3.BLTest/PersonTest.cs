namespace Excercise3.BL.Test
{
    public class PersonTest
    {
        [Fact]
        public void ValidateFName_WhenFNameLengthLessThanTwo_ShouldThrowArgumentException()
        {
            var person = new Person("Christian", "R�nnholm");
            
            var ex = Assert.Throws<ArgumentException>(() =>
                                                  person.ValidateFName("C"));
            Assert.Equal(Language.ValidateFNameArgumentException,
                          ex.Message);            
        }

        [Fact]
        public void ValidateFName_WhenFNameLengthMoreThanTen_ShouldThrowArgumentException()
        {
            var person = new Person("Christian", "R�nnholm");
            
            var ex = Assert.Throws<ArgumentException>(() =>
                                                  person.ValidateFName("ChristianR�"));
            Assert.Equal(Language.ValidateFNameArgumentException,
                          ex.Message);
        }

        [Fact]
        public void ValidateFName_WhenValid()
        {
            var person = new Person("Christian", "R�nnholm");
            
            Assert.True(person.ValidateFName("Christian"));
        }
    }
}