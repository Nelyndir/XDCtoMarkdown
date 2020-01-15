﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    interface INode
    {
        List<INode> Child { get; set; }
        EType Type { get; }
        String Name { get; }
    }

}