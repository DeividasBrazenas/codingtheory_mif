﻿using System;

namespace ReedMullerCode.Matrices
{
    public class HMatrix : Matrix
    {
        public HMatrix(int i, int m)
        {
            _data = GenerateHMatrix(i, m);
        }

        private static int[,] GenerateHMatrix(int i, int m)
        {
            if (i < 1)
            {
                return null;
            }

            return new IMatrix((int)Math.Pow(2, m - i)).GetKroneckerProduct(new Matrix(new[,] { { 1, 1 }, { 1, -1 } }))
                .GetKroneckerProduct(new IMatrix((int)Math.Pow(2, i - 1))).GetData();
        }
    }
}
