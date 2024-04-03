
using _03._04._2024.Models;

namespace _03._04._2024
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Rauf", false, 350m);

            Assistant assistant = new Assistant();

            Manager manager = new Manager();

            assistant.GetFeedback(employee);
        }
    }
}
