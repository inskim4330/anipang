using System;
namespace anipang.Element
{
    public class Circle : Unit
    {
        public Circle(Vector2 position)
        {
            _shape = '○';
            _shapeSelected = '●';
            _position = position;
        }
        public override void Pang()
        {

        }
    }
}
