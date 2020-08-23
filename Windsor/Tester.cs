using System;
using AL;

namespace Windsor
{
    internal class Tester
    {
        private readonly IClass1Interface class1Interface;

        public Tester(IClass1Interface class1Interface)
        {
            this.class1Interface = class1Interface;
        }

        internal void InvokeClass1()
        {
            Console.WriteLine(class1Interface.Return1());
        }
    }
}