using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;
using SubstractLogic;
using Substract.Model;

namespace TestLib
{
    [TestFixture]
    public  class TestCases
    {
        [Test]
        public void MyTest()
        {
            var mock = MockRepository.GenerateStub<ISubstract>();

            var model = new MyModel(mock);

            Assert.AreEqual(model.substract,mock, "Trying first case");
        }
    }
}
