using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Models
{
    public abstract class Member
    {
        public string Name { get; protected set; }

        public Member(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}{Environment.NewLine}";
        }

        public abstract string ToMarkdown();
    }
}
