using System;
using anipang.Element;
namespace anipang
{
    public class InitialRegister : IRegister
    {
        public void RegisterToMap(Unit unit)
        {
            for
            Map.Instance.PresentUnits[0,0] = unit;
        }
    }
}
