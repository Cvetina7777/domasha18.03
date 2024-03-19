namespace zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi izrechenie:");
            string input = Console.ReadLine();

            Console.WriteLine("Otpechatvane na izrechenieto bukva po bukva");
            foreach (char letter in input)
            {
                Console.WriteLine(letter);
            }

            Console.ReadLine();
        }
    }
}