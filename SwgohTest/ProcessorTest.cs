using System;
using NUnit.Framework;
using Swgoh;
using System.Threading.Tasks;

namespace SwgohTest
{
    [TestFixture]
    public class ProcessorTest
    {
        [Test]
        public async Task LoadPlayerInfo_Test()
        {
            var player = await Processor.LoadPlayerInfo(429716858);

            Assert.IsNotNull(player);
        }
        
        [Test]
        public async Task LoadCharacterInfo_Test()
        {
            var character = await Processor.LoadCharacterInfo(80);

            Assert.IsNotNull(character);
        }


        [Test]
        public async Task LoadCharacterList_Test()
        {
            var characters = await Processor.LoadCharacterList();

            Assert.IsNotNull(characters);
            Assert.Greater(characters.Length, 0);
        }
    }
}
