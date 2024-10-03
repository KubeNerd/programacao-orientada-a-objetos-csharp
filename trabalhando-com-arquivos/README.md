# FIle, FileInfo
- Namespace System.IO
- Realiza operações com arquivos(create, copy, delete, move, open, etc.) e
  ajuda na criação de objetos FileStream.

- File
    - Static members(simples, mas realiza a verificação de segurança para cada operação)

- FileInfo
    - Instance members

## IOException

- IOException
    - DirectoryNotFoundException
    - DriveNotFoundException
    - EndOfStreamException
    - FileLoadException
    - FileNotFoundException
    - PathToLongException
    - PipeException


```csharp
using System;
using System.IO;

namespace Arquivos
{
  class Program
  {
    static void Main(string[] args)
    {
    
        string sourcePath = @"c:\\temp\file1.txt";
        string targetPath = @"c:\\temp\file2.txt";
      
        try 
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }




        }
        catch (IOException e) 
        {
            Console.WriteLine(e.Message);
        }
    }
  }
}

```