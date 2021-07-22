using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anipang.Element;
using anipang.Element.Creation;
namespace anipang
{
    class Prototype
    {
        private static Prototype _instance;
        public static Prototype Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Prototype();
                }
                return _instance;
            }
        }
        private Prototype() 
        {
            _prototypeCreator.Add(new CircleCreator());
            _prototypeCreator.Add(new ClubCreator());
            _prototypeCreator.Add(new DiamondCreator());
            _prototypeCreator.Add(new HeartCreator());
            _prototypeCreator.Add(new SpadeCreator());
            _prototypeCreator.Add(new SquareCreator());
            _prototypeCreator.Add(new StarCreator());
        }

        private List<Creator> _prototypeCreator = new List<Creator>();
        public void RegisterCreator(Creator newCreator)
        {
            _prototypeCreator.Add(newCreator);
        }
        public Creator GetCreator(int index)
        {
            return _prototypeCreator[index];
        }
        public Creator GetCreatorArbitrarily()
        {
            Random random = new Random();
            return _prototypeCreator[random.Next(0,_prototypeCreator.Count)];
        }
    }
}
