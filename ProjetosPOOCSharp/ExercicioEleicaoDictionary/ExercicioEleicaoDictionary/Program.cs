namespace ExercicioEleicaoDictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> votacao = new Dictionary<string, int>();
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream){
                        string[] line = sr.ReadLine().Split(',');
                        int votos = int.Parse(line[1]);

                        if (!(votacao.ContainsKey(line[0])))
                        {
                            votacao.Add(line[0], votos);
                        }
                        else
                        {
                            votacao[line[0]] += votos;
                        }
                    }
                }
                foreach (var v in votacao)
                {
                    Console.WriteLine(v.Key + ": " + v.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}