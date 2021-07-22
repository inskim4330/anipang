using System;
using anipang.Element;
namespace anipang
{
    public class InitialRegister : IRegister
    {
        public void RegisterToMap(Unit unit)
        {
            for(int i = 0; i<Map.Instance.Height; i++)
            {
                for(int j = 0; j<Map.Instance.Width; j++)
                {
                    Map.Instance.SetPresentUnits(new Vector2(j,i),unit);
                }
            }
        }
    }
}
