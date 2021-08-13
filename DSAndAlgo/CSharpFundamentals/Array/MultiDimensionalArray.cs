using System;

namespace CSharpFundamentals.Array
{
    class MultiDimensionalArray
    {
        #region Example 1

        /// <summary>
        /// Create an empty 2D array
        /// </summary>
        /// <returns></returns>
        public int[,] Create2D()
        {
            int[,] array2D = new int[3, 6];
            return array2D;
        }

        /// <summary>
        /// Fill values in empty 2D array
        /// </summary>
        /// <param name="array2D"></param>
        public void Fill2D(int[,] array2D)
        {
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print all values in 2D array
        /// </summary>
        /// <param name="array2D"></param>
        public void Print2D(int[,] array2D)
        {
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Create a 2D array and assign values
        /// </summary>
        /// <returns></returns>
        public int[,] Create2DAndAssignValues()
        {
            int[,] array2D = new int[3, 6]
            {
                { 1, 2, 3, 4, 5, 6},
                { 11, 12, 13, 14, 15, 16},
                { 21, 22, 23, 24, 25, 26}
            };

            return array2D;
        }

        /* To Test
         
            MultiDimensionalArray multiDimensionalArray = new MultiDimensionalArray();

            int[,] array2D = multiDimensionalArray.Create2D();
            multiDimensionalArray.Fill2D(array2D);
            multiDimensionalArray.Print2D(array2D);

            Console.WriteLine();

            int[,] array2Da = multiDimensionalArray.Create2DAndAssignValues();
            multiDimensionalArray.Print2D(array2Da);

            Console.WriteLine();

        */

        #endregion


        #region Example 2

        /// <summary>
        /// Create a 3D array and assign values
        /// </summary>
        /// <returns></returns>
        public int[,,] Create3DAndAssignValues()
        {
            int[,,] array3D = new int[2, 2, 3] 
            { 
                { 
                    { 1, 2, 3 }, { 4, 5, 6 }
                },
                { 
                    { 7, 8, 9 }, { 10, 11, 12 }
                } 
            };

            return array3D;
        }

        /// <summary>
        /// Print all values in 3D array
        /// </summary>
        /// <param name="array3D"></param>
        public void Print3D(int[,,] array3D)
        {
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write(array3D[i, j, k] + " ");
                    }
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }

        /* To Test
         
            MultiDimensionalArray multiDimensionalArray = new MultiDimensionalArray();
         
            int[,,] array3D = multiDimensionalArray.Create3DAndAssignValues();
            multiDimensionalArray.Print3D(array3D);

        */

        #endregion
    }
}
