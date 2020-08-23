using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL
{
    public class Class1 : IClass1Interface
    {
        private readonly IClass2Interface class2Interface;

        public Class1(IClass2Interface class2Interface)
        {
            this.class2Interface = class2Interface;
        }
        public int Return1()
        {
            class2Interface.Return2();
            return 1;
        }
    }

    public interface IClass1Interface
    { 
        int Return1();
    }
}
