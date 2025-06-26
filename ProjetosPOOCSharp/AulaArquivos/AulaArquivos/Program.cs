using System.IO;
using System.Collections.Generic;
namespace AulaArquivos
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            //Aula apresentando File, FileInfo e IOException
             
            string sourcePath = @"C:\Users\maira.silva\Desktop\ProjetosUdemy\ArquivosTXT\file1.txt";
            string targetPath = @"C:\Users\maira.silva\Desktop\ProjetosUdemy\ArquivosTXT\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // FileInfo: instance members
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath); // File: static members
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } 
            */

            /* 
            // Aula sobre FileStream e StreamReader
             
            string path = @"C:\Users\maira.silva\Desktop\ProjetosUdemy\ArquivosTXT\file1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path); //OpenText implicitamente instancia o FileStream e o StreamReader automaticamente, basta infomar o caminho
                //fs = new FileStream(path, FileMode.Open); // instancia um FileStrem(caminho do arq, operação que realizará)
                //sr = new StreamReader(fs); // instancia o StreamReader para leitura do arquivo
                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Maneira de fechar os Streams manualmente 
                if (sr != null) sr.Close();

            }
            */

            //Aula sobre using block - Sintaxe simplificada que garante que os objetos IDisposable serão fechados
            /*
            string path = @"C:\Users\maira.silva\Desktop\ProjetosUdemy\ArquivosTXT\file1.txt";
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            */

            // Aula sobre StreamWriter
            /*
            string sourcePath = @"C:\Users\maira.silva\Desktop\ProjetosUdemy\ArquivosTXT\file1.txt";
            string targetPath = @"C:\Users\maira.silva\Desktop\ProjetosUdemy\ArquivosTXT\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper()); 
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            */


            //Aula sobre Directory (static members) e DirectoryInfo (instance members)
            /*
            string path = @"C:\Users\maira.silva\Desktop\ProjetosUdemy\ArquivosTXT\myfolder";

            try
            {
               //Listar todas subpastas de myfolder
                IEnumerable<string> folders = Directory.EnumerateDirectories(path,"*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                // Listar todos arquivos a partir de uma pasta
                var files= Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                // Criar uma pasta 
                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            */

            // Aula sobre Path
            
            string path = @"C:\Users\maira.silva\Desktop\ProjetosUdemy\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: "+ Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: "+ Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: "+ Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}