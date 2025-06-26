using System.Collections.Generic;
using AulaHashSetESortedSet.Entities;
namespace AulaHashSetESortedSet
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("HashSet Exemplo: ");
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));
            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nSortedSet Exemplo"); 
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10};

            PrintCollection(a);

            // union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); // Insere todos elementos de b que não estejam em c
            PrintCollection(c);

            // intersection 
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); // elementos que possuem nos dois conjuntos
            PrintCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // exclui os elementos que possuem em a e b
            PrintCollection(e);

            Console.WriteLine("\nExemplo comparação de igualdade com coleções hash: ");
            HashSet<Product> x = new HashSet<Product>();
            x.Add(new Product("TV", 900.0));
            x.Add(new Product("Notebook", 1200.0));

            HashSet<Point> y = new HashSet<Point>();
            y.Add(new Point(3, 4));
            y.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0); // cria outro obj que aponta pra outro endereço, não é o mesmo de x
            Console.WriteLine(x.Contains(prod)); // return true depois de ditarmos a verificação do conteudo dos dois obj e nao a ref, uso de GetHashCode e Equals

            Point p = new Point(5, 10); 
            Console.WriteLine(y.Contains(p)); // return true, mesmo que não haja Equals e GetHashCode ele verifica a se tipo ref e dps o tipo struct
        }
        // IEnumerable = interface de collections generic, percorre coleções
        static void PrintCollection<T> (IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}