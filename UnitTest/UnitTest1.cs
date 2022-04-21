using NUnit.Framework;
using FakeItEasy;
using RMZCorp.DataAccess.SQL.Contracts;
using System;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var obj = A.Fake<IElectricityMeterRepo>();
            A.CallTo(() => obj.GetById(1)).Returns(new RMZCorp.DataAccess.SQL.DataModels.ElectricityMeter()
            {
                Id = 1,
                SerialNumber = Guid.NewGuid(),
                MeasuringUnit="kWh"

            });
            var obj2 = new TestingFake();
            obj2.CallMe(obj);
            A.CallTo(() => obj.GetById(1)).MustHaveHappened();
            A.CallTo(() => obj.GetById(2)).MustHaveHappenedOnceExactly();
            A.CallTo(() => obj.GetById(1)).MustHaveHappenedOnceExactly();
        }
    }
    public class TestingFake
    {
        public void CallMe(IElectricityMeterRepo electricityMeterRepo)
        {
            var x = electricityMeterRepo.GetById(1);
            var x2 = electricityMeterRepo.GetById(2);

            if (x.Result.MeasuringUnit == "kWh")
            {
                Console.WriteLine(x.Result.MeasuringUnit);
            }
            else
            {
                throw new Exception("Wrong Unit");
               // Console.WriteLine("Wrong Unit");
            }
        }
    }

}