using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorLibrary.Exceptions;

namespace VectorLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class Vector
    {
        private double[] _vector;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <exception cref="System.Exception">The length should be at least 1</exception>
        public Vector(int length)
        {
            if (length <= 0)
            {
                throw new Exception("The length should be at least 1");
            }
            this._vector = new double[length];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector"/> class.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <exception cref="NullContentsException">Null value passed to constructor</exception>
        /// <exception cref="EmptyContentsException">The passed argument has no value inside it</exception>
        public Vector(double[] v)
        {
            if(v == null)
            {
                throw new NullContentsException("Null value passed to constructor");
            }
            if (v.Length == 0)
            {
                throw new EmptyContentsException("The passed argument has no value inside it");
            }
            _vector = new double[v.Length];
            Array.Copy(v, _vector, v.Length);
        }

        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Length
        {
            get { return _vector.Length;  } 
        }


        /// <summary>
        /// Gets or sets the <see cref="System.Double"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.Double"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public double this[int index]
        {
            get { return _vector[index]; }
            set { _vector[index] = value; }
        }

        /// <summary>
        /// Implements the operator +.
        /// </summary>
        /// <param name="v1">The v1.</param>
        /// <param name="v2">The v2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        /// <exception cref="Exception">
        /// Cannot add null vectors
        /// or
        /// The two lengths must coincide
        /// </exception>
        public static Vector operator+(Vector v1, Vector v2)
        {
            if (v1 == null || v2 == null)
            {
                throw new Exception("Cannot add null vectors");
            }
            if (v1.Length != v2.Length)
            {
                throw new Exception("The two lengths must coincide");
            }
            Vector result = new Vector(v1.Length);
            for(int i=0; i<v1.Length; i++)
            {
                result[i] = v1[i] + v2[i];
            }
            return result;
        }


    }
}
