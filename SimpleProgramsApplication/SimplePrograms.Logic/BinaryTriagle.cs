using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePrograms.Logic
{
    public class BinaryTriagle
    {
        public int[,] Triangle { get; set; }

        public void GenerateBinaryTriangle(int number)
        {
            int binary = 1;
             Triangle= new int[number,number];

            for (int i = 0; i < Triangle.GetLength(0); i++)
            {
       
                for (int j = 0; j <= i; j++)
                {
                    if(binary == 1)
                    {
                        Triangle[i, j] = binary;
                        binary = 0;
                        Console.Write(binary);
                    }
                    else
                    {
                        Triangle[i, j] = binary;
                        binary = 1;
                        Console.Write(binary);
                    }
  
                }
                Console.WriteLine();
            }

        }
    }
}
