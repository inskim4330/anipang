using System;
namespace anipang.Element
{
    public class Diamond : Unit
    {
        public Diamond(Vector2 position)
        {
            _shape = '◇';
            _shapeSelected = '◆';
            _position = position;
        }
        public override void Pang()
        {

        }
    }
}
