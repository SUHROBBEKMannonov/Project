using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> Players = new List<Player>();
            Players.Add(new Player("SUHROB"));
            Players.Add(new Player("Mannonov"));
            Players.Add(new Player("MAnsurjon o'g'li"));
            
            foreach (Player item in Players)
            {
                Console.WriteLine(item.Username);
            }
             
            
        }

        class Player
        {

            public string Username { get; set; }
            public Player(string Username)
            {
                this.Username = Username;
            }
            public override string ToString()
            {
                return Username;
            }
        }
    }
}
