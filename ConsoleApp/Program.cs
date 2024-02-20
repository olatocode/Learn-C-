
namespace MyNamespace
{
   public class Program
    {
        static void Main(string[] args)
        {
            // Basic1 obj = new Basic1();
            // obj.BasicMethod();

            //  Basic2 obj2 = new Basic2();
            // obj2.BasicMethod();

            var p1 =  new Person("Tobi", "Awosola", new DateOnly(2024, 02,12));
            var p2 =  new Person("peace", "glory", new DateOnly(2000, 12,30));
   
            List<Person> people = [p1,p2];
            System.Console.WriteLine(people.Count());
            foreach (var person in people)
            {
                     Console.WriteLine($"My name is {person.first} {person.last} and I was born on {person.bd}  ");
            }
          

          
        }
    }
}
