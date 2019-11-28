using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Models
{
    class Property : Member
    {
        public string Description { get; }

        public Property(string name, string description) : base(name)
        {
            Description = description;
        }

        public override string ToString()
        {
            return $"Property: {base.ToString()} - summary: {Description}";
        }
    }
}
