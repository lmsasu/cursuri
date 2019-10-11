using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyUtils.Exceptions;

namespace MyUtils
{
    public class Vector
    {
        private double[] contents;

        public Vector(int length)
        {
            if (length <= 0)
            {
                throw new IllegalArgumentException();
            }
            contents = new double[length];
        }

        public Vector(double[] contents)
        {
            if (contents == null || contents.Length == 0)
            {
                throw new IllegalArgumentException();
            }
            this.contents = new double[contents.Length];
            Array.Copy(contents, this.contents, contents.Length);
        }

        public int Length
        {
            get
            {
                return contents.Length;
            }
        }

        public double this[int index]
        {
            get
            {
                return contents[index];
            }
            set
            {
                contents[index] = value;
            }
        }
    }
}
