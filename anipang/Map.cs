using System;
using System.Collections.Generic;
using anipang.Element;
namespace anipang
{
    public class Map
    {
        private int _width;
        private int _height;
        private int _unitMaxCount;

        //Units in map.
        private Unit[,] _presentUnits;

        public Map(int width, int height)
        {
            _width = width;
            _height = height;
            _unitMaxCount = width * height;
            _presentUnits = new Unit[_width, _height] ;
        }

    }
}
