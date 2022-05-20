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
        public void ValidateConvertHeightToToInt_WhenUneven_ShouldRoundDown()
        {
            //Using guessed businessrules that we should round double when it's uneven
            var personHandler = new PersonHandler();
            double dValue = 1.1d;
            int iActual = personHandler.ConvertDoubleToInt(dValue);

            Assert.Equal(1, iActual);
        }

        [Fact]
        public void ValidateConvertHeightToToInt_WhenUneven_ShouldRoundUp()
        {
            //Using guessed businessrules that we should round double when it's uneven
            var personHandler = new PersonHandler();
            double dValue = 1.9d;
            int iActual = personHandler.ConvertDoubleToInt(dValue);

            Assert.Equal(2, iActual);
        }

        [Fact]
        public void ValidateSetAge_WhenValidAge()
        {
            var person = new Person("Christian", "Rönnholm");
            var personHandler = new PersonHandler();
            personHandler.SetAge(person, 41);

            Assert.Equal(41, person.Age);
        }

        [Fact]
        public void ValidateSetAge_WhenAgeLowerThan0()
        {
            var person = new Person("Christian", "Rönnholm");
            var personHandler = new PersonHandler();

            var ex = Assert.Throws<ArgumentException>(() =>
                                                  personHandler.SetAge(person, -1));
            Assert.Equal(Language.ValidateAgeArgumentException,
                          ex.Message);
        }

        [Fact]
        public void ValidateSetHeight_WhenValidHeight()
        {
            var person = new Person("Christian", "Rönnholm");
            var personHandler = new PersonHandler();
            double dValue = 189d;
            int iExpected = 189;

            personHandler.SetHeight(person, dValue);

            Assert.Equal(iExpected, person.Height);
        }

        [Fact]
        public void ValidateSetWeight_WhenValidWeight()
        {
            var person = new Person("Christian", "Rönnholm");
            var personHandler = new PersonHandler();
            double dValue = 110d;
            int iExpected = 110;

            personHandler.SetWeight(person, dValue);

            Assert.Equal(iExpected, person.Weight);
        }

        [Fact]
        public void ValidateSetFName_WhenValidFName()
        {
            var person = new Person("Christian", "Rönnholm");
            var personHandler = new PersonHandler();

            string newFName = "Chrille";
            personHandler.SetFName(person, newFName);

            Assert.Equal(newFName, person.FName);
        }

        [Fact]
        public void ValidateSetLName_WhenValidLName()
        {
            var person = new Person("Christian", "Rönnholm");
            var personHandler = new PersonHandler();

            string newLName = "Rönnis";
            personHandler.SetLName(person, newLName);

            Assert.Equal(newLName, person.LName);
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
