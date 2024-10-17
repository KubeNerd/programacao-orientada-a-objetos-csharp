using System;
using System.IO;
using exercicio_conjuntos_get_hashset.Entities;

namespace exercicio_conjuntos_get_hashset
{
    class Program
    {
        static void Main(string[] args)
        {

            string LogPath = "./log.txt";

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            try 
            {
                using (StreamReader sr = new StreamReader(LogPath))
                {
                    while (!sr.EndOfStream)
                    {


                        string[] lines = sr.ReadLine().Split(" ");

                        string name = lines[0];
                        DateTime instant = DateTime.Parse(lines[1]);


                        set.Add(new LogRecord { UserName = name, Instant = instant });


                    }

                }


                foreach (LogRecord user in set) {
                    
                    Console.WriteLine(user.UserName);
                
                }

            } 


            catch (IOException e) 
            { 
                
                Console.WriteLine(e.Message);
            
            }
        }
    }
}