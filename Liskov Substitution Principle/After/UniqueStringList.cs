using System;
using System.Collections.Generic;
using System.Linq;

namespace solid.Liskov_Substitution_Principle.After
{
    public class UniqueStringList : List<string>
    {
        public new void Add(string item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("You cant add null to UniqueStringList");
            }

            if (this.Any(x => x.Equals(item)))
            {
                throw new ArgumentException("This string already exist in UniqueStringList");
            }

            base.Add(item);
        }
    }
}
