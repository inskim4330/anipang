using System;
namespace anipang.Element
{
    public class Square : Unit
    {
        public Square(Vector2 position)
        {
            _shape = '□';
            _shapeSelected = '■';
            _position = position;
        }

        public override void Pang()
        {

        }
    }
}
