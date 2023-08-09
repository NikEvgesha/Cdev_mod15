namespace Cdev_mod15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
                };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var students = classes.SelectMany(cl => cl.Students);           
            return students.ToArray();
        }

    }
    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}