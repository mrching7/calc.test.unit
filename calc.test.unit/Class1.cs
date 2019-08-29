using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calc.test.unit
{
    [TestFixture]
    public class CalcTest
    {
        private Calc _uut;

        [SetUp]
        public void setup()
        {
            _uut = new Calc();
        }
        //testing 
        [Test]
        public void Add_double()
        {
            //arrange
            //var uut= new Calc();
            //act
            _uut.Add(2, 2);
            //assert
            Assert.That(_uut.Add(2,2), Is.EqualTo(4));
        }
        [Test]
        public void Divide_By_Zero()
        {
            //arrange
            //var uut= new Calc();
            //act
            _uut.Divide(2, 0);
            //assert
            Assert.Throws<Exception>(() => _uut.Divide(0, 2));
        }



    }
}
