using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Models
{
    class Member
    {
        public string Name { get; }

        public Member(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}{Environment.NewLine}";
        }
    }
}
