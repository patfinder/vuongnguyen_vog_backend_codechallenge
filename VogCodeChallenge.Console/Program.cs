namespace VogCodeChallenge.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Running TestMethod ...");
            QuestionClass.TestMethod();

            System.Console.WriteLine("Running TESTModule ...");
            object input = 1.0f;
            object result = QuestionClass.TESTModule(input);
            System.Console.WriteLine($"Input: {input}, result: {result}");

            System.Console.ReadLine();
        }
    }
}
