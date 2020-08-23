using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace InterceptorProject
{
    public class ALInterceptor2 : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Interceptor 2 hit");
            invocation.Proceed();
        }
    }
}
