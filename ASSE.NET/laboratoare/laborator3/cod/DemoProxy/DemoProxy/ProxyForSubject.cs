using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoProxy
{
    class ProxyForSubject : ISubject
    {
        private ISubject _realSubject;

        public void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();//lazy initalization
            }
            //check some conditions / do something *before* calling the _realSubject
            Console.WriteLine( "check some conditions / do something *before* calling the _realSubject" );
            _realSubject.Request();
            Console.WriteLine("do something *after* calling the _realSubject");
            //do something *after* calling the _realSubject
        }
    }
}
