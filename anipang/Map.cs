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
        private List<Unit> _presentUnits;
        public Map(int width, int height)
        {
            _width = width;
            _height = height;
            _unitMaxCount = width * height;
            _presentUnits = new List<Unit>();
        }

        /*
        private Unit[,] _units;

        public Map(int width, int height)
        {
            _units = new Unit[width, height];
        }
        */

    }
}
