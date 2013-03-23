using System;

namespace TicTacToe.PlayerInitialize
{
    public class HumanPlayer : Player, IDrawable
    {
        public Boolean IsMyTurn { get; set; }

        public HumanPlayer(String name, short id, TypeOfSign sign)
            : base(name, id, sign)
        { }

        public void Draw()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
