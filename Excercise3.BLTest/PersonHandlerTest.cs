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

            Assert.Equal(41, person.Age);
        }

        [Fact]
        public void ValidateCreatePerson_WhenValid()
        {
            var personHandler = new PersonHandler();
            var person = personHandler.CreatePerson(age: 41, "Christian", "Rönnholm", height: 189, weight: 100);

            Assert.Equal(41, person.Age);
            Assert.Equal("Christian", person.FName);
        }
    }
}
