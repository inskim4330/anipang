using System;
namespace anipang.Element
{
    public class Star : Unit
    {
        public Star(Vector2 position)
        {
            _shape = '☆';
            _shapeSelected = '★';
            _position = position;
        }

        public override void Pang()
        {

        }
    }
}
