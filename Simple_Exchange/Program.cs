internal class Program
{
    static void Main(string[] args)
    {
        float uahInWallett;
        float dollarsInWallett;

        int uahToUsd = 36, usdToUah = 40;

        float exchangeCurrencyCount;

        string desiredOperation;

        Console.WriteLine("Welcome to currency exchange service!");

        Console.Write("Enter ballance UAH: ");
        uahInWallett = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter ballacne USD: ");
        dollarsInWallett = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Choice the needed operation ");
        Console.WriteLine("1 = UAH to USD ");
        Console.WriteLine("2 = USD to UAH ");

        desiredOperation = Console.ReadLine();

        switch (desiredOperation)
        {
            case "1":
                Console.WriteLine("Change of UAH into USD))");
                Console.Write("How much do you need to change? ");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if (uahInWallett >= exchangeCurrencyCount)
                {
                    uahInWallett -= exchangeCurrencyCount;
                    dollarsInWallett += exchangeCurrencyCount / uahToUsd;
                }
                else
                {
                    Console.WriteLine("Not enought RUB!");
                }
                break;
            case "2":
                Console.WriteLine("Change of USD intoto UAH");
                Console.Write("How much do you need to change? ");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if (dollarsInWallett >= exchangeCurrencyCount)
                {
                    dollarsInWallett -= exchangeCurrencyCount;
                    uahInWallett += exchangeCurrencyCount * usdToUah;
                }
                else
                {
                    Console.WriteLine("Not enought USD!");
                }
                break;
            default:
                Console.WriteLine("Wrong operation");
                break;
        }

        Console.WriteLine($"Your ballance: {uahInWallett} UAH " + $" {dollarsInWallett} USD");
    }

}