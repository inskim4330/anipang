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
        private int _length;
        private int _unitMaxCount;

        //Present units in map. [height, width]
        private Unit[,] _presentUnits;
        public Unit[,] PresentUnit
        {
            get
            {
                return _presentUnits;
            }
        }

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
        
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public int Length
        {
            get
            {
                return _width;
            }
        }
        public int UnitMaxCount
        {
            get
            {
                return _unitMaxCount;
            }
        }

        private Map()
        {
            _width = 7;
            _height = 7;
            _unitMaxCount = _width * _height;
            _presentUnits = new Unit[_height, _width] ;
        }

        public Unit GetUnit(Vector2 position)
        {
            return _presentUnits[position.Y, position.X];
        }

        public bool SetUnit(Unit unit, Vector2 position)
        {
            //if something already occupied, returns false.
            if (_presentUnits[position.Y, position.X] != null)
            {
                return false;
            }
            unit.Position = position;
            _presentUnits[unit.Position.Y, unit.Position.X] = unit;
            return true;
        }

        
    }
}
