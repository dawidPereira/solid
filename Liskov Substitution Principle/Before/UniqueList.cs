using System;
using System.Collections.Generic;
using System.Linq;

namespace solid.Liskov_Substitution_Principle.Before
{
    public class UniqueList
    {
        private List<string> _list = new List<string>();

        public void Add(string item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("You cant add null to UniqueStringList");
            }

            if (_list.Any(x => x.Equals(item)))
            {
                throw new ArgumentException("This string already exist in UniqueStringList");
            }

            _list.Add(item);
        }

        public string ElementAt(int index)
        {
            return _list.ElementAt(index);
        }

        public int Count()
        {
            return _list.Count;
        }
    }
}
