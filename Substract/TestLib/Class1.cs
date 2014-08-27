using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rhino.Mocks;
using Substract.Model1;
using SubstractLogic;
using NUnit.Framework;
namespace TestLib
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void MyModelTest()
        {
            var subsMock = MockRepository.GenerateStub<ISubstract>();

            var model = new MyModels(subsMock);

            Assert.AreEqual(subsMock, model._substract);
        }
    }
}
