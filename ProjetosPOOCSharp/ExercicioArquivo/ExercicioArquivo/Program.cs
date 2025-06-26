using ExercicioArquivo.Entities;
using System;
using System.Globalization;
using System.IO;

namespace ExercicioArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o caminho do arquiv:");
            string sourceFilePath = Console.ReadLine();
            //string sourceFilePath = @"C:\Users\maira.silva\Desktop\ProjetosUdemy\ArquivosCSV\exemplo.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}