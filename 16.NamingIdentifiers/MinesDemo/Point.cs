using System;

namespace MinesDemo
{
    public class Point
    {
        public string NickName { get; set; }

        public int Score { get; set; }
        
        public Point()
        {
        }

        public Point(string nickName, int points)
        {
            this.NickName = nickName;
            this.Score = points;
        }
    }
}