using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Threading.Tasks;
using V10Networks.FraudDetection;

namespace NoFraud.UnitTest
{
    [TestClass]
    public class TestMethod
    {
        [TestMethod]
        public async Task TestNoFraud()
        {
            double score = await V10Networks.FraudDetection.NoFraud.GetFraudScore(IPAddress.Parse("8.8.8.8"));

            Assert.AreEqual(0, score, 1, "Fraud check doesn't work!");
        }
    }
}
