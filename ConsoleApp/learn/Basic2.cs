namespace MyNamespace
{
    public class Basic2
    {
        public void BasicMethod()
        {

        var names = new List<string> {"Tobi", "Kunle", "Ola", "Segun"};

        foreach (var name in names)
        {
            // System.Console.WriteLine($"The List of Nitt Employee is: {name}");
        }

// List<int> scores = [60, 70, 40, 50];

var scores = new List<int> { 60, 70, 40, 50 };
            if (scores.Count() == 4)
          {
             Console.WriteLine($" The total scores is {scores.Sum()} and is correct");

          }else {
            Console.WriteLine($" The number of scores is {scores.Count()} and is incorrect");
          }
            // Defining linq query expression
            // IEnumerable<int> scoreQuery =
            // from score in scores
            // where score > 50
            // orderby score descending
            // select score;
            // List<int> myScores = scoreQuery.ToList();
           
            // linq chaining query
            // var scoreQuery2 = scores.Where(s => s > 50)
            // .OrderByDescending(s => s);
            //  Console.WriteLine($"{scoreQuery2.Sum()}");

//  numbers.Sort()
        // foreach (var score in scoreQuery2)
        // {
        //     Console.WriteLine($"{score}");
        // }

        }
    }
}
