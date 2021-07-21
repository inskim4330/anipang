using System;
namespace anipang.Element
{
    public class Heart : Unit
    {
        public Heart(Vector2 position)
        {
            _shape = '♡';
            _shapeSelected = '♥';
            _position = position;
        }
        public override void Pang()
        {

        }
    }
}
