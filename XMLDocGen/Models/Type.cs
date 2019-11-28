using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Models
{
    class Type : Member
    {
        public string Description { get; }

        public Type(string name, string description) : base(name)
        {
            Description = description;
        }

        public override string ToString()
        {
            return $"Type: {base.ToString()} - summary: {Description}";
        }
    }
}
