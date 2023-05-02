using ChainOfResponsabilityLoanLibrary;
public class Program
{
    public static void Main(string[] args)
    {
        string input = "2,3";

        var check1 = new SetUpChain().GetChain;
        var result1 = check1.ProcessInput(input);
        Console.WriteLine($"Input: {input}, Result: {result1.Item2}");

        
    }
}




