using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.BL.Test
{
    public class PersonHandlerTest
    {
        [Fact]
        public void ValidateSetAge_WhenValidAge()
        {
            var person = new Person("Christian", "Rönnholm");
            var personHandler = new PersonHandler();
            personHandler.SetAge(person, 41);

            Assert.Equal(person.Age, 41);
        }
    }
}
