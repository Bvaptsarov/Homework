using System;

namespace MinesDemo
{
    public class PlayerScore
    {
        public string Nickname { get; set; }

        public int Score { get; set; }
        
        public PlayerScore()
        {
        }

        public PlayerScore(string nickName, int points)
        {
            this.Nickname = nickName;
            this.Score = points;
        }
    }
}