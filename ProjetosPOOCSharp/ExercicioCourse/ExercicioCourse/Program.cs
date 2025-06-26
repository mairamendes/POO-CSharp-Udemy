using ExercicioCourse;

namespace ExercicioCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            try
            {
                Console.Write("How many students for course A? ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                    courseA.Add(int.Parse(Console.ReadLine()));

                Console.Write("How many students for course B? ");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                    courseB.Add(int.Parse(Console.ReadLine()));

                Console.Write("How many students for course C? ");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                    courseC.Add(int.Parse(Console.ReadLine()));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            HashSet<int> students = new HashSet<int>(courseA);
            students.UnionWith(courseB);
            students.UnionWith(courseC);
            Console.WriteLine("Total students: " + students.Count);
        }
    }
}