using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TCKimlik.Test
{
    [TestClass]
    public class TCKimlikTest
    {
        private TCKimlik instnace;
        [TestInitialize]
        public void Initalize() { instnace = TCKimlik.CreateInstance(); }
        [TestMethod]
        public void KlasikDogrulama()
        {
            var result = instnace.Dogrula(11111111111, "SÜLEYMAN", 1111, "YALÇIN", 11, 1);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AsyncDogrulama()
        {
            var result = instnace.DogrulaAsync(11111111111, "SÜLEYMAN", 1111, "YALÇIN", 11, 1);
            Assert.IsTrue(result.Result.Body.KisiVeCuzdanDogrulaResult);
        }
    }
}
