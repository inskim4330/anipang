using System;
namespace anipang.Element
{
    public class Spade : Unit
    {
        public Spade(Vector2 position)
        {
            _shape = '♤';
            _shapeSelected = '♠';
            _position = position;
        }
        public override void Pang()
        {

        }
    }
}
