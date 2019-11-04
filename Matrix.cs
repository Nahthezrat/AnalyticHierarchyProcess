using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticHierarchyProcess
{
    class Matrix
    {
        public double[,] Elements;

        Matrix(double[,] inputMatrix)
        {
            Elements = (double[,])inputMatrix.Clone();
        }
    }
}
