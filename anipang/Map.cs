using System;
using System.Collections.Generic;
using anipang.Element;
namespace anipang
{
    public class Map
    {
        private static Map _instance;
        private int _width;
        private int _height;
        private int _unitMaxCount;

        //Units in map.
        private Unit[,] _presentUnits;

        public static Map Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Map();
                }
                return _instance;
            }
        }
        public Unit[,] PresentUnits
        {
            get
            {
                return _presentUnits;
            }
            set
            {
                PresentUnits = value;
            }
        }

        private Map()
        {
            _width = 7;
            _height = 7;
            _unitMaxCount = _width * _height;
            _presentUnits = new Unit[_width, _height] ;
        }

    }
}
