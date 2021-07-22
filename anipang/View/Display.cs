using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anipang.View
{
    class Display
    {
        public static void DisplayMap()
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            //Console.CursorLeft = 0;
            for (int i = 0; i < Map.Instance.Height; i++)
            {
                for(int j = 0; j<Map.Instance.Width; j++)
                {
                    if(Map.Instance.GetUnit(new Vector2(i, j)) != null)
                    {
                        Console.Write(Map.Instance.GetUnit(new Vector2(i, j)).Shape);
                    }
                    else
                    {
                        Console.Write("　");
                    }
                    
                }
                Console.WriteLine();
            }
        }





        public static void Update(Action act)
        {
            while (true)
            {
                //act();
                Display.DisplayMap();
                Delay.MakeDelay(500);

                Consecutiveness.Examine();
                Display.DisplayMap();
                Delay.MakeDelay(500);

                Gravity.Apply();
            }
        }
    }
}
