using System;

namespace CSharpFundamentals.Array
{
    class JaggedArray
    {

        #region Example 1

        /// <summary>
        /// Create an empty jagged array
        /// </summary>
        /// <returns></returns>
        public int[][] Create()
        {
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[6];
            //jagged[1] = new int[8];
            //jagged[2] = new int[5];

            //OR

            int[][] jagged = new int[3][]
            {
                new int[6],
                new int[8],
                new int[5] 
            };

            return jagged;
        }

        /// <summary>
        /// Fill values in empty jagged array
        /// </summary>
        /// <param name="jagged"></param>
        public void Fill(int[][] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Create a jagged array and assign values
        /// </summary>
        /// <returns></returns>
        public int[][] CreateAndAssignValues()
        {
            int[][] jagged = new int[3][]
            {
                new int[] { 1, 2, 3, 4, 5, 6 },
                new int[] { 11, 12, 13, 14, 15, 16, 17, 18 },
                new int[] { 21, 22, 23, 24, 25}
            };

            return jagged;
        }

        /// <summary>
        /// Print all values in jagged array
        /// </summary>
        /// <param name="jagged"></param>
        public void Print(int[][] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print all values in jagged array using foreach
        /// </summary>
        /// <param name="jagged"></param>
        public void PrintUsingForEach(int[][] jagged)
        {
            foreach (int[] arr in jagged)
            {
                foreach (int item in arr)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }

        /* To Test
         
            JaggedArray jagged = new JaggedArray();
            int[][] arr = jagged.Create();
            jagged.Print(arr);
            jagged.Fill(arr);
            jagged.Print(arr);

            Console.WriteLine();

            int[][] arr1 = jagged.CreateAndAssignValues();
            jagged.PrintUsingForEach(arr1);

        */

        #endregion


        #region Example 2 - Interesting

        /// <summary>
        /// Create arrays of multidimensional array and assign values
        /// </summary>
        /// <returns></returns>
        public int[][,] CreateMixedJaggedArrayAndAssignValues()
        {
            int[][,] jagged = new int[3][,]
             {
                new int[2,2] 
                    { 
                        {1,3},
                        {5,7} 
                    },
                new int[3,2] 
                    { 
                        {0,2},
                        {4,6},
                        {8,10}
                    },
                new int[4,2] 
                    { 
                        {11,22},
                        {99,88},
                        {0,9},
                        {31, 32}
                    }
             };

            return jagged;
        }

        /// <summary>
        /// Print all values in mixed jagged array
        /// </summary>
        /// <param name="jagged"></param>
        public void PrintMixedJaggedArray(int[][,] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].GetLength(0); j++)
                {
                    for (int k = 0; k < jagged[i].GetLength(1); k++)
                    {
                        Console.Write(jagged[i][j,k] + " ");
                    }
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }

        /* To Test
         
            JaggedArray jaggedArray = new JaggedArray();
            int[][,] arr = jaggedArray.CreateMixedJaggedArrayAndAssignValues();
            jaggedArray.PrintMixedJaggedArray(arr);

        */

        #endregion
    }
}
