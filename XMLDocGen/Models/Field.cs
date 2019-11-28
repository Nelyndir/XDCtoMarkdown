using System;
using System.Collections.Generic;
using System.Text;

namespace XMLDocGen.Models
{
    class Field : Member
    {
        public string Description { get; }

        public Field(string name, string description) : base(name)
        {
            Description = description;
        }

        public override string ToString()
        {
            return $"Field: {base.ToString()}- summary: {Description}";
        }
    }
}
