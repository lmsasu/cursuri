using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Startup
{
    class Injector
    {
        private static IKernel _kernel;
        public static IKernel Kernel
        {
            get
            {
                if (_kernel == null)
                {
                    throw new ArgumentNullException("Injection method should be called first!");
                }

                return _kernel;
            }
        }

        public static void Inject()
        {
            _kernel = new StandardKernel(new Bindings());
            _kernel.Load(Assembly.GetExecutingAssembly());
        }

        public static T Get<T>()
        {
            return _kernel.Get<T>();
        }
    }
}
