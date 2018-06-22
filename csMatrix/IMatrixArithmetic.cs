﻿using System;
using System.Collections.Generic;
using System.Text;

namespace csMatrix
{
    /// <summary>
    /// Interface that Matrix classes use for arithmetic uses.
    /// </summary>
    interface IMatrixArithmetic
    {
        void Add(Matrix m1, Matrix m2);
        void Add(Matrix m, double scalar);
        void Negate(Matrix m);
        void Subtract(Matrix m1, Matrix m2);
        void Subtract(Matrix m, double scalar);
        Matrix Multiply(Matrix m1, Matrix m2);
        void Multiply(Matrix m, double scalar);
        void Divide(Matrix m, double scalar);
    }
}
