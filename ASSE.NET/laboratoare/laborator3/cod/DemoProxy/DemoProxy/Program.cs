using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new ProxyForSubject();
            subject.Request();
        }
    }
}
