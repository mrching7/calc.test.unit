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
        //testing 
        [Test]
        public void Add_double()
        {
            //arrange
            var uut= new Calc();
            //act
            uut.Add(2, 2);
            //assert
            Assert.That(uut.Add(2,2), Is.EqualTo(5));
        }



    }
}
