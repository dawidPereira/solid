using System;
using System.Collections.Generic;
using System.Text;

namespace solid.Dependency_Inversion_Principle.After
{
    public class Boss
    {
        private readonly IITDepartment _itDepartment;

        public Boss(IITDepartment itDepartment)
        {
            _itDepartment = itDepartment;
        }

        public void Work(Computer computer)
        {
            if (computer.IsBroke())
            {
                _itDepartment.FixComputer(computer);
            }
        }
    }

    public interface IITDepartment
    {
        void FixComputer(Computer computer);
    }

    public class Computer
    {
        public bool IsBroke()
        {
            return default;
        }
    }
}
