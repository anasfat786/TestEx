using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleAppTestPlayer
{
    class Program
    {
        public static List<Player> Playerlist()
        {
            List<Player> plist = new List<Player>
            {
                new Player{PlayerId=1,PlayerName="yuvi",PlayerTeam="India"},
                new Player{PlayerId=2,PlayerName="Sachin",PlayerTeam="India"},
                new Player{PlayerName="Virat",PlayerTeam="India"},
                new Player{PlayerId=5,PlayerTeam="pakistan"},
                new Player{PlayerId=44,PlayerName="watson",PlayerTeam="New Zealand"}



            };



            return plist;
        }
        static void Main(string[] args)
        {
        }
    }
}