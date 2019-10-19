using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoProxy
{
    /// <summary>
    /// Real implementation; to be proxified
    /// </summary>
    class RealSubject : ISubject
    {

        public void Request()
        {
            Console.WriteLine("A specific implementation for RealSubject; this method does all the work");
        }
    }
}
