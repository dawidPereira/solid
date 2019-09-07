using System;
using System.Collections.Generic;
using System.Text;

namespace solid.Dependency_Inversion_Principle.Before
{
    public class Boss
    {
        public void Work(Computer computer)
        {
            if (computer.IsBroke())
            {
                FixComputer(computer);
            }
        }

        private void FixComputer(Computer computer)
        {

        }
    }

    public class Computer
    {
        public bool IsBroke()
        {
            return default;
        }
    }
}
