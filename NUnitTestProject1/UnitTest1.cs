using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        List<Player> pList = new List<Player>() {
        new Player(){PlayerId=1,PlayerName="dhoni",PlayerTeam="india"},
        new Player(){PlayerId=2,PlayerName="virat",PlayerTeam="india"},
        new Player(){PlayerId=3,PlayerName="watson",PlayerTeam="australia"}
        };
        [Test]
        public void CheckNull()
        {
            foreach (var p in pList)
            {
                Assert.NotZero(p.PlayerId);
                Assert.NotNull(p.PlayerName);
                Assert.NotNull(p.PlayerTeam);
            }
        }

    }
}