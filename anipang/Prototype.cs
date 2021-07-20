using System;
using anipang.Element;
namespace anipang
{
    public class Prototype
    {
        private Unit _circle;
        private Unit _club;
        private Unit _diamond;
        private Unit _heart;
        private Unit _spade;
        private Unit _square;
        private Unit _star;
        public Unit this[string value]
        {
            get
            {
                switch (value.ToLower())
                {
                    case "circle":
                        return _circle;
                    case "club":
                        return _club;
                    case "diamond":
                        return _diamond;
                    case "heart":
                        return _heart;
                    case "spade":
                        return _spade;
                    case "square":
                        return _square;
                    case "star":
                        return _star;
                    default:
                        break;
                }
                return null;
            }
        }

        public Prototype()
        {
            _circle = new Circle('a', 'a', new Vector2(0, 0));
            _club = new Club('a', 'a', new Vector2(0, 0));
            _diamond = new Diamond('a', 'a', new Vector2(0, 0));
            _heart = new Heart('a', 'a', new Vector2(0, 0));
            _spade = new Spade('a', 'a', new Vector2(0, 0));
            _square = new Square('a', 'a', new Vector2(0, 0));
            _star = new Star('a', 'a', new Vector2(0, 0));
        }
    }
}
