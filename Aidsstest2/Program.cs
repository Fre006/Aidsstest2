namespace Aidsstest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = new()
            {
                "hvedemel", "Bagepulver", "Fint salt", "æg", "sukker", "vaniljesukker", "smeltet smør", "bananer", "mørk chokolade"

            };
            List<string> amounts = new()
            {
                "200g", "2 teskeer", "½ teske", "2", "150g", "1 teske", "125g", "2", "100g"
            };
            for(int i = 0; i < 9; i++)
            {
                Console.Write(amounts[i]);
                Console.Write(" ");
                Console.WriteLine(groceries[i]);
            }
        }
    }
}
