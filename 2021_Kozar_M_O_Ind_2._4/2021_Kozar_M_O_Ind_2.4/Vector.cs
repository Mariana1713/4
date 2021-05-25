using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_Kozar_M_O_Ind_2._4
{
    class Vector
    {
        private double[] vector;
        private int numElements;
        public Vector(Vector vec)
        {
            vector = new double[0];
            numElements = 0;
        }
        public Vector (double[] vector)
        {
            this.vector = vector;
            this.numElements = vector.Length;
        }
        public double[] VectorValue()
        {
            return this.vector;
        }
        public double ElementsValue(int i)
        {
            return vector[i];
        }
        public int GetLength()
        {
            return numElements;
        }
       public static Vector Add(Vector f, Vector s)
       {
            double[] add = new double[f.GetLength()];
            if (f.GetLength() == s.GetLength())
            {
                for (int i=0; i<f.GetLength();++i)
                {
                    add[i] = f.ElementsValue(i) + s.ElementsValue(i);
                }
                Vector result = new Vector(add);
                return result;

            }
            else
            {
                Vector r = new Vector(add);
                return r;
            }
       }
        public static double Scalar(Vector f, Vector s)
        {
            double scal = 0;
            for (int i = 0; i < f.GetLength(); ++i)
            {
                scal += f.ElementsValue(i) * s.ElementsValue(i);

            }
            return scal;
        }

    }
}
