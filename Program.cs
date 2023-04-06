using ExceptionHandling;

namespace Day10_ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            PersonCategorybasedoAge categorized =new PersonCategorybasedoAge();
            categorized.GetCategory(age);
        }
    }
}