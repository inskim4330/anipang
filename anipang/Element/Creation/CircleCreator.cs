using System;
using anipang;
namespace anipang.Element.Creation
{
    public class CircleCreator : Creator
    {
        public override Unit Create()
        {
            return new Circle(new Vector2(0,0));
        }
    }
}
