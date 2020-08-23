using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptorProject
{
    public class ALInterceptor3 : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Interceptor 3 hit");
            invocation.Proceed();
        }
    }
}
