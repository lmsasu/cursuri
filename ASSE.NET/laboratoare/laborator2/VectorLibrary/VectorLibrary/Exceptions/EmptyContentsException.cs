using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary.Exceptions
{
    /// <summary>
    /// Models the exception type for specifying no contents for a vector
    /// </summary>
    public class EmptyContentsException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyContentsException"/> class.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public EmptyContentsException(String message) : base(message)
        {

        }
    }
}
