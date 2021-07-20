﻿using System;
namespace anipang.Element
{
    public abstract class Unit
    {
        //Represents unit shape.
        protected char _shape;

        //Represents unit shape when selected.
        protected char _shapeSelected;

        //Unit position in map.
        protected Vector2 _position;

        //Since setter is unnecessary, we discourage it.
        public char Shape { get; }
        public char ShapeSelected { get; }

        public Vector2 Position
        {
            get
            {
                return _position;
            }
            set
            {
                if(value is Vector2)
                {
                    _position = value;
                }
            }
        }

        public abstract void Pang();
    }
}
