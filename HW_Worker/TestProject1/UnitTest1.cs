using System;
using Xunit;
using HW_Worker;
using Moq;

namespace TestProject1
{
    public class UnitTest1
    {
        



        [InlineData("George", 2000, 5,1)]
        [Theory]
        public void RectorTest(string name, double salary, int subordinates, int respLevel)
        {
           

            Rector rec = new Rector(name,salary,subordinates,respLevel);

            Assert.Equal("George",rec.Name());
            Assert.Equal(2000, rec.Salary());
            Assert.Equal(5, rec.Subordinates());
            Assert.Equal(1, rec.ResponsibilityLevel());
            Assert.Equal("Rector", rec.Position());
            


        }
        [Theory]
        [InlineData("Ivan", 3000, 3,2)]
        public void AssistantTest(string name, double salary, int subordinates, int respLevel)
        {
            Assistant assist = new Assistant(name, salary, subordinates, respLevel);

            Assert.Equal("Ivan", assist.Name());
            Assert.Equal(3000, assist.Salary());
            Assert.Equal(3, assist.Subordinates());
            Assert.Equal(2, assist.ResponsibilityLevel());
            Assert.Equal("Assistant", assist.Position());

        }

        [Theory]
        [InlineData("Evgeniy", 1500,3,3)]
        public void Professor(string name, double salary, int subordinates, int respLevel)
        {
            Professor prof = new Professor(name, salary, subordinates, respLevel);

            Assert.Equal("Evgeniy", prof.Name());
            Assert.Equal(1500, prof.Salary());
            Assert.Equal(3, prof.Subordinates());
            Assert.Equal(3, prof.ResponsibilityLevel());
            Assert.Equal("Professor", prof.Position());
        }

        [Theory]
        [InlineData("Yarik", 800,0,1)]
        public void Laborant(string name, double salary, int subordinates, int respLevel)
        {
            Laborant lab = new Laborant(name, salary, subordinates, respLevel);

            Assert.Equal("Yarik", lab.Name());
            Assert.Equal(800, lab.Salary());
            Assert.Equal(0, lab.Subordinates());
            Assert.Equal(1, lab.ResponsibilityLevel());
            Assert.Equal("Laborant", lab.Position());

        }

        [Theory]
        [InlineData("Valera", 5000,100,1)]
        public void Dean(string name, double salary, int subordinates, int respLevel)
        {
            Dean dean = new Dean(name, salary, subordinates, respLevel);

            Assert.Equal("Valera", dean.Name());
            Assert.Equal(5000, dean.Salary());
            Assert.Equal(100, dean.Subordinates());
            Assert.Equal(1, dean.ResponsibilityLevel());
            Assert.Equal("Dean", dean.Position());
        }

       [Fact]
       public void RectorNegative()
        {
            Action act = () => new Rector("", 1000, 3, 3);
            Assert.Throws<Exception>(act);
        }

        
        


        


    }
}
