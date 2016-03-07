using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    class NetworkHolderMethod
    {
        int[,] matrix;
        int x, y;
        NetworkHolderMethod()
        {
            
        }
        public void calculate(int[,] matrix)
        {
            x = matrix.GetLength(0);
            y = matrix.GetLength(1);
        }

    }
}
