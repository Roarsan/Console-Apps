using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
namespace testapp1
{
    [TestClass]
    public class UnitTest1
    {
        DistanceConverter distanceConverter = new DistanceConverter();
        [TestMethod]
        public void TestMethod1()
        {
            
            distanceConverter.InitialiseUnitArray();
            distanceConverter.fromUnit = DistanceUnits.Miles;
            distanceConverter.toUnit = DistanceUnits.Feet;

            distanceConverter.fromDistance = 100;


            distanceConverter.Calculate();

            Assert.AreEqual(528000, distanceConverter.toDistance);

        }
    }
}
