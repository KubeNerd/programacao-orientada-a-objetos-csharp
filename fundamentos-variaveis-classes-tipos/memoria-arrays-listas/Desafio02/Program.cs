using System;

namespace Course {
    class Program {
        static void Main(string[] args){
            int n = int.Pase(Console.ReadLine());
            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++){
                
                string[] values = Console.ReadLine().Split(" ");
                for(int j = 0; j < n; j++){
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for(int i=0; i < n; i++){
                Console.WriteLine(mat[i, i] + " ");
            }

            Console.WriteLine();

            for(int i; i < n; i++){
                for(int j = 0; j < n; j++){
                    if(mat[i, j]){
                        count++;
                    }
                }
            }

        }
    }
}