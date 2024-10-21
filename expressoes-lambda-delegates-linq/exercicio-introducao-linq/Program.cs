using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numeros = new int[] {
            1, 2, 3, 4, 5, 6, 7, 8
        };
        
        IEnumerable<int> result = numeros.Where(x => x % 2 == 0).Select(x => x * 10);
        
        foreach(int x in result)
        {
            Console.Write(x + ",");
        }
    }
}