using System;
using System.IO;
using System.Collections.Generic;
using Interface_Icomparable.Entities;

namespace Interface_Icomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream) 
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();
                    foreach (Employee emp in list) 
                    { 
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Arquivo não encontrado: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }
    }
}