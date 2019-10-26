using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SmartToDo.Models;


namespace SmartToDo.Tests
{
    [TestFixture]
    public class ModelTests
    {
        [Test]
        public void Test() {
            var sut = new Test();
            
            var result = sut.AddNumbers(5, 2);

            const int expectedResult = 7;
            Assert.That(result == expectedResult);
        }
    }
}
