namespace carpetProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Islam's Carpet Cleaning Service there is an offer valid for 30 days which is $25 per small carpet and $35 for large carpet prices not including taxes ");
            Console.WriteLine("let us know how many small carpets you need to clean");
            int smallCarpets = int.Parse(Console.ReadLine());
            Console.WriteLine("also let us know how many large carpets you need to clean");
            int largeCarpets = int.Parse(Console.ReadLine());
            int subtotal = (smallCarpets * 25) + (largeCarpets * 35);
            double taxCalculate = (subtotal * 0.06 ) ;
            double total = subtotal + taxCalculate;
            Console.WriteLine($"subtotal will be {subtotal} and total will be {total}");
        }
    }
}
