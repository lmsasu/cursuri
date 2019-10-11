using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary.Exceptions
{
    /// <summary>
    /// Models the exception type thown when a null argument is passed as argument
    /// </summary>
    public class NullContentsException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullContentsException"/> class.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public NullContentsException(String message) : base(message)
        {

        }
    }
}
