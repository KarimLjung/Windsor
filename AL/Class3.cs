using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL
{
    public class Class3 : BaseClass, IClass3Interface
    {
        public Class3()
        {
            base.SaySomething();
        }
        public int Return3()
        {
            return 3;
        }
    }

    public interface IClass3Interface
    {
        int Return3();
    }
}
