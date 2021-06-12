using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class House
    {
        private StringBuilder _partArgument = new StringBuilder();

        public void Add(string part)
        {
            _partArgument.Append($"\n{part}");
        }

        public string ListPart()
        {
            return $"Casa: {_partArgument}";
        }
    }
}