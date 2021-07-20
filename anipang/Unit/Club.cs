using System;
namespace anipang.Element
{
    public class Club : Unit
    {
        public Club(Vector2 position)
        {
            _shape = '♧';
            _shapeSelected = '♣';
            _position = position;
        }
        public override void Pang()
        {

        }
    }
}
