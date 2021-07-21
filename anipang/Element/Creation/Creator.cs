using System;
using anipang.Element;
namespace anipang.Element.Creation
{
    public abstract class Creator
    {
        public abstract Unit Create();
        public void PlaceUnit(IRegister register)
        {
            Unit unit = Create();
            register.RegisterToMap(unit);
        }
    }
}
