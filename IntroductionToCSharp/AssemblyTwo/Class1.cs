using System;
using AssemblyOne;

namespace AssemblyTwo
{
    //public class AssemblyTwoClassI : AssemblyOneClassI
    //{
    //    public void Print()
    //    {
    //        AssemblyOneClassI A1 = new AssemblyOneClassI();
    //        base.ID = 100;

    //        AssemblyTwoClassI A2 = new AssemblyTwoClassI();
    //        A2.ID = 100;
    //    }
    //}

    public class AssemblyTwoClass
    {
        public void Test()
        {
            AssemblyOneClass instance = new AssemblyOneClass();
            instance.Print();
        }
    }
}
