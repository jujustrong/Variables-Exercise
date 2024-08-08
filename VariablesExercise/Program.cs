namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string foxName = "Kit";
            int foxAge = 7;
            char foxInitial = 'K';
            bool isAwesome = true;
            double foxHeight = 15.5;
            decimal foxLifeSpan = 200;
            
            Console.WriteLine($"Hey my name is {foxName} but you can call me {foxInitial}! " +
                              $"I am {foxAge} years old and its {isAwesome} I am awesome! I am {foxHeight}in tall " +
                              $"and i will live for {foxLifeSpan} years.");

        }
    }
}
