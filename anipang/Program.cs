using System;
using anipang.Element.Creation;
using anipang.View;
namespace anipang
{
    public delegate void Action();

    class MainClass
    {
        public static void Main(string[] args)
        {
            Action act = new Action(Gravity.Apply);
            act += new Action(Display.DisplayMap);
            act += new Action(Consecutiveness.Examine);

            Initializer.FillMap();
            Display.Update(act);

        }
        
        
        
    }
}
