class Program
{
    static void Main()
    {
        PrintName("Prem",10);
 
   }
    static void PrintName(string name, int iterations)
    {
        for (int iteration=1; iteration<=iterations; iteration++)
        {
            Console.WriteLine($"Hello {name.ToUpper()}! {iterations}");
        }
    }
}
