using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Tree.Models
{
    public interface INode
    {
        List<INode> Child { get; set; }
        EType Type { get; }
        String Name { get; }
        string ToMarkdown();
    }

}
