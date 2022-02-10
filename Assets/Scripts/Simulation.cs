using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    void Start()
    {
        int[,] array1 = new int[3, 2]
        {
            {1, 2},
            {3, 4},
            {5, 6}
        };
        int[,] array2 = new int[3, 2]
        {
            {7, 8},
            {9, 3},
            {4, 7}
        };

        Matrix A = new Matrix(array1);
        Matrix B = new Matrix(array2);

        
        A.SetElement(1, 1, 99);
        A.PrintMatrix();
    }

   
}
