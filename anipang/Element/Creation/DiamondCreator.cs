﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anipang.Element.Creation
{
    class DiamondCreator : Creator
    {
        protected override Unit Create()
        {
            return new Diamond();
        }
    }
}
