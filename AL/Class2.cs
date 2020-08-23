using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL
{
    public class Class2 : ServiceBase, IClass2Interface
    {
        private readonly IClass3Interface class3Interface;

        public Class2(IClass3Interface class3Interface)
        {
            this.class3Interface = class3Interface;
        }

        public int Return2()
        {
            class3Interface.Return3();
            return 2;
        }
    }

    public interface IClass2Interface
    {
        int Return2();
}
}
